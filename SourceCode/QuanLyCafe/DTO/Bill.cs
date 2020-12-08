using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace QuanLyCafe.DTO
{
    public class Bill
    {
        private DateTime? datecheckIn;
        private int iD;
        private DateTime? datecheckOut;
        private int status;
        private int discount;
        public Bill(int id,DateTime? dateCheckin,DateTime? dateCheckOut,int status,int discount=0)
        {
            this.ID = id;
            this.DatecheckIn = dateCheckin;
            this.DatecheckOut = dateCheckOut;
            this.Status = status;
            this.Discount = discount;
        }
        public Bill(DataRow row)
        {
            this.ID = (int)row["id"];
            this.DatecheckIn = (DateTime?)row["dateCheckin"];
            var dateCheckOutTemp = row["dateCheckOut"];
            if (dateCheckOutTemp.ToString() != "")
                this.DatecheckOut = (DateTime?)dateCheckOutTemp;
            this.Status = (int)row["status"];
            if(row["discount"].ToString()!="")
            this.Discount = (int)row["discount"];
        }
        public int ID { get => iD; set => iD = value; }
        public DateTime? DatecheckIn { get => datecheckIn; set => datecheckIn = value; }
        public DateTime? DatecheckOut { get => datecheckOut; set => datecheckOut = value; }
        public int Status { get => status; set => status = value; }
        public int Discount { get => discount; set => discount = value; }
    }
}
