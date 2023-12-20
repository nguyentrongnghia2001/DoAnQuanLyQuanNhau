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
        public GetFoodByCategory(int id, string name, string foodCategoryName, float price)
        {
            this.Id = id;
            this.FoodCategoryName = foodCategoryName;
            this.Name = name;
            this.Price = price;;
        }

        public GetFoodByCategory(DataRow row)
        {
            this.Id = (int)row["id"];
            this.FoodCategoryName = row["name_category"].ToString();
            this.Name = row["name"].ToString();
            this.Price = (float)Convert.ToDouble(row["price"].ToString());
        }

        private int id;
        private string name;
        private string foodCategoryName;
        private float price;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string FoodCategoryName { get => foodCategoryName; set => foodCategoryName = value; }
        public float Price { get => price; set => price = value; }
    }
}
