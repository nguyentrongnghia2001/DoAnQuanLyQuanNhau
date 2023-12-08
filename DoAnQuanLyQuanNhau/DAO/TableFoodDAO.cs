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

        public static int TableWidth = 85;
        public static int TableHeight = 85;

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
    }
}
