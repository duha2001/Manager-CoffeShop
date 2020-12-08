using QuanLyCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QuanLyCafe.DAO
{
    public class CategoryDAO
    {
        private static CategoryDAO instance;

        public static CategoryDAO Instance 
        { 
            get { if (instance == null) instance = new CategoryDAO();return CategoryDAO.instance; }
            private set { CategoryDAO.instance = value; }
        }
        private CategoryDAO() { }
        public List<Category> GetListCategory()
        {
            List<Category> list = new List<Category>();
            string query = "SELECT * FROM dbo.FOODCATEGORY";
            DataTable data = DataProvider.Instance.ExcecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                Category category = new Category(item);
                list.Add(category);
            }
            return list;
        }
        public Category GetCategoryByID(int id)
        {
            Category category = null;
            string query = "SELECT * FROM dbo.FOODCATEGORY WHERE id = " + id;
            DataTable data = DataProvider.Instance.ExcecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                category = new Category(item);
                return category;
            }
            return category;
        }
        public bool InsertCategory( string name)
        {
            string query = string.Format("INSERT dbo.FOODCATEGORY (name) VALUES (N'{0}')",name);
            int result = DataProvider.Instance.ExcecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateCategory(string name,int id)
        {
            string query = string.Format("UPDATE dbo.FOODCATEGORY SET name = N'{0}' WHERE id={1}", name,id);
            int result = DataProvider.Instance.ExcecuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteCategory(int id)
        {
            FoodDAO.Instance.DeleteFoodByCategoryID(id);
            string query = string.Format("DELETE dbo.FOODCATEGORY WHERE id = {0}", id);
            int result = DataProvider.Instance.ExcecuteNonQuery(query);
            return result > 0;
        }
    }
}
