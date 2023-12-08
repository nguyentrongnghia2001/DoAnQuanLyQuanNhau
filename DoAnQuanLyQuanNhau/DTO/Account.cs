using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLyQuanNhau.DTO
{
    public class Account
    {
        public Account(int id, int idOffice, string username, string fullName, string phone, string address, int type, string password = null)
        {
            this.Id = id;
            this.idOffice = idOffice;
            this.Username = username;
            this.Password = password;
            this.FullName = fullName;
            this.Address = address;
            this.Phone = phone;
            this.Type = type;
   
        }

        public Account(DataRow row)
        {
            this.Id = (int)row["id"];
            this.idOffice = (int)row["id_office"];
            this.Username = row["username"].ToString();
            this.FullName = row["fullname"].ToString();
            this.Address = row["address"].ToString();
            this.Phone = row["phone"].ToString();
            this.Type = (int)row["type"];
            this.Password = row["password"].ToString();
        }

        private int id;
        private int idOffice;
        private string username;
        private string password;
        private string fullName;
        private string address;
        private string phone;
        private int type;

        public int IdOffice { get => idOffice; set => idOffice = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public string Address { get => address; set => address = value; }
        public string Phone { get => phone; set => phone = value; }
        public int Type { get => type; set => type = value; }
        public int Id { get => id; set => id = value; }
    }
}
