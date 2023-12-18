using DoAnQuanLyQuanNhau.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DoAnQuanLyQuanNhau.DAO
{
    public class GetMenuDAO
    {
        private static GetMenuDAO instance;

        public static GetMenuDAO Instance
        {
            get { if (instance == null) instance = new GetMenuDAO(); return GetMenuDAO.instance; }
            private set { GetMenuDAO.instance = value; }
        }

        private GetMenuDAO() { }

        public List<GetMenu> GetListMenuByTable(int id)
        {
            List<GetMenu> list = new List<GetMenu>();

            string query = "SELECT f.name, bd.quantity, f.price, f.price*bd.quantity AS totalPrice FROM BillDetail AS bd, Bill AS b, Food AS f WHERE bd.id_bill = b.id AND bd.id_food = f.id AND b.is_pay = 1 AND b.id_table_food = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                GetMenu menu = new GetMenu(item);
                list.Add(menu);
            }

            return list;
        }
    }
}
