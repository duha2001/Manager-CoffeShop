using QuanLyCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCafe.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance 
        {
            get { if(instance==null)instance=new AccountDAO();return instance; }
            private set { instance = value; }
        }
        private AccountDAO() { }
        public bool Login(string UserName,string PassWord)
        {
            string query = "SELECT * FROM dbo.ACCOUNT WHERE UserName= N'"+UserName+ "'AND PassWord= N'"+PassWord+"'";
            DataTable result = DataProvider.Instance.ExcecuteQuery(query);
            return result.Rows.Count>0;
        }
        public DataTable GetListAccount()
        {
            return DataProvider.Instance.ExcecuteQuery("SELECT UserName, DisplayName, TYPE FROM dbo.ACCOUNT");
        }
        public bool UpdateAccount(string userName, string displayName, string pass, string newPass)
        {
            int result = DataProvider.Instance.ExcecuteNonQuery("exec USP_UpdateAccount @userName , @displayName , @password , @NewPassword", new object[] { userName, displayName, pass, newPass });
            return result > 0;
        }
        public Account GetAccountByUserName(string userName)
        {
            DataTable data = DataProvider.Instance.ExcecuteQuery("SELECT * FROM dbo.ACCOUNT WHERE UserName = '" + userName+"'");
            foreach(DataRow item in data.Rows )
            {
                return new Account(item);
            }
            return null;
        }
        public bool InsertAccount(string name, string displayName, int type)
        {
            string query = string.Format("INSERT dbo.ACCOUNT (UserName,DisplayName,type) VALUES (N'{0}',N'{1}',{2})", name, displayName,type);
            int result = DataProvider.Instance.ExcecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateAccount( string name, string displayName, int type)
        {
            string query = string.Format("UPDATE dbo.ACCOUNT SET DisplayName = N'{1}' , type = {2} WHERE UserName = N'{0}' ", name, displayName, type);
            int result = DataProvider.Instance.ExcecuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteAccount(string name)
        {
            string query = string.Format("DELETE dbo.ACCOUNT WHERE UserName = N'{0}'", name);
            int result = DataProvider.Instance.ExcecuteNonQuery(query);
            return result > 0;
        }
        public bool ResetPassword(string name)
        {
            string query = string.Format("UPDATE dbo.ACCOUNT SET PassWord= N'123' WHERE UserName = N'{0}' ", name);
            int result = DataProvider.Instance.ExcecuteNonQuery(query);
            return result > 0;
        }
    }

}
