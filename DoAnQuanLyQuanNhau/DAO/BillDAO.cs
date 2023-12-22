using DoAnQuanLyQuanNhau.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLyQuanNhau.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;
        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return BillDAO.instance; }
            private set { BillDAO.instance = value; }
        }

        private BillDAO() { }

        /// <summary>
        /// Thành công: bill ID
        /// thất bại: -1
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int GetUncheckBillIDByTableID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Bill WHERE id_table_food = " + id + " AND is_pay = 1");

            if (data.Rows.Count > 0)
            {
                 Bill bill = new Bill(data.Rows[0]);
                 return bill.Id;
            }
            return -1;
        }
        public void AddBill(int id,int idAccount)
        {
            DataProvider.Instance.ExecuteNonQuery("exec USP_AddBill @idTableFood , @idAccount", new object[] {id, idAccount});
        }

        public DataTable GetBillListByDate(DateTime dayCheckIn, DateTime dayCheckOut, int idAccount)
        {
            return DataProvider.Instance.ExecuteQuery("exec USP_GetListBillByDate @checkIn , @checkOut , @idAccount", new object[] { dayCheckIn, dayCheckOut, idAccount });
        }

        public DataTable GetBillListByDateStore(DateTime dayCheckIn, DateTime dayCheckOut)
        {
            return DataProvider.Instance.ExecuteQuery("exec USP_GetListBillByDateStore @checkIn , @checkOut", new object[] { dayCheckIn, dayCheckOut });
        }

        public int GetMaxIDBill()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("SELECT MAX(id) FROM Bill");
            }
            catch
            {
                return 1;
            }
        }
        public void CheckOutBill(int id,float totalPrice)
        {
            string query = "UPDATE Bill SET is_pay = 0 , data_check_out = GETDATE(), total_price = " + totalPrice + "WHERE id = " + id;
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public void UpdateIdTableSwap(int idTableFood, int idBill)
        {
            string query = "UPDATE Bill SET id_table_food = " + idTableFood + "WHERE id = " + idBill;
            DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
