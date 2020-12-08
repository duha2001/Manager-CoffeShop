﻿using QuanLyCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DAO
{
    class MenuDAO
    {
        private static MenuDAO instance;

        internal static MenuDAO Instance {
            get { if (instance == null) instance = new MenuDAO();return MenuDAO.instance; }
            private set { MenuDAO.instance = value; }
        }
        private MenuDAO() { }
        public List<Menu> GetListMenuByTable(int id)
        {
            List<Menu> listMenu = new List<Menu>();
            string query = "SELECT f.name, bi.count, f.price, f.price*bi.count AS totalPrice FROM dbo.BILLINFO AS bi,dbo.BILL AS b, dbo.FOOD AS f WHERE bi.idBill=b.id AND b.status=0 AND bi.idFood=f.id AND b.idTable= " + id;
            DataTable data = DataProvider.Instance.ExcecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                Menu menu = new Menu(item);
                listMenu.Add(menu);

            }
            return listMenu;
        }
    }
}
