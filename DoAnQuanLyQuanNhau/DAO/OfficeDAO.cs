using DoAnQuanLyQuanNhau.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLyQuanNhau.DAO
{
    public class OfficeDAO
    {
        private static OfficeDAO instance;

        public static OfficeDAO Instance
        {
            get { if (instance == null) instance = new OfficeDAO(); return OfficeDAO.instance; }
            private set { OfficeDAO.instance = value; }
        }

        private OfficeDAO() { }

        public List<Office> GetListOffice()
        {
            List<Office> list = new List<Office>();

            string query = "SELECT * FROM Office WHERE status = 1";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Office office = new Office(item);
                list.Add(office);
            }

            return list;
        }

        public bool InsertOffice(string name)
        {
            string query = string.Format("INSERT dbo.Office (name)VALUES  (N'{0}')", name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateOffice(string name, int id)
        {
            string query = string.Format("UPDATE dbo.Office SET name = N'{0}' WHERE id = {1}", name, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteOffice(int id)
        {
            string query = string.Format("UPDATE dbo.Office SET status = 0 where id = {0}", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public Office GetOfficeByID(int id)
        {
            Office office = null;

            string query = "SELECT * FROM dbo.Office where id = " + id + "and status = 1";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                office = new Office(item);
                return office;
            }

            return office;
        }
    }
}
