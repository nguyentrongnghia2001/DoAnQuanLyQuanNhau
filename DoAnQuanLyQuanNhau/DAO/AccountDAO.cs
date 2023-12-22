﻿using DoAnQuanLyQuanNhau.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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

        public bool Login(string username, string password)
        {
            //byte[] temp = ASCIIEncoding.ASCII.GetBytes(passWord);
            //byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);

            //string hasPass = "";

            //foreach (byte item in hasData)
            //{
                //hasPass += item;
            //}
            //var list = hasData.ToString();
            //list.Reverse();

            string query = "USP_Login @username , @password";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { username, password });

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

    }
}
