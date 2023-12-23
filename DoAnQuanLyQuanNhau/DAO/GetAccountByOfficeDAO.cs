using DoAnQuanLyQuanNhau.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLyQuanNhau.DAO
{
    public class GetAccountByOfficeDAO
    {
        private static GetAccountByOfficeDAO instance;

        public static GetAccountByOfficeDAO Instance
        {
            get { if (instance == null) instance = new GetAccountByOfficeDAO(); return GetAccountByOfficeDAO.instance; }
            private set { GetAccountByOfficeDAO.instance = value; }
        }

        private GetAccountByOfficeDAO() { }

        public List<GetAccountByOffice> GetListAccountByOffice()
        {
            List<GetAccountByOffice> list = new List<GetAccountByOffice>();

            string query = "SELECT o.name AS name_office, o.id AS id_office, a.* FROM Account AS a JOIN Office AS o ON a.id_office = o.id WHERE a.status = 1";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                GetAccountByOffice getAcc = new GetAccountByOffice(item);
                list.Add(getAcc);
            }

            return list;
        }
    }
}
