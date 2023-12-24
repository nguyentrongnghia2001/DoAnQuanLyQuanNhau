using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLyQuanNhau.DTO
{
    public class Office
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Office(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public Office(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Name = row["name"].ToString();
        }
    }
}
