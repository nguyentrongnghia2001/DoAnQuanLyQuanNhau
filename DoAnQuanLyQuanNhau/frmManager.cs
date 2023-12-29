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
using static DoAnQuanLyQuanNhau.frmAccountProfile;

namespace DoAnQuanLyQuanNhau
{
    public partial class frmManager : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; CheckAccount(loginAccount.Type); }
        }
        bool isExit = true;
        public frmManager(Account acc)
        {
            InitializeComponent();

            this.LoginAccount = acc;

            LoadTableFood();
            LoadFoodCategory();
            LoadTableFoodEmpty();
            cbbFoodMain.Enabled = false;
        }

        #region Method
            
        void CheckAccount(int type)
        {
            adminToolStripMenuItem.Enabled = type == 0;
            thôngTinTàiKhoảnToolStripMenuItem.Text += " (" + LoginAccount.FullName + ")";
        }

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
            cbbFoodMain.Enabled = false;
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

        void LoadTableFoodEmpty()
        {
            List<TableFood> list = TableFoodDAO.Instance.GetListEmptyTableFood();
            cbbTableFoodEmpty.DataSource = list;
            cbbTableFoodEmpty.ValueMember = "id";
            cbbTableFoodEmpty.DisplayMember = "Display_cbb";
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
            TableFood selectedTable = (sender as Button)?.Tag as TableFood;

            if (selectedTable != null)
            {
                txbTableFoodSelected.Text = selectedTable.Name + " - " + selectedTable.Position;
                lsvBill.Tag = selectedTable;
                ShowBill(selectedTable.Id);
                txbNameKh.Text = "";
                txbPhoneKH.Text = "";
            }
        }

        private void frmManager_Load(object sender, EventArgs e)
        {

        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdmin f = new frmAdmin();
            f.loginAcc = LoginAccount;
            f.InsertFood += f_InsertFood;
            f.UpdateFood += f_UpdateFood;
            f.DeleteFood += f_DeleteFood;
            f.ShowDialog();
        }

        private void f_DeleteFood(object sender, EventArgs e)
        {
            LoadListFoodByIdCategory((cbbCategoryMain.SelectedItem as FoodCategory).ID);
            if (lsvBill.Tag != null)
                ShowBill((lsvBill.Tag as TableFood).Id);
            LoadTableFood();
        }

        private void f_UpdateFood(object sender, EventArgs e)
        {
            LoadListFoodByIdCategory((cbbCategoryMain.SelectedItem as FoodCategory).ID);
            if (lsvBill.Tag != null)
                ShowBill((lsvBill.Tag as TableFood).Id);
        }

        private void f_InsertFood(object sender, EventArgs e)
        {
            LoadListFoodByIdCategory((cbbCategoryMain.SelectedItem as FoodCategory).ID);
            if (lsvBill.Tag != null)
                ShowBill((lsvBill.Tag as TableFood).Id);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lsvOrder_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void thôngTinTàiKhoảnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAccountProfile f = new frmAccountProfile(loginAccount);
            f.UpdateAccount += f_UpdateAccount;
            f.ShowDialog();
        }

        void f_UpdateAccount(object sender, AccountEvent e)
        {
            thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản (" + e.Acc.FullName + ")";
        }

        private void cbbCategoryMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbFoodMain.Enabled = true;
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
            cbbFoodMain.Enabled = false;
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
                BillDAO.Instance.AddBill(table.Id,LoginAccount.Id);
                BillDetailDAO.Instance.AddBillDetail(BillDAO.Instance.GetMaxIDBill(), idFood, quantity);
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                //BillDAO.Instance.AddBill(table.Id, LoginAccount.Id);
                BillDetailDAO.Instance.AddBillDetail(idBill, idFood, quantity);
                MessageBox.Show("Thêm thành công");
            }
            TableFoodDAO.Instance.UpdateUnEmptyTableFood(table.Id);
            ShowBill(table.Id);
            LoadTableFoodEmpty();
            nmCountFoodMain.Value = 1;
            LoadTableFood();
        }

        private void btnCheckOutMain_Click(object sender, EventArgs e)
        {
            TableFood table = lsvBill.Tag as TableFood;
            CultureInfo culture = new CultureInfo("vi-VN");
            if (table == null)
            {
                MessageBox.Show("Hãy chọn bàn");
                return;
            }

            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.Id);
            float totalPrice = (float)Convert.ToDouble(txbTotalPrice.Text.Split(',')[0]);

            if (idBill == -1)
            {
                MessageBox.Show("Bàn chưa có món nào!");
                return;
            }
            else
            {
                if (string.IsNullOrEmpty(txbPhoneKH.Text)||string.IsNullOrEmpty(txbNameKh.Text))
                {
                    MessageBox.Show("Bạn chưa nhập tên hoặc số điện thoại khách hàng!");
                }
                else
                {
                    if (txbPhoneKH.Text.Length < 10 || txbPhoneKH.Text.Length > 10)
                    {
                        MessageBox.Show("Số điện thoại không hợp lệ!");
                    }
                    else
                    {
                        if (MessageBox.Show(string.Format("Bạn có muốn thanh toán bàn này ({0})\nTổng tiền = {1}", table.Name + " - " + table.Position, (totalPrice * 1000).ToString("c", culture)), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                        {
                            BillDAO.Instance.CheckOutBill(idBill, totalPrice * 1000, txbPhoneKH.Text, txbNameKh.Text);
                            TableFoodDAO.Instance.UpdateEmptyTableFood(table.Id);
                            ShowBill(table.Id);
                            LoadTableFoodEmpty();
                            LoadTableFood();
                            txbNameKh.Text = "";
                            txbPhoneKH.Text = "";
                        }
                    }
                }
            }
        }
        private void btnSwapTableFood_Click(object sender, EventArgs e)
        {
            int idTableFoodReceive = (int)cbbTableFoodEmpty.SelectedValue;

            TableFood table = lsvBill.Tag as TableFood;
            if (table == null)
            {
                MessageBox.Show("Hãy chọn bàn muốn chuyển!");
                return;
            }
            else
            {
                if(table.Is_empty == 1)
                {
                    MessageBox.Show("Bàn không hợp lệ! Vui lòng chọn bàn khác!");
                    return;
                }
                else
                {
                    if (MessageBox.Show(string.Format("Bạn có muốn chuyển từ ({0}) sang ({1}) không?", table.Name + " - " + table.Position, cbbTableFoodEmpty.Text) , "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                    {
                        int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.Id);
                        BillDAO.Instance.UpdateIdTableSwap(idTableFoodReceive, idBill);
                        TableFoodDAO.Instance.UpdateEmptyTableFood(table.Id);
                        TableFoodDAO.Instance.UpdateUnEmptyTableFood(idTableFoodReceive);
                        LoadTableFoodEmpty();
                        LoadTableFood();
                        txbTableFoodSelected.Text = "";
                        ShowBill(idTableFoodReceive);
                    }
                }
            }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isExit = false;
            this.Close();
            frmLogin f = new frmLogin();
            f.Show();
        }
        private void frmManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isExit)
                Application.Exit();
        }
        private void frmManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isExit)
            {
                if (MessageBox.Show("Bạn có muốn đóng ứng dụng", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
            
        }

        private void thanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnCheckOutMain_Click(this, new EventArgs());
        }

        private void thêmMónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAddFoodMain_Click(this, new EventArgs());

        }
        private void btnSearchKh_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbPhoneKH.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại!");
            }
            else
            {
                if (txbPhoneKH.Text.Length < 10||txbPhoneKH.Text.Length>10)
                {
                    MessageBox.Show("Số điện thoại không hợp lệ!");
                }
                else
                {
                    if (BillDAO.Instance.GetCusByPhone(txbPhoneKH.Text) != null)
                    {
                        txbNameKh.Text = BillDAO.Instance.GetCusByPhone(txbPhoneKH.Text);
                    }
                    else
                    {
                        MessageBox.Show("Tìm không thấy!");
                    }
                }
            }
        }
        #endregion

        private void txbPhoneKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txbPhoneKH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearchKh.PerformClick();
            }
        }
    }
}
