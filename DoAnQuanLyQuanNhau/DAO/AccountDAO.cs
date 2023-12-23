using DoAnQuanLyQuanNhau.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLyQuanNhau.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;
        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return AccountDAO.instance; }
            private set { AccountDAO.instance = value; }
        }

        private AccountDAO() { }

        public List<Account> GetListAccount()
        {
            List<Account> list = new List<Account>();

            string query = "SELECT * FROM Account WHERE status = 1";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Account account = new Account(item);
                list.Add(account);
            }

            return list;
        }

        public string GetMD5Hash(string input)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(input);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);

            string hasPass = "";

            foreach (byte item in hasData)
            {
                hasPass += item;
            }

            return hasPass;
        }


        public bool Login(string username, string password)
        {
            string hasPass = GetMD5Hash(password);

            string query = "USP_Login @username , @password";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { username, hasPass });

            return result.Rows.Count > 0;
        }

        public Account GetAccountByUserName(string username)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Account WHERE username = '" + username + "'");

            foreach (DataRow item in data.Rows)
            {
                return new Account(item);
            }

            return null;
        }

        public bool UpdateAccount( string fullname, string address, string phone, string username, string pass, string newPass)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("exec USP_UpdateAccount @fullName , @address , @phone , @username , @password , @newPassword", new object[] { fullname, address, phone, username, pass, newPass });

            return result > 0;
        }

        public int GetMaxIdAccount()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("SELECT MAX(id) FROM Account");
            }
            catch
            {
                return 1;
            }
        }

        public bool InsertAccount(string username, string fullname, string password, int idOffice)
        {
            string query = string.Format("INSERT Account ( username, fullname, password, id_office ) VALUES ( N'{0}', N'{1}', N'{2}', {3} )", username, fullname, password, idOffice);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteAccount(int id)
        {
            string query = string.Format("UPDATE dbo.Account SET status = 0 where id = {0}", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
