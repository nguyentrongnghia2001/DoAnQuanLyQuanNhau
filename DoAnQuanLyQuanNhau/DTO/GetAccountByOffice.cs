using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLyQuanNhau.DTO
{
    public class GetAccountByOffice
    {
        public GetAccountByOffice(int id, int id_office, string name_office, string username, string fullname, string address, string phone, int type)
        {
            this.Id = id;
            this.Id_office = id_office;
            this.Name_office = name_office;
            this.Username = username;
            this.Fullname = fullname;
            this.Address = address;
            this.Phone = phone;
            this.Type = type;
        }

        public GetAccountByOffice(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Id_office = (int)row["id_office"];
            this.Name_office = row["name_office"].ToString();
            this.Username = row["username"].ToString();
            this.Fullname = row["fullname"].ToString();
            this.Address = row["address"].ToString();
            this.Phone = row["phone"].ToString();
            this.Type = (int)row["type"];
        }

        private int id;
        private int id_office;
        private string name_office;
        private string username;
        private string fullname;
        private string address;
        private string phone;
        private int type;

        public int Id { get => id; set => id = value; }
        public string Name_office { get => name_office; set => name_office = value; }
        public string Username { get => username; set => username = value; }
        public string Address { get => address; set => address = value; }
        public string Phone { get => phone; set => phone = value; }
        public int Type { get => type; set => type = value; }
        public string Fullname { get => fullname; set => fullname = value; }
        public int Id_office { get => id_office; set => id_office = value; }
    }
}
