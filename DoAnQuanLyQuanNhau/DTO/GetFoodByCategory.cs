using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLyQuanNhau.DTO
{
    public class GetFoodByCategory
    {
        public GetFoodByCategory(int id, int idCategory, string name, string foodCategoryName, float price)
        {
            this.Id = id;
            this.Id_category = idCategory;
            this.FoodCategoryName = foodCategoryName;
            this.Name = name;
            this.Price = price;;
        }

        public GetFoodByCategory(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Id_category = (int)row["id_category"];
            this.FoodCategoryName = row["name_category"].ToString();
            this.Name = row["name"].ToString();
            this.Price = (float)Convert.ToDouble(row["price"].ToString());
        }

        private int id;
        private int id_category;
        private string name;
        private string foodCategoryName;
        private float price;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string FoodCategoryName { get => foodCategoryName; set => foodCategoryName = value; }
        public float Price { get => price; set => price = value; }
        public int Id_category { get => id_category; set => id_category = value; }
    }
}
