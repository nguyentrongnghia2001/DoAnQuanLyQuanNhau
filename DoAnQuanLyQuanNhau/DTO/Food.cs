using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLyQuanNhau.DTO
{
    public class Food
    {
        public Food(int id, int id_category, string name, float price, int status)
        {
            this.Id = id;
            this.Id_category = id_category;
            this.Name = name;
            this.Price = price;
            this.Status = status;
        }

        public Food(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Id_category = (int)row["id_category"];
            this.Name = row["name"].ToString();
            this.Price = (float)Convert.ToDouble(row["price"].ToString());
            this.Status = (int)row["status"];
        }

        private int id;
        private int id_category;
        private string name;
        private float price;
        private int status;

        public int Id { get => id; set => id = value; }
        public int Id_category { get => id_category; set => id_category = value; }
        public string Name { get => name; set => name = value; }
        public float Price { get => price; set => price = value; }
        public int Status { get => status; set => status = value; }
    }
}
