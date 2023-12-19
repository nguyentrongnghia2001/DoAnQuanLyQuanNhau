using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLyQuanNhau.DTO
{
    public class TableFood
    {
        public TableFood(int id, string name, string position, int is_empty)
        {
            this.Id = id;
            this.Name = name;
            this.Position = position;
            this.Is_empty = is_empty;
        }

        public TableFood(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Name = row["name"].ToString();
            this.Position = row["position"].ToString();
            this.Is_empty = (int)row["is_empty"];
        }

        private int id;
        private string name;
        private string position;
        private int is_empty;

        public int Id { get => id; set => id = value; }
        public string Position { get => position; set => position = value; }
        public int Is_empty { get => is_empty; set => is_empty = value; }
        public string Name { get => name; set => name = value; }
        public string Display_cbb => $"{Name} - {Position}";
    }
}
