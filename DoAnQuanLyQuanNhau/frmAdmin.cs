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
        BindingSource listAccount = new BindingSource();
        BindingSource listOffical = new BindingSource();
        BindingSource listTableFood = new BindingSource();
        public Account loginAcc;
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
            dgvAccount.DataSource = listAccount;
            dgvOffical.DataSource = listOffical;
            dgvTableFood.DataSource = listTableFood;
            AddFoodBinding();
            AddTableFoodBinding();
            AddFoodCategoryBinding();
            AddOfficalBinding();
            AddAccountBinding();

            //Food Category
            LoadListCategoryFood();
            

            //Food
            LoadListFood();
            LoadFoodCategory();

            //Account
            LoadListAccountByNameOffice();

            //Office
            LoadListOffice();

            //Table Food
            LoadListTableFood();

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

        void AddOfficalBinding()
        {
            txbIdOffical.DataBindings.Add(new Binding("Text", dgvOffical.DataSource, "id", true, DataSourceUpdateMode.Never));
            txbNameOffical.DataBindings.Add(new Binding("Text", dgvOffical.DataSource, "name", true, DataSourceUpdateMode.Never));
        }
        void AddTableFoodBinding()
        {
            txbIdTableFood.DataBindings.Add(new Binding("Text", dgvTableFood.DataSource, "id", true, DataSourceUpdateMode.Never));
            txbNameTableFood.DataBindings.Add(new Binding("Text", dgvTableFood.DataSource, "name", true, DataSourceUpdateMode.Never));
            txbPositionTableFood.DataBindings.Add(new Binding("Text", dgvTableFood.DataSource, "position", true, DataSourceUpdateMode.Never));
        }
        void AddAccountBinding()
        {
            txbUsername.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "username", true, DataSourceUpdateMode.Never));
            txbFullname.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "fullname", true, DataSourceUpdateMode.Never));
            txbIdAccount.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "id", true, DataSourceUpdateMode.Never));
        }
        void LoadListOffice()
        {
            listOffical.DataSource = OfficeDAO.Instance.GetListOffice();

            List<Office> list = OfficeDAO.Instance.GetListOffice();
            cbbOffice.DataSource = list;
            cbbOffice.ValueMember = "id";
            cbbOffice.DisplayMember = "name";
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
            //listAccount.DataSource = AccountDAO.Instance.GetListAccount();
            List<Account> listAcc = AccountDAO.Instance.GetListAccount();
            cbbIdAccount.DataSource = listAcc;
            cbbIdAccount.ValueMember = "id";
            cbbIdAccount.DisplayMember = "fullname";
        }

        void LoadListAccountByNameOffice()
        {
            listAccount.DataSource = GetAccountByOfficeDAO.Instance.GetListAccountByOffice();
        }

        void LoadListCategoryFood()
        {
            listFoodCategory.DataSource = FoodCategoryDAO.Instance.GetListFoodCategory();

        }
        void LoadListTableFood()
        {
            listTableFood.DataSource = TableFoodDAO.Instance.GetListTableFood();

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
            btnSaveAccount.Enabled = false;
            btnSaveOffical.Enabled = false;
            btnSaveTableFood.Enabled = false;
            btnSaveAccount.Enabled = false;
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
                if (string.IsNullOrWhiteSpace(name))
                {
                    MessageBox.Show("Tên trống!");
                }
                else
                {
                    if (FoodCategoryDAO.Instance.UpdateFoodCategory(name, id))
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

        //Offical
        private void btnAddOffical_Click(object sender, EventArgs e)
        {
            txbIdOffical.Text = "";
            txbNameOffical.Text = "";
            btnSaveOffical.Enabled = true;
        }

        private void btnDeleteOffical_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbIdOffical.Text);

            DialogResult result = MessageBox.Show("Bạn có muốn xoá?", "Xác nhận xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                MessageBox.Show("Xoá không thành công!");
            }
            else
            {
                if (OfficeDAO.Instance.DeleteOffice(id))
                {
                    MessageBox.Show("Xoá thành công!");
                    LoadListOffice();
                    if (deleteOffice != null)
                        deleteOffice(this, new EventArgs());
                }
                else
                {
                    MessageBox.Show("Có lỗi khi xoá!");
                }
            }
        }

        private void btnEditOffical_Click(object sender, EventArgs e)
        {
            string name = txbNameOffical.Text;
            int id = Convert.ToInt32(txbIdOffical.Text);

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
                    if (OfficeDAO.Instance.UpdateOffice(name, id))
                    {
                        MessageBox.Show("Sửa thành công!");
                        LoadListOffice();
                        if (updateOffice != null)
                            updateOffice(this, new EventArgs());
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi sửa!");
                    }
                }
            }
        }

        private void btnShowOffical_Click(object sender, EventArgs e)
        {
            LoadListOffice();
            btnSaveOffical.Enabled = false;
        }

        private void btnSaveOffical_Click(object sender, EventArgs e)
        {
            string name = txbNameOffical.Text;

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
                    if (OfficeDAO.Instance.InsertOffice(name))
                    {
                        MessageBox.Show("Thêm thành công!");
                        LoadListOffice();
                        if (insertOffice != null)
                            insertOffice(this, new EventArgs());
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi thêm!");
                    }
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
                txbSumBill.Text = string.Format("{0:N0} ₫", totalSum * 1000);
            }
        }

        private void btnResetViewBill_Click(object sender, EventArgs e)
        {
            LoadDateTimePickerBill();
            LoadListBillByDate(dtpFromDate.Value, dtpToDate.Value);
            txbSumBill.Text = "";
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

        //Table Food
        private void btnAddTableFood_Click(object sender, EventArgs e)
        {
            txbIdTableFood.Text = "";
            txbNameTableFood.Text = "";
            txbPositionTableFood.Text = "";
            btnSaveTableFood.Enabled = true;
        }

        private void btnDeleteTableFood_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbIdTableFood.Text);

            DialogResult result = MessageBox.Show("Bạn có muốn xoá?", "Xác nhận xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                MessageBox.Show("Xoá không thành công!");
            }
            else
            {
                if (TableFoodDAO.Instance.DeleteTableFood(id))
                {
                    MessageBox.Show("Xoá thành công!");
                    LoadListTableFood();
                    if (deleteTableFood != null)
                        deleteTableFood(this, new EventArgs());
                }
                else
                {
                    MessageBox.Show("Có lỗi khi xoá!");
                }
            }
        }

        private void btnEditTableFood_Click(object sender, EventArgs e)
        {
            string name = txbNameTableFood.Text;
            string position = txbPositionTableFood.Text;
            int id = Convert.ToInt32(txbIdTableFood.Text);

            DialogResult result = MessageBox.Show("Bạn có muốn sửa?", "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                MessageBox.Show("Sửa không thành công!");
            }
            else
            {
                if (string.IsNullOrWhiteSpace(name)||string.IsNullOrWhiteSpace(position))
                {
                    MessageBox.Show("Tên hoặc vị trí trống!");
                }
                else
                {
                    if (TableFoodDAO.Instance.UpdateTableFood(name, position, id))
                    {
                        MessageBox.Show("Sửa thành công!");
                        LoadListTableFood();
                        if (updateTableFood != null)
                            updateTableFood(this, new EventArgs());
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi sửa!");
                    }
                }
            }
        }

        private void btnShowTableFood_Click(object sender, EventArgs e)
        {
            LoadListTableFood();
            btnSaveTableFood.Enabled = false;
        }

        private void btnSaveTableFood_Click_1(object sender, EventArgs e)
        {
            string name = txbNameTableFood.Text;
            string position = txbPositionTableFood.Text;

            DialogResult result = MessageBox.Show("Bạn có muốn thêm?", "Xác nhận thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                MessageBox.Show("Thêm không thành công!");
            }
            else
            {
                if (string.IsNullOrWhiteSpace(name)||string.IsNullOrWhiteSpace(position))
                {
                    MessageBox.Show("Tên hoặc vị trí trống!");
                }
                else
                {
                    if (TableFoodDAO.Instance.InsertTableFood(name,position))
                    {
                        MessageBox.Show("Thêm thành công!");
                        LoadListTableFood();
                        if (insertTableFood != null)
                            insertTableFood(this, new EventArgs());
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi thêm!");
                    }
                }
            }
        }

        //Account
        private void btnSaveAccount_Click(object sender, EventArgs e)
        {
            string username = txbUsername.Text;
            string fullname = txbFullname.Text;
            int idOffice = (cbbOffice.SelectedItem as Office).Id;

            DialogResult result = MessageBox.Show("Bạn có muốn thêm?", "Xác nhận thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                MessageBox.Show("Thêm không thành công!");
            }
            else
            {
                if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(fullname))
                {
                    MessageBox.Show("Tên trống!");
                }
                else
                {
                    if (AccountDAO.Instance.InsertAccount(username, fullname, "1962026656160185351301320480154111117132155", idOffice))
                    {
                        MessageBox.Show("Thêm thành công!");
                        LoadListAccountByNameOffice();
                        if (insertAccount != null)
                            insertAccount(this, new EventArgs());
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi thêm!");
                    }
                }
            }
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {

        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            txbUsername.Text = "nv" + AccountDAO.Instance.GetMaxIdAccount();
            btnSaveAccount.Enabled = true;
            txbFullname.Text = "";
            txbIdAccount.Text = "";
        }

        private void btnDeleteAcount_Click(object sender, EventArgs e)
        {
            if (loginAcc.Username.Equals(txbUsername.Text))
            {
                MessageBox.Show("Bạn không được xoá chính mình!");
            }
            else
            {
                int id = Convert.ToInt32(txbIdAccount.Text);

                DialogResult result = MessageBox.Show("Bạn có muốn xoá?", "Xác nhận xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    MessageBox.Show("Xoá không thành công!");
                }
                else
                {
                    if (AccountDAO.Instance.DeleteAccount(id))
                    {
                        MessageBox.Show("Xoá thành công!");
                        LoadListAccountByNameOffice();
                        if (deleteAccount != null)
                            deleteAccount(this, new EventArgs());
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi xoá!");
                    }
                }
            }
        }

        private void btnEditAcount_Click(object sender, EventArgs e)
        {

        }

        private void btnShowAccount_Click(object sender, EventArgs e)
        {
            LoadListAccountByNameOffice();
            btnSaveAccount.Enabled = false;
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

        //Offical Handler
        private event EventHandler insertOffice;
        public event EventHandler InsertOffice
        {
            add { insertOffice += value; }
            remove { insertOffice -= value; }
        }

        private event EventHandler updateOffice;
        public event EventHandler UpdateOffice
        {
            add { updateOffice += value; }
            remove { updateOffice -= value; }
        }


        private event EventHandler deleteOffice;
        public event EventHandler DeleteOffice
        {
            add { deleteOffice += value; }
            remove { deleteOffice -= value; }
        }

        //TableFood Handler
        private event EventHandler insertTableFood;
        public event EventHandler InsertTableFood
        {
            add { insertTableFood += value; }
            remove { insertTableFood -= value; }
        }

        private event EventHandler updateTableFood;
        public event EventHandler UpdateTableFood
        {
            add { updateTableFood += value; }
            remove { updateTableFood -= value; }
        }


        private event EventHandler deleteTableFood;
        public event EventHandler DeleteTableFood
        {
            add { deleteTableFood += value; }
            remove { deleteTableFood -= value; }
        }

        //Account Handler
        private event EventHandler insertAccount;
        public event EventHandler InsertAccount
        {
            add { insertAccount += value; }
            remove { insertAccount -= value; }
        }

        private event EventHandler updateAccount;
        public event EventHandler UpdateAccount
        {
            add { updateAccount += value; }
            remove { updateAccount -= value; }
        }


        private event EventHandler deleteAccount;
        public event EventHandler DeleteAccount
        {
            add { deleteAccount += value; }
            remove { deleteAccount -= value; }
        }

        private void txbPriceFood_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txbIdAccount_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    if (dgvAccount.SelectedCells.Count > 0)
            //    {
            //        int id = (int)dgvAccount.SelectedCells[0].OwningRow.Cells["Id_office"].Value;

            //        Office office = OfficeDAO.Instance.GetOfficeByID(id);

            //        cbbOffice.SelectedItem = office;

            //        int index = -1;
            //        int i = 0;
            //        foreach (Office item in cbbOffice.Items)
            //        {
            //            if (item.Id == office.Id)
            //            {
            //                index = i;
            //                break;
            //            }
            //            i++;
            //        }

            //        cbbOffice.SelectedIndex = index;
            //    }
            //}
            //catch
            //{
            //    MessageBox.Show("Lỗi!");
            //}
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

        private void dgvAccount_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Kiểm tra nếu là cột "type"
            if (e.ColumnIndex == dgvAccount.Columns["type_account"].Index && e.RowIndex >= 0)
            {
                // Lấy giá trị của ô
                var cellValue = dgvAccount.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                // Kiểm tra giá trị của ô
                if (cellValue != null && cellValue != DBNull.Value)
                {
                    // Nếu giá trị là 1, hiển thị "Admin", ngược lại hiển thị "Nhân Viên"
                    e.Value = (int)cellValue == 0 ? "Admin" : "Nhân Viên";
                    e.FormattingApplied = true; // Đánh dấu rằng đã xử lý định dạng
                }
            }
        }

        #endregion
    }
}
