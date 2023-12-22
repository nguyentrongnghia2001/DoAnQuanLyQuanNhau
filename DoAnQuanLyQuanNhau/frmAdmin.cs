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
    public partial class frmAdmin : Form
    {
        BindingSource listFood = new BindingSource();
        BindingSource listFoodCategory = new BindingSource();
        public frmAdmin()
        {
            InitializeComponent();
            LoadData();
        }

        #region methods
        List<GetFoodByCategory> SearchFoodByName(string name)
        {
            List<GetFoodByCategory> listFood = GetFoodByCategoryDAO.Instance.SearchFoodByName(name);

            return listFood;
        }

        void LoadData()
        {
            //Binding Data
            dgvFoodCategory.DataSource = listFoodCategory;
            dgvFood.DataSource = listFood;
            AddFoodBinding();
            AddFoodCategoryBinding();

            //Food Category
            LoadListCategoryFood();
            

            //Food
            LoadListFood();
            LoadFoodCategory();


            //Thông Kê
            LoadListAccount();
            LoadDateTimePickerBill();
            LoadListBillByDate(dtpFromDate.Value, dtpToDate.Value);
        }

        void LoadListFood()
        {
            listFood.DataSource = GetFoodByCategoryDAO.Instance.GetListFood();

            //Format vnđ
            var provider = new System.Globalization.CultureInfo("vi-VN");
            dgvFood.Columns["priceFood"].DefaultCellStyle.FormatProvider = provider;
            dgvFood.Columns["priceFood"].DefaultCellStyle.Format = "C2";
        }

        void AddFoodBinding()
        {
            txbIdFood.DataBindings.Add(new Binding("Text", dgvFood.DataSource, "id", true, DataSourceUpdateMode.Never));
            txbNameFood.DataBindings.Add(new Binding("Text", dgvFood.DataSource, "name", true, DataSourceUpdateMode.Never));
            txbPriceFood.DataBindings.Add(new Binding("Text", dgvFood.DataSource, "price", true, DataSourceUpdateMode.Never));
        }

        void AddFoodCategoryBinding()
        {
            txbCategoryFoodId.DataBindings.Add(new Binding("Text", dgvFoodCategory.DataSource, "id", true, DataSourceUpdateMode.Never));
            txbCategoryFoodName.DataBindings.Add(new Binding("Text", dgvFoodCategory.DataSource, "name", true, DataSourceUpdateMode.Never));
        }


        void LoadFoodCategory()
        {
            List<FoodCategory> listFoodCategory = FoodCategoryDAO.Instance.GetListFoodCategory();
            cbbFoodCategory.DataSource = listFoodCategory;
            cbbFoodCategory.ValueMember = "id";
            cbbFoodCategory.DisplayMember = "name";
        }

        void LoadListAccount()
        {
            List<Account> listAcc = AccountDAO.Instance.GetListAccount();
            cbbIdAccount.DataSource = listAcc;
            cbbIdAccount.ValueMember = "id";
            cbbIdAccount.DisplayMember = "fullname";
        }

        void LoadListCategoryFood()
        {
            listFoodCategory.DataSource = FoodCategoryDAO.Instance.GetListFoodCategory();

        }
        void LoadDateTimePickerBill()
        {
            DateTime today = DateTime.Now;
            dtpFromDate.Value = new DateTime(today.Year, today.Month, 1);
            dtpToDate.Value = dtpFromDate.Value.AddMonths(1).AddDays(-1);
        }
        void LoadListBillByDate(DateTime checkIn, DateTime checkOut)
        {
            dgvBill.DataSource = BillDAO.Instance.GetBillListByDateStore(checkIn, checkOut);
        }
        void LoadListBillByDateAndId(DateTime checkIn, DateTime checkOut, int idAccount)
        {
            dgvBill.DataSource = BillDAO.Instance.GetBillListByDate(checkIn, checkOut, idAccount);
        }

        #endregion

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            btnSaveFoodCategory.Enabled = false;
            btnSaveFood.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        #region events

        private void btnShowFoodCategory_Click(object sender, EventArgs e)
        {
          
        }

        private void btnAddFoodCategory_Click(object sender, EventArgs e)
        {
            txbCategoryFoodId.Text = "";
            txbCategoryFoodName.Text = "";
            btnSaveFoodCategory.Enabled = true;
        }


        private void btnSaveFoodCategory_Click(object sender, EventArgs e)
        {

            string name = txbCategoryFoodName.Text;

            DialogResult result = MessageBox.Show("Bạn có muốn thêm?", "Xác nhận thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                MessageBox.Show("Thêm không thành công!");
            }
            else
            {
                if (string.IsNullOrWhiteSpace(name))
                {
                    MessageBox.Show("Tên trống!");
                }
                else
                {
                    if (FoodCategoryDAO.Instance.InsertFoodCategory(name))
                    {
                        MessageBox.Show("Thêm thành công!");
                        LoadListCategoryFood();
                        if (insertFoodCategory != null)
                            insertFoodCategory(this, new EventArgs());
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi thêm!");
                    }
                }
            }
        }


        private void btnEditFoodCategory_Click(object sender, EventArgs e)
        {
            string name = txbCategoryFoodName.Text;
            int id = Convert.ToInt32(txbCategoryFoodId.Text);

            DialogResult result = MessageBox.Show("Bạn có muốn sửa?", "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                MessageBox.Show("Sửa không thành công!");
            }
            else
            {
                if (FoodCategoryDAO.Instance.UpdateFoodCategory(name,id))
                {
                    MessageBox.Show("Sửa thành công!");
                    LoadListCategoryFood();
                    if (updateFoodCategory != null)
                        updateFoodCategory(this, new EventArgs());
                }
                else
                {
                    MessageBox.Show("Có lỗi khi sửa!");
                }
            }
        }

        private void btnDeleteFoodCategory_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbCategoryFoodId.Text);

            DialogResult result = MessageBox.Show("Bạn có muốn xoá?", "Xác nhận xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                MessageBox.Show("Xoá không thành công!");
            }
            else
            {
                if (FoodCategoryDAO.Instance.DeleteFoodCategory(id))
                {
                    MessageBox.Show("Xoá thành công!");
                    LoadListCategoryFood();
                    if (deleteFoodCategory != null)
                        deleteFoodCategory(this, new EventArgs());
                }
                else
                {
                    MessageBox.Show("Có lỗi khi xoá!");
                }
            }
        }

        private void btnViewBill_Click(object sender, EventArgs e)
        {
            int idAccount = (cbbIdAccount.SelectedItem as Account).Id;
            if ((dtpFromDate.Value == dtpToDate.Value)||(dtpFromDate.Value > dtpToDate.Value))
            {
                MessageBox.Show("Ngày không hợp lệ!");return;
            }
            else
            {
                LoadListBillByDateAndId(dtpFromDate.Value, dtpToDate.Value, idAccount);

                double totalSum = 0;

                foreach (DataGridViewRow row in dgvBill.Rows)
                {
                    if (row.Cells["col_total"].Value != null && row.Cells["col_total"].Value != DBNull.Value)
                    {
                        double value = Convert.ToDouble(row.Cells["col_total"].Value.ToString().Split(',')[0]);
                        totalSum += value;

                    }
                }
                txbSumBill.Text = string.Format("{0:N0} ₫", totalSum * 1000);
            }
        }

        private void btnViewBillStore_Click(object sender, EventArgs e)
        {
            if ((dtpFromDate.Value == dtpToDate.Value) || (dtpFromDate.Value > dtpToDate.Value))
            {
                MessageBox.Show("Ngày không hợp lệ!"); return;
            }
            else
            {
                LoadListBillByDate(dtpFromDate.Value, dtpToDate.Value);

                double totalSum = 0;

                foreach (DataGridViewRow row in dgvBill.Rows)
                {
                    if (row.Cells["col_total"].Value != null && row.Cells["col_total"].Value != DBNull.Value)
                    {
                        double value = Convert.ToDouble(row.Cells["col_total"].Value.ToString().Split(',')[0]);
                        totalSum += value;

                    }
                }
                txbSumBillStore.Text = string.Format("{0:N0} ₫", totalSum * 1000);
            }
        }

        private void btnResetViewBill_Click(object sender, EventArgs e)
        {
            LoadDateTimePickerBill();
            LoadListBillByDate(dtpFromDate.Value, dtpToDate.Value);
            txbSumBill.Text = "";
            txbSumBillStore.Text = "";
        }


        //Food
        private void btnAddFood_Click(object sender, EventArgs e)
        {
            txbIdFood.Text = "";
            txbNameFood.Text = "";
            txbPriceFood.Text = "";
            btnSaveFood.Enabled = true;
        }

        private void btnShowFood_Click(object sender, EventArgs e)
        {
            LoadListFood();
            btnSaveFood.Enabled = false;
        }

        private void btnSaveFood_Click(object sender, EventArgs e)
        {
            string name = txbNameFood.Text;
            int idCategory = (cbbFoodCategory.SelectedItem as FoodCategory).ID;
            if (string.IsNullOrWhiteSpace(txbPriceFood.Text))
            {
                MessageBox.Show("Giá trống!");
                return;
            }
            else
            {
                float price = (float)Convert.ToDouble(txbPriceFood.Text);
                DialogResult result = MessageBox.Show("Bạn có muốn thêm?", "Xác nhận thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    MessageBox.Show("Thêm không thành công!");
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(name))
                    {
                        MessageBox.Show("Tên trống!");
                    }
                    else
                    {
                        if (FoodDAO.Instance.InsertFood(name, idCategory, price))
                        {
                            MessageBox.Show("Thêm thành công!");
                            LoadListFood();
                            if (insertFood != null)
                                insertFood(this, new EventArgs());
                        }
                        else
                        {
                            MessageBox.Show("Có lỗi khi thêm!");
                        }
                    }
                }
            }
        }

        private void btnEditFood_Click(object sender, EventArgs e)
        {
            string name = txbNameFood.Text;
            int idCategory = (int)cbbFoodCategory.SelectedValue;
            int idFood = Convert.ToInt32(txbIdFood.Text);
            if (string.IsNullOrWhiteSpace(txbPriceFood.Text))
            {
                MessageBox.Show("Giá trống!");
                return;
            }
            else
            {
                float price = (float)Convert.ToDouble(txbPriceFood.Text);
                DialogResult result = MessageBox.Show("Bạn có muốn sửa?", "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    MessageBox.Show("Sửa không thành công!");
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(name))
                    {
                        MessageBox.Show("Tên trống!");
                    }
                    else
                    {
                        if (FoodDAO.Instance.UpdateFood(name, idFood, idCategory, price))
                        {
                            MessageBox.Show("Sửa thành công!");
                            LoadListFood();
                            if (updateFood != null)
                                updateFood(this, new EventArgs());
                        }
                        else
                        {
                            MessageBox.Show("Có lỗi khi sửa!");
                        }
                    }
                }
            }
        }
    
        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbIdFood.Text);

            DialogResult result = MessageBox.Show("Bạn có muốn xoá?", "Xác nhận xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                MessageBox.Show("Xoá không thành công!");
            }
            else
            {
                if (FoodDAO.Instance.DeleteFood(id))
                {
                    MessageBox.Show("Xoá thành công!");
                    LoadListFood();
                    if (deleteFood != null)
                        deleteFood(this, new EventArgs());
                }
                else
                {
                    MessageBox.Show("Có lỗi khi xoá!");
                }
            }
        }


        //Category Food
        private event EventHandler insertFoodCategory;
        public event EventHandler InsertFoodCategory
        {
            add { insertFoodCategory += value; }
            remove { insertFoodCategory -= value; }
        }

        private event EventHandler updateFoodCategory;
        public event EventHandler UpdateFoodCategory
        {
            add { updateFoodCategory += value; }
            remove { updateFoodCategory -= value; }
        }


        private event EventHandler deleteFoodCategory;
        public event EventHandler DeleteFoodCategory
        {
            add { deleteFoodCategory += value; }
            remove { deleteFoodCategory -= value; }
        }

        //Food Handler
        private event EventHandler insertFood;
        public event EventHandler InsertFood
        {
            add { insertFood += value; }
            remove { insertFood -= value; }
        }

        private event EventHandler updateFood;
        public event EventHandler UpdateFood
        {
            add { updateFood += value; }
            remove { updateFood -= value; }
        }


        private event EventHandler deleteFood;
        public event EventHandler DeleteFood
        {
            add { deleteFood += value; }
            remove { deleteFood -= value; }
        }

        private void txbPriceFood_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txbIdFood_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvFood.SelectedCells.Count > 0)
                {
                    int id = (int)dgvFood.SelectedCells[0].OwningRow.Cells["Id_category"].Value;

                    FoodCategory cateogory = FoodCategoryDAO.Instance.GetCategoryByID(id);

                    cbbFoodCategory.SelectedItem = cateogory;

                    int index = -1;
                    int i = 0;
                    foreach (FoodCategory item in cbbFoodCategory.Items)
                    {
                        if (item.ID == cateogory.ID)
                        {
                            index = i;
                            break;
                        }
                        i++;
                    }

                    cbbFoodCategory.SelectedIndex = index;
                }
            }
            catch {
                MessageBox.Show("Lỗi!");
            }
        }

        private void btnSearchFood_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbSearchFood.Text))
            {
                MessageBox.Show("Vui lòng nhập từ khoá!");
            }
            else
            {
                listFood.DataSource = SearchFoodByName(txbSearchFood.Text);
            }
        }

        private void txbSearchFood_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearchFood.PerformClick();
            }
        }

        #endregion
    }
}
