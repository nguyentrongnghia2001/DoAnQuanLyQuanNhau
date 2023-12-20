using DoAnQuanLyQuanNhau.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLyQuanNhau.DAO
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

        public List<Food> getFoodByIdCategory(int id)
        {
            List<Food> listFood = new List<Food>();
            string query = "SELECT * FROM Food WHERE status = 1 AND id_category = " + id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                listFood.Add(food);
            }

            return listFood;
        }

        public List<Food> GetListFood()
        {
            List<Food> list = new List<Food>();

            //string query = "SELECT f.id, fc.name AS name_category, f.name ,  f.price FROM Food AS f JOIN FoodCategory AS fc ON f.id_category = fc.id WHERE f.status = 1";
            string query = "SELECT * FROM Food WHERE status = 1";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Food f = new Food(item);
                list.Add(f);
            }

            return list;
        }

        public bool InsertFood(string name, int idCategory, float price)
        {
            string query = string.Format("INSERT Food (name, id_category, price) VALUES (N'{0}', {1}, {2})", name, idCategory, price);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateFood(string name, int idFood, int idCategory, float price)
        {
            string query = string.Format("UPDATE Food SET name = N'{0}', id_category = {1}, price = {2} WHERE id = {3}", name, idCategory, price, idFood);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteFood(int id)
        {
            string query = string.Format("UPDATE dbo.Food SET status = 0 where id = {0}", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
