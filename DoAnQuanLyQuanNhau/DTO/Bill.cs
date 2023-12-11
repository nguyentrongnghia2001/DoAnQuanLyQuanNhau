using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLyQuanNhau.DTO
{
    public class Bill
    {
        public Bill(int id, int id_account, DateTime? data_check_in, DateTime? data_check_out, int is_pay, int status)
        {
            this.Id = id;
            this.Id_account = id_account;
            this.Data_check_in = data_check_in;
            this.Data_check_out = data_check_out;
            this.Is_pay = is_pay;
            this.Status = status;
        }

        public Bill(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Id_account = (int)row["id_account"];
            this.Data_check_in = (DateTime?)row["data_check_in"];
            var dateCheckOutTemp = row["data_check_out"];
            if (dateCheckOutTemp.ToString() != "")
                this.Data_check_out = (DateTime?)dateCheckOutTemp;

            this.Status = (int)row["status"];
            this.Is_pay = (int)row["is_pay"];
        }

        private int id;
        private int id_account;
        private DateTime? data_check_in;
        private DateTime? data_check_out;
        private int is_pay;
        private int status;

        public int Id { get => id; set => id = value; }
        public int Id_account { get => id_account; set => id_account = value; }
        public DateTime? Data_check_in { get => data_check_in; set => data_check_in = value; }
        public DateTime? Data_check_out { get => data_check_out; set => data_check_out = value; }
        public int Is_pay { get => is_pay; set => is_pay = value; }
        public int Status { get => status; set => status = value; }
    }
}
