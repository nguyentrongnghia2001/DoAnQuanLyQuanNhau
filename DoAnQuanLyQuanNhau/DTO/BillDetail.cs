using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLyQuanNhau.DTO
{
    public class BillDetail
    {
        public BillDetail(int id, int id_bill, int id_food, int quantity, int status)
        {
            this.Id = id;
            this.Id_food = id_food;
            this.Id_bill = id_bill;
            this.Quantity = quantity;
            this.Status = status;
        }

        public BillDetail(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Id_food = (int)row["id_food"];
            this.Id_bill = (int)row["id_bill"];
            this.Quantity = (int)row["quantity"];
            this.Status = (int)row["status"];
        }

        private int id;
        private int id_bill;
        private int id_food;
        private int quantity;
        private int status;

        public int Id { get => id; set => id = value; }
        public int Id_bill { get => id_bill; set => id_bill = value; }
        public int Id_food { get => id_food; set => id_food = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int Status { get => status; set => status = value; }
    }
}
