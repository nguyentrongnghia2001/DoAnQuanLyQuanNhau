﻿using DoAnQuanLyQuanNhau.DAO;
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
            LoadFoodCategory();
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

        void LoadFoodCategory()
        {
            List<FoodCategory> listFoodCategory = FoodCategoryDAO.Instance.GetListFoodCategory();
            cbbCategoryMain.DataSource = listFoodCategory;
            cbbCategoryMain.DisplayMember = "name";
        }

        void LoadListFoodByIdCategory(int id)
        {
            List<Food> listFood = FoodDAO.Instance.getFoodByIdCategory(id);
            cbbFoodMain.DataSource = listFood;
            cbbFoodMain.DisplayMember = "name";

        }
        void ShowBill(int id)
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
            lsvBill.Tag = (sender as Button).Tag;
            ShowBill(tableId);
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
        private void cbbCategoryMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cbb = sender as ComboBox;
            if (cbb.SelectedItem == null)
                return;

            FoodCategory selected = cbb.SelectedItem as FoodCategory;
            id = selected.ID;
            LoadListFoodByIdCategory(id);
        }
        private void btnAddFoodMain_Click(object sender, EventArgs e)
        {
            TableFood table = lsvBill.Tag as TableFood;
            if (table == null)
            {
                MessageBox.Show("Hãy chọn bàn");
                return;
            }

            int idFood = (cbbFoodMain.SelectedItem as Food).Id;
            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.Id);
            int quantity = (int)nmCountFoodMain.Value;
            if (idBill == -1)
            {
                BillDAO.Instance.AddBill(table.Id);
                BillDetailDAO.Instance.AddBillDetail(BillDAO.Instance.GetMaxIDBill(), idFood, quantity);
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                BillDetailDAO.Instance.AddBillDetail(idBill, idFood, quantity);
                MessageBox.Show("Thêm thành công");
            }
            TableFoodDAO.Instance.UpdateUnEmptyTableFood(table.Id);
            ShowBill(table.Id);
            LoadTableFood();
        }

        #endregion
    }
}
