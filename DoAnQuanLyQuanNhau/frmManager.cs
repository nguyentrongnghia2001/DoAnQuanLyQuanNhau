using DoAnQuanLyQuanNhau.DAO;
using DoAnQuanLyQuanNhau.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnQuanLyQuanNhau
{
    public partial class frmManager : Form
    {
        public frmManager()
        {
            InitializeComponent();
            LoadTableFood();
        }

        #region Method
        void LoadTableFood()
        {
            flpTableFood.Controls.Clear();

            List<TableFood> tableList = TableFoodDAO.Instance.GetListTableFood();

            foreach (TableFood item in tableList)
            {
                Button btn = new Button() { Width = TableFoodDAO.TableWidth, Height = TableFoodDAO.TableHeight };
                btn.Text = item.Name + " - " + item.Position + Environment.NewLine + (item.Is_empty == 1 ? "Trống" : "Có Khách");
                btn.Click += btn_Click;
                btn.Tag = item;
                switch (item.Is_empty)
                {
                    case 1:
                        btn.BackColor = Color.Aqua;
                        break;
                    default:
                        btn.BackColor = Color.Orange;
                        break;
                }

                flpTableFood.Controls.Add(btn);
            }
        }

        void showBill(int id)
        {
            lsvBill.Items.Clear();
            //List<BillDetail> listBillDetal = BillDetailDAO.Instance.GetListBillDetail(BillDAO.Instance.GetUncheckBillIDByTableID(id));
            CultureInfo culture = new CultureInfo("vi-VN");
            List<GetMenu> listBillDetal = GetMenuDAO.Instance.GetListMenuByTable(id);
            float totalPrice = 0;
            foreach (GetMenu item in listBillDetal)
            {
                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
                lsvItem.SubItems.Add(item.Quantity.ToString());
                lsvItem.SubItems.Add(item.Price.ToString("c", culture));
                lsvItem.SubItems.Add(item.TotalPrice.ToString("c", culture));
                totalPrice += item.TotalPrice;

                lsvBill.Items.Add(lsvItem);
            }
            txbTotalPrice.Text = totalPrice.ToString("c", culture);
        }

        #endregion


        #region Events
        private void btn_Click(object sender, EventArgs e)
        {
            int tableId = ((sender as Button).Tag as TableFood).Id;
            showBill(tableId);
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdmin f = new frmAdmin();
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void lsvOrder_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void thôngTinTàiKhoảnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAccountProfile f = new frmAccountProfile();
            f.ShowDialog();
            this.Show();
        }

        private void frmManager_Load(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
