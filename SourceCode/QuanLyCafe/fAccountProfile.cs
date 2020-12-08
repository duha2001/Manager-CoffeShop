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
    public partial class fAccountProfile : Form
    {
        private Account loginAccount;
        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount); }

        }
        void ChangeAccount(Account acc)
        {
            txbUserName.Text = LoginAccount.UserName;
            txtDisplayName.Text = LoginAccount.DisplayName;
        }
        void UpdateAccountInfo()
        {
            string userName = txbUserName.Text;
            string displayName = txtDisplayName.Text;
            string password = txtPassWord.Text;
            string newpass = textBox1.Text;
            string reenterPass = txtReenterPassWord.Text;
            if (!newpass.Equals(reenterPass))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu đúng với mật khẩu mới !","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                if (AccountDAO.Instance.UpdateAccount(userName, displayName, password, newpass))
                {
                    MessageBox.Show("Cập nhập thành công !","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    if(updateAcccount!=null)
                        updateAcccount(this, new AccountEvent(AccountDAO.Instance.GetAccountByUserName(userName)));
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đúng mật khẩu !","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }
        private event EventHandler<AccountEvent> updateAcccount;
        public event EventHandler<AccountEvent> UpdateAccount
        {
            add { updateAcccount += value; }
            remove { updateAcccount -= value; }
        }
        public fAccountProfile(Account acc)
        {
            InitializeComponent();
            LoginAccount = acc;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateAccountInfo();
        }
        public class AccountEvent : EventArgs
        {
            private Account acc;

            public Account Acc { get => acc; set => acc = value; }
            public AccountEvent(Account acc)
            {
                this.Acc = acc;
            }
        }

        private void fAccountProfile_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdateAcc_Click(object sender, EventArgs e)
        {
            UpdateAccountInfo();
        }

        private void btnExitAcc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
