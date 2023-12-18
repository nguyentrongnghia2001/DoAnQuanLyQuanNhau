using DoAnQuanLyQuanNhau.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLyQuanNhau.DAO
{
    public class TableFoodDAO
    {
        private static TableFoodDAO instance;

        public static TableFoodDAO Instance
        {
            get { if (instance == null) instance = new TableFoodDAO(); return TableFoodDAO.instance; }
            private set { TableFoodDAO.instance = value; }
        }

        public static int TableWidth = 100;
        public static int TableHeight = 100;

        private TableFoodDAO() { }

        public List<TableFood> GetListTableFood()
        {
            List<TableFood> list = new List<TableFood>();

            string query = "SELECT * FROM TableFood WHERE status = 1";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                TableFood tablefood = new TableFood(item);
                list.Add(tablefood);
            }

            return list;
        }

        public List<TableFood> GetListEmptyTableFood()
        {
            List<TableFood> list = new List<TableFood>();

            string query = "SELECT * FROM TableFood WHERE status = 1 AND is_empty = 1";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                TableFood tablefood = new TableFood(item);
                list.Add(tablefood);
            }

            return list;
        }

        public List<TableFood> GetListUnEmptyTableFood()
        {
            List<TableFood> list = new List<TableFood>();

            string query = "SELECT * FROM TableFood WHERE status = 1 AND is_empty = 0";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                TableFood tablefood = new TableFood(item);
                list.Add(tablefood);
            }

            return list;
        }


        public bool UpdateUnEmptyTableFood(int id)
        {
            string query = string.Format("UPDATE TableFood SET is_empty = 0 WHERE id = {0}", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool UpdateEmptyTableFood(int id)
        {
            string query = string.Format("UPDATE TableFood SET is_empty = 1 WHERE id = {0}", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
