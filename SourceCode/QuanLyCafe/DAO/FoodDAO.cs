﻿using QuanLyCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace QuanLyCafe.DAO
{
    public class FoodDAO
    {
         private static FoodDAO instance;

         public static FoodDAO Instance
         {
             get { if (instance == null) instance = new FoodDAO(); return FoodDAO.instance; }
             private set { FoodDAO.instance = value; }
         }
         private FoodDAO() { }
         public List<Food>GetFoodByCategoryID(int id)
         {
            List<Food> list = new List<Food>();
            string query = "SELECT * FROM FOOD WHERE idCategory = " + id ;
            DataTable data = DataProvider.Instance.ExcecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                 Food food = new Food(item);
                 list.Add(food);
            }
            return list;
         }
        public List<Food> GetListFood()
        {
            List<Food> list = new List<Food>();
            string query = "SELECT * FROM FOOD";
            DataTable data = DataProvider.Instance.ExcecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }
            return list;
        }
        public bool InsertFood(string name,int id,float price)
        {
            string query =string.Format("INSERT dbo.FOOD (name,idCategory,price) VALUES (N'{0}',{1},{2})",name,id,price);
            int result = DataProvider.Instance.ExcecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateFood(int idFood,string name, int id, float price)
        {
            string query = string.Format("UPDATE dbo.FOOD SET name = N'{0}', idCategory={1} , price={2} WHERE id={3}", name, id, price,idFood);
            int result = DataProvider.Instance.ExcecuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteFood(int idFood)
        {
            BillInfoDAO.Instance.DeleteBillInfoByFoodID(idFood);
            string query = string.Format("DELETE dbo.FOOD WHERE id={0}", idFood);
            int result = DataProvider.Instance.ExcecuteNonQuery(query);
            return result > 0;
        }
        public List<Food> SearchFoodByName(string name)
        {
            List<Food> list = new List<Food>();
            string query = string.Format("SELECT * FROM dbo.FOOD WHERE dbo.GetUnsignString(name) LIKE N'%'+dbo.GetUnsignString(N'{0}')+'%'",name);
            DataTable data = DataProvider.Instance.ExcecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }
            return list;
        }
        public void DeleteFoodByCategoryID(int id)
        {
            DataProvider.Instance.ExcecuteQuery("DELETE dbo.FOOD WHERE idCategory = " + id);
        }

    }
}
