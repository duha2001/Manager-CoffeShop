using QuanLyCafe.DAO;
using QuanLyCafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCafe
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }
        public  void bntlogin_Click(object sender, EventArgs e)
        {
            string UserName = txbUserName.Text;
            string PassWord = txtPassWord.Text;
            if (Login(UserName, PassWord))
            {
                Account loginAccount = AccountDAO.Instance.GetAccountByUserName(UserName);
                fTableManager f = new fTableManager(loginAccount);
                // Nếu f.show thì form thứ 2 k bị ẩn 
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        bool Login(string UserName,string PassWord)
        {
            return AccountDAO.Instance.Login(UserName, PassWord);
        }
        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel,MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void fLogin_Load(object sender, EventArgs e)
        {

        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {

        }

        private void labelItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
