using QuanLyCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DAO
{
    public class BillInfoDAO
    {
        private static BillInfoDAO instance;
        private readonly Menuu info;

        public static BillInfoDAO Instance {
            get { if (instance == null) instance = new BillInfoDAO(); return BillInfoDAO.instance; }
            private set { BillInfoDAO.instance = value; }
        }
        public void DeleteBillInfoByFoodID(int id)
        {
            DataTable data = DataProvider.Instance.ExcecuteQuery("DELETE dbo.BILLINFO WHERE idFood = " + id);
        }
        private BillInfoDAO(){}
        public List<Menuu> GetListBillInfo(int id)
        {
            List<Menuu> listBillInfo = new List<Menuu>();
            DataTable data = DataProvider.Instance.ExcecuteQuery("SELECT * FROM dbo.BILLINFO WHERE idBill= " + id);
            foreach(DataRow item in data.Rows)
            {
                Menuu.info = new Menuu(item);
                listBillInfo.Add(info);
            }
            return listBillInfo;
        }
        public void InsertBillInfo(int idBill,int idFood,int count)
        {
            DataProvider.Instance.ExcecuteNonQuery("USP_InsertBillInfo @idBill , @idFood , @count ", new object[] { idBill, idFood, count });
            
        }
    }

}
