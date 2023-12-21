using DoAnQuanLyQuanNhau.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLyQuanNhau.DAO
{
    public class FoodCategoryDAO
    {
        private static FoodCategoryDAO instance;

        public static FoodCategoryDAO Instance
        {
            get { if (instance == null) instance = new FoodCategoryDAO(); return FoodCategoryDAO.instance; }
            private set { FoodCategoryDAO.instance = value; }
        }

        private FoodCategoryDAO() { }

        public List<FoodCategory> GetListFoodCategory()
        {
            List<FoodCategory> list = new List<FoodCategory>();

            string query = "SELECT * FROM FoodCategory WHERE status = 1";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                FoodCategory categoryfood = new FoodCategory(item);
                list.Add(categoryfood);
            }

            return list;
        }

        public bool InsertFoodCategory(string name)
        {
            string query = string.Format("INSERT dbo.FoodCategory (name)VALUES  (N'{0}')", name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateFoodCategory(string name, int id)
        {
            string query = string.Format("UPDATE dbo.FoodCategory SET name = N'{0}' WHERE id = {1}", name, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteFoodCategory(int id)
        {
            string query = string.Format("UPDATE dbo.FoodCategory SET status = 0 where id = {0}", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public FoodCategory GetCategoryByID(int id)
        {
            FoodCategory category = null;

            string query = "SELECT * FROM dbo.FoodCategory where id = " + id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                category = new FoodCategory(item);
                return category;
            }

            return category;
        }

    }
}
