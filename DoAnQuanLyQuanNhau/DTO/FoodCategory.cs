using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLyQuanNhau.DTO
{
    public class FoodCategory
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public FoodCategory(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }

        public FoodCategory(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = row["name"].ToString();
        }

    }
}
