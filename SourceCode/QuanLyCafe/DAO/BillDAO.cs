using DevComponents.DotNetBar;
using QuanLyCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COMExcel = Microsoft.Office.Interop.Excel;

namespace QuanLyCafe.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance {
            get { if (instance == null) instance = new BillDAO(); return BillDAO.instance; }
            private set { BillDAO.instance = value; }
        }
        private BillDAO()
        {

        }
        // thanh cong: bill ID
        //That bai: -1
        public int GetUncheckBillIDByTableID(int id)
        {
            DataTable data = DataProvider.Instance.ExcecuteQuery("SELECT * FROM dbo.BILL WHERE idTable= "+id+" AND status =0");
            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID;
            }
            return -1; // nghia la tra ve id =-1;
        }
        public void CheckOut(int id,int discount, float totalPrice)
        {
            string query = "UPDATE dbo.BILL SET dateCheckOut = GETDATE(),status = 1, "+"discount = "+discount+ ", totalPrice = "+ totalPrice +" WHERE id = "+id;
            DataProvider.Instance.ExcecuteNonQuery(query);
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook; 
            COMExcel.Worksheet exSheet; 
            COMExcel.Range exRange;
            string sql;
            int hang = 0, cot = 0;
            DataTable Thongtin;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            exRange = exSheet.Cells[1, 1];
            exRange.Range["A1:Z300"].Font.Name = "Times new roman"; 
            exRange.Range["A1:B3"].Font.Size = 10;
            exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.ColorIndex = 5; 
            exRange.Range["A1:A1"].ColumnWidth = 7;
            exRange.Range["B1:B1"].ColumnWidth = 15;
            exRange.Range["A1:B1"].MergeCells = true;
            exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:B1"].Value = "Quản Lý Quán Cafe";
            exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:B2"].Value = "Trường Đại Học Sư Phạm TPHCM";
            exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:B3"].Value = "Điện thoại: 0366610949";
            exRange.Range["C2:E2"].Font.Size = 16;
            exRange.Range["C2:E2"].Font.Bold = true;
            exRange.Range["C2:E2"].Font.ColorIndex = 3; 
            exRange.Range["C2:E2"].MergeCells = true;
            exRange.Range["C2:E2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["c2:E2"].Value = "HÓA ĐƠN";
            sql = "SELECT * FROM dbo.BILL WHERE id = " + id + " AND discount= " + discount + "AND totalPrice = " + totalPrice;
            Thongtin = DataProvider.Instance.ExcecuteQuery(sql);
            exRange.Range["A6:H6"].Font.Bold = true;
            exRange.Range["A6:H6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C6:H6"].ColumnWidth = 12;
            exRange.Range["A6:A6"].Value = "STT";
            exRange.Range["B6:B6"].Value = "Số Lượng Bill";
            exRange.Range["C6:C6"].Value = "Ngày Vào";
            exRange.Range["D6:D6"].Value = "Ngày Ra";
            exRange.Range["E6:E6"].Value = "Số Bàn";
            exRange.Range["F6:F6"].Value = "ID của Bàn";
            exRange.Range["G6:G6"].Value = "Giảm giá";
            exRange.Range["H6:H6"].Value = "Tổng tiền";
            for (hang = 0; hang < Thongtin.Rows.Count; hang++)
            {
                exSheet.Cells[1][hang + 7] = hang + 1;
                for (cot = 0; cot < Thongtin.Columns.Count; cot++)
                {
                    exSheet.Cells[cot + 2][hang + 7] = Thongtin.Rows[hang][cot];
                    if (cot == 3) exSheet.Cells[cot + 2][hang + 7] = Thongtin.Rows[hang][cot];
                }
            }
            exApp.Visible = true;

        }
        public DataTable GetBillListByDate(DateTime checkIn,DateTime checkOut)
        {
           return DataProvider.Instance.ExcecuteQuery("EXEC USP_GetListBillByDate @checkIn , @checkOut", new object[] { checkIn, checkOut });
        }
        public void InsertBill(int id)
        {
            DataProvider.Instance.ExcecuteNonQuery("exec USP_InsertBill @idTable", new object[] { id });
        }
        public int GetMaxIDBill()
        {
            try { 
                return (int)DataProvider.Instance.ExcecuteSalar("SELECT MAX(id) FROM dbo.BILL");
            }
            catch
            {
                return 1;
            }
        }
    }
}
