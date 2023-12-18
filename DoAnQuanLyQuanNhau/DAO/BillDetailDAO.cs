using DoAnQuanLyQuanNhau.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLyQuanNhau.DAO
{
    public class BillDetailDAO
    {
        private static BillDetailDAO instance;
        public static BillDetailDAO Instance
        {
            get { if (instance == null) instance = new BillDetailDAO(); return BillDetailDAO.instance; }
            private set { BillDetailDAO.instance = value; }
        }

        private BillDetailDAO() { }

        public List<BillDetail> GetListBillDetail(int id)
        {
            List<BillDetail> list = new List<BillDetail>();

            string query = "SELECT * FROM BillDetail WHERE id_bill =" + id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                BillDetail billDetail = new BillDetail(item);
                list.Add(billDetail);
            }

            return list;
        }

        public void AddBillDetail(int idBill, int idFood, int quantity)
        {
            DataProvider.Instance.ExecuteNonQuery("exec USP_AddBillDetail @idBill , @idFood , @quantity", new object[] { idBill, idFood, quantity });
        }
    }
}
