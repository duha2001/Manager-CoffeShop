using QuanLyCafe.DAO;
using QuanLyCafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCafe
{
    public partial class fAdmin : Form
    {
        BindingSource foodList = new BindingSource();
        BindingSource accountList = new BindingSource();
        BindingSource foodCategoryList = new BindingSource();
        public Account loginAccount;
        public fAdmin()
        {
            InitializeComponent();
            Load1();
        }
        #region Nháp
        private void dtgvBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        

       

        private void fAdmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyQuanCafe2DataSet4.FOOD' table. You can move, or remove it, as needed.
            this.fOODTableAdapter2.Fill(this.quanLyQuanCafe2DataSet4.FOOD);
            // TODO: This line of code loads data into the 'quanLyQuanCafe2DataSet3.FOOD' table. You can move, or remove it, as needed.
            this.fOODTableAdapter1.Fill(this.quanLyQuanCafe2DataSet3.FOOD);
            // TODO: This line of code loads data into the 'quanLyQuanCafe2DataSet2.FOODCATEGORY' table. You can move, or remove it, as needed.
            this.fOODCATEGORYTableAdapter.Fill(this.quanLyQuanCafe2DataSet2.FOODCATEGORY);
            // TODO: This line of code loads data into the 'quanLyQuanCafe2DataSet1.ACCOUNT' table. You can move, or remove it, as needed.
            this.aCCOUNTTableAdapter.Fill(this.quanLyQuanCafe2DataSet1.ACCOUNT);
            // TODO: This line of code loads data into the 'quanLyQuanCafe2DataSet.FOOD' table. You can move, or remove it, as needed.
            this.fOODTableAdapter.Fill(this.quanLyQuanCafe2DataSet.FOOD);
            this.USP_GetListBillByDateForReportTableAdapter.Fill(this.QuanLyQuanCafe2DataSet5.USP_GetListBillByDateForReport, dtpkFromDate.Value, dtpkToDate.Value);
            this.reportViewer1.RefreshReport();
        }

        private void dtgvFood_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tpFood_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtgvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbFoodCatetory_Click(object sender, EventArgs e)
        {

        }

        private void tcAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }
        #endregion
        private void dtpkFromDate_ValueChanged(object sender, EventArgs e)
        {
            
        }
        private void cbFoodCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        #region method
        List<Food> SearchFoodByName(string name)
        {
            List<Food> listfood = FoodDAO.Instance.SearchFoodByName(name);
            return listfood;
        }
        void Load1()
        {
            dtgvCategory.DataSource = foodCategoryList;
            dtgvFood.DataSource = foodList;
            dtgvAccount.DataSource = accountList;
            LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
            LoadDateTimePickerBill();
            LoadListFood();
            LoadAccount();
            AddFoodBinding();
            LoadCategoryIntoCombobox(cbFoodCategory);
            AddAccountBinding();
            LoadCategory();
            AddCategoryBinding();
        }
        void AddCategoryBinding()
        {
            txbCategoryID.DataBindings.Add(new Binding("Text", dtgvCategory.DataSource, "id", true, DataSourceUpdateMode.Never));
            txbNameFoodCategory.DataBindings.Add(new Binding("Text", dtgvCategory.DataSource, "name", true, DataSourceUpdateMode.Never));
        }
        void AddAccountBinding()
        {
            txtUserName.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "UserName",true,DataSourceUpdateMode.Never));
            txbDisplayName.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "DisplayName",true,DataSourceUpdateMode.Never));
            nmType.DataBindings.Add(new Binding("Value", dtgvAccount.DataSource, "Type", true, DataSourceUpdateMode.Never));
        }
        void LoadCategory()
        {
            foodCategoryList.DataSource = CategoryDAO.Instance.GetListCategory();
        }
        void AddFoodCategory(string name)
        {
            if (CategoryDAO.Instance.InsertCategory(name))
            {
                MessageBox.Show("Thêm danh mục thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm danh mục thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void EditFoodCategory(string name,int id)
        {
            if (CategoryDAO.Instance.UpdateCategory(name,id))
            {
                MessageBox.Show("Cập nhập danh mục thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cập nhập danh mục thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void DeleteFoodCategory(int id)
        {
            if (CategoryDAO.Instance.DeleteCategory(id))
            {
                MessageBox.Show("Xóa danh mục thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Xóa danh mục thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void LoadAccount()
        {
            accountList.DataSource = AccountDAO.Instance.GetListAccount();
        }
        void AddAccount(string userName,string displayName,int type)
        {
            if (AccountDAO.Instance.InsertAccount(userName, displayName, type))
            {
                MessageBox.Show("Thêm tài khoản thành công","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm tài khoản thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadAccount();
        }
        void EditAccount(string userName, string displayName,int type)
        {
            if (AccountDAO.Instance.UpdateAccount(userName, displayName, type))
            {
                MessageBox.Show("Sửa tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Sửa tài khoản thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadAccount();
        }
        void DeleteAccount(string userName)
        {
            if (loginAccount.UserName.Equals(userName))
            {
                MessageBox.Show("Bạn không thể xóa tài khoản Admin đang đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (AccountDAO.Instance.DeleteAccount(userName))
            {
                MessageBox.Show("Xóa tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Xóa tài khoản thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadAccount();
        }
        void ResetPass(string userName)
        {
            if (AccountDAO.Instance.ResetPassword(userName))
            {
                MessageBox.Show("Reset mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Reset mật khẩu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void LoadDateTimePickerBill()
        {
            DateTime today = DateTime.Now;
            dtpkFromDate.Value = new DateTime(today.Year, today.Month, 1);
            dtpkToDate.Value = dtpkFromDate.Value.AddMonths(1).AddDays(-1);
        }
        void LoadListBillByDate(DateTime checkIn,DateTime chekcOut)
        {
            dtgvBill.DataSource = BillDAO.Instance.GetBillListByDate(checkIn, chekcOut);
        }
        void LoadListFood()
        {
            foodList.DataSource = FoodDAO.Instance.GetListFood();
        }
        void AddFoodBinding()
        {
            txbFoodName.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "Name",true,DataSourceUpdateMode.Never));
            txbFoodID.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "ID",true, DataSourceUpdateMode.Never));
            nmFoodPrice.DataBindings.Add(new Binding("Value", dtgvFood.DataSource, "Price",true, DataSourceUpdateMode.Never));
        }
        void LoadCategoryIntoCombobox(ComboBox cb)
        {
            cb.DataSource = CategoryDAO.Instance.GetListCategory();
            cb.DisplayMember = "Name";
        }
        #endregion
        #region event
        private void button1_Click(object sender, EventArgs e)
        {
            LoadListBillByDate(dtpkFromDate.Value,dtpkToDate.Value);
        }
        private event EventHandler insertFood;
        public event EventHandler InsertFood
        {
            add { insertFood += value; }
            remove { insertFood -= value; }
        }
        private event EventHandler deleteFood;
        public event EventHandler DeleteFood
        {
            add { deleteFood += value; }
            remove { deleteFood -= value; }
        }
        private event EventHandler updateFood;
        public event EventHandler UpdateFood
        {
            add { updateFood += value; }
            remove { updateFood -= value; }
        }

        private void btn_Add_Food_Click(object sender, EventArgs e)
        {
            string name = txbFoodName.Text;
            int categoryID = (cbFoodCategory.SelectedItem as Category).ID;
            float price = (float)nmFoodPrice.Value;
            if (FoodDAO.Instance.InsertFood(name, categoryID, price))
            {
                MessageBox.Show("Thêm món thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadListFood();
                if (insertFood != null)
                {
                    insertFood(this, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm món !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Delete_Food_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbFoodID.Text);
            if (FoodDAO.Instance.DeleteFood(id))
            {
                MessageBox.Show("Xóa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadListFood();
                if (deleteFood != null)
                {
                    deleteFood(this, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Edit_Food_Click(object sender, EventArgs e)
        {
            string name = txbFoodName.Text;
            int categoryID = (cbFoodCategory.SelectedItem as Category).ID;
            float price = (float)nmFoodPrice.Value;
            int id = Convert.ToInt32(txbFoodID.Text);
            if (FoodDAO.Instance.UpdateFood(id, name, categoryID, price))
            {
                MessageBox.Show("Sửa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadListFood();
                if (updateFood != null)
                {
                    updateFood(this, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa món !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Show_Food_Click(object sender, EventArgs e)
        {
            LoadListFood();
        }

        //private void btnsearchfood_click(object sender, eventargs e)
        //{
        //    foodlist.datasource = searchfoodbyname(txbsearchfoodname.text);
        //}

        private void btnShowAcccount_Click(object sender, EventArgs e)
        {
            LoadAccount();
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string displayName = txbDisplayName.Text;
            int type = (int)nmType.Value;
            AddAccount(userName, displayName, type);
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            DeleteAccount(userName);
        }

        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string displayName = txbDisplayName.Text;
            int type = (int)nmType.Value;
            EditAccount(userName, displayName, type);
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            ResetPass(userName);
        }

        private void txbFoodID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dtgvFood.SelectedCells.Count > 0 && dtgvFood.SelectedCells[0].OwningRow.Cells["CategoryID"].Value != null)
                {
                    int id = (int)dtgvFood.SelectedCells[0].OwningRow.Cells["CategoryID"].Value;
                    Category cateogory = CategoryDAO.Instance.GetCategoryByID(id);
                    cbFoodCategory.SelectedItem = cateogory;
                    int index = -1;
                    int i = 0;
                    foreach (Category item in cbFoodCategory.Items)
                    {
                        if (item.ID == cateogory.ID)
                        {
                            index = i;
                            break;
                        }
                        i++;
                    }
                    cbFoodCategory.SelectedIndex = index;
                }
            }
            catch
            {

            }
        }
        #endregion
        #region event1
        private void btnAddFood_Click(object sender, EventArgs e)
        {
            string name = txbFoodName.Text;
            int categoryID = (cbFoodCategory.SelectedItem as Category).ID;
            float price = (float)nmFoodPrice.Value;
            if (FoodDAO.Instance.InsertFood(name, categoryID, price))
            {
                MessageBox.Show("Thêm món thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadListFood();
                if (insertFood != null)
                {
                    insertFood(this, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm món !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnEditFood_Click(object sender, EventArgs e)
        {
            string name = txbFoodName.Text;
            int categoryID = (cbFoodCategory.SelectedItem as Category).ID;
            float price = (float)nmFoodPrice.Value;
            int id = Convert.ToInt32(txbFoodID.Text);
            if (FoodDAO.Instance.UpdateFood(id, name, categoryID, price))
            {
                MessageBox.Show("Sửa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadListFood();
                if (updateFood != null)
                {
                    updateFood(this, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa món !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbFoodID.Text);
            if (FoodDAO.Instance.DeleteFood(id))
            {
                MessageBox.Show("Xóa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadListFood();
                if (deleteFood != null)
                {
                    deleteFood(this, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnShowFood_Click(object sender, EventArgs e)
        {
            LoadListFood();
        }
        #endregion

        //private void btnAddCategory_Click(object sender, EventArgs e)
        //{
        //    string name = txbNameFoodCategory.Text;
        //    AddFoodCategory(name);
        //    LoadCategory();
        //}

        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            string name = txbNameFoodCategory.Text;
            int id = Convert.ToInt32(txbCategoryID.Text);
            EditFoodCategory(name,id);
            LoadCategory();
        }
        private void btnShowCategory_Click(object sender, EventArgs e)
        {
            LoadCategory();
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbCategoryID.Text);
            DeleteFoodCategory(id);
            LoadCategory();
        }

        private void btnSearch_Food_Click(object sender, EventArgs e)
        {
            foodList.DataSource = SearchFoodByName(txbSearchFoodName.Text);
        }

        private void btnAdd_Category_Click(object sender, EventArgs e)
        {
            string name = txbNameFoodCategory.Text;
            AddFoodCategory(name);
            LoadCategory();
        }

        private void btnDelete_Category_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbCategoryID.Text);
            DeleteFoodCategory(id);
            LoadCategory();
        }

        private void btnEdit_Category_Click(object sender, EventArgs e)
        {
            string name = txbNameFoodCategory.Text;
            int id = Convert.ToInt32(txbCategoryID.Text);
            EditFoodCategory(name, id);
            LoadCategory();
        }

        private void txbNameFoodCategory_TextChanged(object sender, EventArgs e)
        {

        }

        private void rpViewer_Load(object sender, EventArgs e)
        {

        }

        private void dtgvAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Account_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string displayName = txbDisplayName.Text;
            int type = (int)nmType.Value;
            AddAccount(userName, displayName, type);
        }

        private void btnDelete_Account_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            DeleteAccount(userName);
        }

        private void btnEdit_Account_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string displayName = txbDisplayName.Text;
            int type = (int)nmType.Value;
            EditAccount(userName, displayName, type);
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            LoadAccount();
        }

        private void btnReset_PassWord_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            ResetPass(userName);
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
