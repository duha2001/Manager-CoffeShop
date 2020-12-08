using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;
        public static DataProvider Instance 
        {
            get { if (instance == null) instance = new DataProvider();  return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }
        private DataProvider() { }
        private string connectionSTR = @"Data Source=DESKTOP-LGFNL1T;Initial Catalog=QuanLyQuanCafe2;Integrated Security=True";


        public DataTable ExcecuteQuery(string query,object[] parameter=null)
        {
            DataTable data = new DataTable();
            //dùng using để giải phóng bộ nhớ bằng cách sử dụng using 
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            { 
            //mở connection
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);//câu truy vấn để thực thi 
                if (parameter != null)
                {
                    int i = 0;
                    string[] listpara = query.Split(' ');
                    foreach(string item in listpara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                      
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);//trung gian để thực hiện câu truy vấn để lấy dữ liệu
                adapter.Fill(data); 
                connection.Close();
            }
            return data;
        }
        public int ExcecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection); 
                if (parameter != null)
                {
                    int i = 0;
                    string[] listpara = query.Split(' ');
                    foreach (string item in listpara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }

                    }
                }
                data = command.ExecuteNonQuery();
                connection.Close();
            }
            return data;
        }
        public object ExcecuteSalar(string query, object[] parameter = null)
        {
            object data = 0;
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (parameter != null)
                {
                    int i = 0;
                    string[] listpara = query.Split(' ');
                    foreach (string item in parameter)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }

                    }
                }
                data = command.ExecuteScalar();
                connection.Close();
            }
            return data;
        }

    }
}
