using QuanLyCafe.DAO;
using QuanLyCafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp;
using static QuanLyCafe.fAccountProfile;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;
using COMExcel = Microsoft.Office.Interop.Excel;

namespace QuanLyCafe
{
    public partial class fTableManager : Form
    {

        private Account loginAccount;
        public Account LoginAccount 
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount.Type); }
        }
        public fTableManager(Account acc)
        {
            InitializeComponent();
            this.LoginAccount = acc;
            LoadTable();
            LoadCategory();
            LoadComboboxTable(cbSwitchTable);
        }

        private void lsvBill_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        #region Method
        void ChangeAccount(int type)
        {
            adminToolStripMenuItem.Enabled = type == 1;
            thôngTinTàiKhoảnToolStripMenuItem.Text += " ( " + LoginAccount.DisplayName + " ) ";
        }
        void LoadCategory()
        {
            List<Category> listCategory = CategoryDAO.Instance.GetListCategory();
            cbCategory.DataSource = listCategory;
            cbCategory.DisplayMember = "name";
        }
        void LoadFoodListByCategoryID(int id)
        {
            List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(id);
            cbFood.DataSource = listFood;
            cbFood.DisplayMember = "name";
        }
        void LoadTable()
        {
            flowTable.Controls.Clear();
            List<Table> tableList = TableDAO.Instance.LoadTableList();
            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width = TableDAO.TableWight, Height = TableDAO.TableHeight };
                btn.Text = item.Name + Environment.NewLine + item.Status;
                btn.Click += btn_Click;
                btn.Tag = item;
                switch (item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.Aqua;
                        break;
                    default:
                        btn.BackColor = Color.LightPink;
                        break;

                }
                flowTable.Controls.Add(btn);
            }
        }

        void ShowBill(int id)
        {
            lvsBill.Items.Clear();
            List<DTO.Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(id);
            float totalPrice = 0;
            foreach (DTO.Menu item in listBillInfo)
            {
                ListViewItem lvsItem = new ListViewItem(item.FoodName.ToString());
                lvsItem.SubItems.Add(item.Count.ToString());
                lvsItem.SubItems.Add(item.Price.ToString());
                lvsItem.SubItems.Add(item.TotalPrice.ToString());
                totalPrice += item.TotalPrice;
                lvsBill.Items.Add(lvsItem);
            }
            CultureInfo culture = new CultureInfo("vi-VN");
            Thread.CurrentThread.CurrentCulture = culture;
            txtTotalPrice.Text = totalPrice.ToString("c");
        }
        void LoadComboboxTable(ComboBox cb)
        {
            cb.DataSource = TableDAO.Instance.LoadTableList();
            cb.DisplayMember = "name";
        }
        #endregion

        #region Events
        private void btn_Click(object sender, EventArgs e)
        {
            int TableID = ((sender as Button).Tag as Table).ID;
            lvsBill.Tag = (sender as Button).Tag;
            ShowBill(TableID);

        }
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void tácGiảPhầnMềmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAppProfile f = new fAppProfile();
            f.ShowDialog();
        }
        private void thôngTinCáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccountProfile f = new fAccountProfile(LoginAccount);
            f.UpdateAccount += f_UpdateAccount;
            f.ShowDialog();
        }
        void f_UpdateAccount(object sender, AccountEvent e)
        {
            thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản (" +e.Acc.DisplayName+")";
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            f.loginAccount = LoginAccount;
            f.InsertFood += f_InsertFood;
            f.UpdateFood += f_UpdateFood;
            f.DeleteFood += f_DeleteFood;
            f.ShowDialog();
        }

         void f_DeleteFood(object sender, EventArgs e)
        {
            LoadFoodListByCategoryID((cbCategory.SelectedItem as Category).ID);
            if(lvsBill.Tag!=null)
                ShowBill((lvsBill.Tag as Table).ID);
            LoadTable();
        }

         void f_UpdateFood(object sender, EventArgs e)
        {
            LoadFoodListByCategoryID((cbCategory.SelectedItem as Category).ID);
            if(lvsBill.Tag!=null)
                ShowBill((lvsBill.Tag as Table).ID);
            
        }

         void f_InsertFood(object sender, EventArgs e)
        {
            LoadFoodListByCategoryID((cbCategory.SelectedItem as Category).ID);
            if(lvsBill.Tag!=null)
                ShowBill((lvsBill.Tag as Table).ID);
        }
        #endregion

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;
            Category selected = cb.SelectedItem as Category;
            id = selected.ID;
            LoadFoodListByCategoryID(id);
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            Table table = lvsBill.Tag as Table;
            if (table == null)
            {
                MessageBox.Show("Vui lòng chọn bàn !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
            int foodID = (cbFood.SelectedItem as Food).ID;
            int count = (int)nmFoodCount.Value;
            if (idBill == -1)
            {
                BillDAO.Instance.InsertBill(table.ID);
                BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIDBill(), foodID, count);
            }
            else
            {
                BillInfoDAO.Instance.InsertBillInfo(idBill, foodID, count);
            }
            ShowBill(table.ID);
            LoadTable();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            Table table = lvsBill.Tag as Table;
            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
            int discount = (int)nmDisCount.Value;
            float totalPrice = float.Parse(txtTotalPrice.Text.Split(' ')[0]);
            float finalTotalPrice = totalPrice - (totalPrice / 100) * discount;
            if (idBill != -1)
            {
                if (MessageBox.Show(string.Format("*** BẠN CÓ CHẮC CHẮN THANH TOÁN {0} ***\nTổng tiền - (Tổng tiền / 100)*Giảm giá\n{1} - ({1}/100) x {2} = {3}", table.Name, totalPrice, discount, finalTotalPrice), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    BillDAO.Instance.CheckOut(idBill, discount,(float)finalTotalPrice);
                    ShowBill(table.ID);
                    LoadTable();
                }
            }
        }
        private void fTableManager_Load(object sender, EventArgs e)
        {

        }


        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxEx1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;
            Category selected = cb.SelectedItem as Category;
            id = selected.ID;
            LoadFoodListByCategoryID(id);
        }

        Random random = new Random();
        int x = -3, y = 434, a = 1;

        

        private void cbSwitchTable_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void thanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnCheckOut_Click(this, new EventArgs());
        }

        private void thêmMónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAddFood_Click(this, new EventArgs());
        }

        private void btnAdd_Food_Click(object sender, EventArgs e)
        {
            Table table = lvsBill.Tag as Table;
            if (table == null)
            {
                MessageBox.Show("Vui lòng chọn bàn !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
            int foodID = (cbFood.SelectedItem as Food).ID;
            int count = (int)nmFoodCount.Value;
            if (idBill == -1)
            {
                BillDAO.Instance.InsertBill(table.ID);
                BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIDBill(), foodID, count);
            }
            else
            {
                BillInfoDAO.Instance.InsertBillInfo(idBill, foodID, count);
            }
            ShowBill(table.ID);
            LoadTable();
        }

        private void btnCheck_Out_Click(object sender, EventArgs e)
        {
            Table table = lvsBill.Tag as Table;
            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
            int discount = (int)nmDisCount.Value;
            float totalPrice = float.Parse(txtTotalPrice.Text.Split(' ')[0]);
            float finalTotalPrice = totalPrice - (totalPrice / 100) * discount;

            if (idBill != -1)
            {
                if (MessageBox.Show(string.Format("*** BẠN CÓ CHẮC CHẮN THANH TOÁN {0} ***\nTổng tiền - (Tổng tiền / 100)*Giảm giá\n{1} - ({1}/100) x {2} = {3}", table.Name, totalPrice, discount, finalTotalPrice), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    BillDAO.Instance.CheckOut(idBill, discount, (float)finalTotalPrice);
                    ShowBill(table.ID);
                    LoadTable();
                }
            }
           

        }
        private void btnSwitch_Table_Click(object sender, EventArgs e)
        {
            int id1 = (lvsBill.Tag as Table).ID;
            int id2 = (cbSwitchTable.SelectedItem as Table).ID;
            if (MessageBox.Show(string.Format("Bạn Có Thật Sự Muốn Chuyển {0} Qua {1}", (lvsBill.Tag as Table).Name, (cbSwitchTable.SelectedItem as Table).Name), "Thông Báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                TableDAO.Instance.SwitchTable(id1, id2);
                LoadTable();
            }
        }

        private void chuyểnBànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnSwitch_Table_Click(this,new EventArgs());
        }

        private void btnSwitchTable_Click(object sender, EventArgs e)
        {
            int id1 = (lvsBill.Tag as Table).ID;
            int id2 = (cbSwitchTable.SelectedItem as Table).ID;
            if (MessageBox.Show(string.Format("Bạn Có Thật Sự Muốn Chuyển {0} Qua {1}", (lvsBill.Tag as Table).Name, (cbSwitchTable.SelectedItem as Table).Name),"Thông Báo", MessageBoxButtons.OKCancel)== System.Windows.Forms.DialogResult.OK) {
                TableDAO.Instance.SwitchTable(id1,id2);
                LoadTable();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                x += a;
                label2.Location = new Point(x, y);
                if (x >= 434)
                {
                    a = -1;
                    label2.ForeColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
                }
                if (x <= -3)
                {
                    a = 1;
                    label2.ForeColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
                }
            }
            catch (Exception ex) { }
        }
    }
}
