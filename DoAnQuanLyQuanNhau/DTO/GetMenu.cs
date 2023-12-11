using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLyQuanNhau.DTO
{
    public class GetMenu
    {
        public GetMenu(string foodName, int count, float price, float totalPrice = 0)
        {
            this.FoodName = foodName;
            this.Quantity = count;
            this.Price = price;
            this.TotalPrice = totalPrice;
        }

        public GetMenu(DataRow row)
        {
            this.FoodName = row["name"].ToString();
            this.Quantity = (int)row["quantity"];
            this.Price = (float)Convert.ToDouble(row["price"].ToString());
            this.TotalPrice = (float)Convert.ToDouble(row["totalPrice"].ToString());
        }

        private float totalPrice;
        private float price;
        private int quantity;
        private string foodName;

        public float TotalPrice { get => totalPrice; set => totalPrice = value; }
        public float Price { get => price; set => price = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public string FoodName { get => foodName; set => foodName = value; }
    }
}
