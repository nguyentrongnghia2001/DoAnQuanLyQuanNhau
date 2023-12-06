﻿using DoAnQuanLyQuanNhau.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnQuanLyQuanNhau
{
    public partial class frmAdmin : Form
    {
        BindingSource foodCategoryList = new BindingSource();
        public frmAdmin()
        {
            InitializeComponent();
            LoadData();
        }

        #region methods

        void LoadData()
        {
            dgvFoodCategory.DataSource = foodCategoryList;
            LoadListCategoryFood();
            AddCategoryFoodBinding();
        }

        void LoadListCategoryFood()
        {
            foodCategoryList.DataSource = FoodCategoryDAO.Instance.GetListFoodCategory();
        }

        void AddCategoryFoodBinding()
        {
            txbCategoryFoodId.DataBindings.Add(new Binding("Text", dgvFoodCategory.DataSource, "id", true, DataSourceUpdateMode.Never));
            txbCategoryFoodName.DataBindings.Add(new Binding("Text", dgvFoodCategory.DataSource, "name", true, DataSourceUpdateMode.Never));
        }

        #endregion

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            btnSaveFoodCategory.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        #region events

        private void btnShowFoodCategory_Click(object sender, EventArgs e)
        {
            LoadListCategoryFood();
            btnSaveFoodCategory.Enabled = false;
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

            DialogResult result = MessageBox.Show("Bạn có muốn thêm danh mục?", "Xác nhận thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                MessageBox.Show("Thêm danh mục không thành công!");
            }
            else
            {
                if (string.IsNullOrWhiteSpace(name))
                {
                    MessageBox.Show("Tên danh mục trống!");
                }
                else
                {
                    if (FoodCategoryDAO.Instance.InsertFoodCategory(name))
                    {
                        MessageBox.Show("Thêm danh mục thành công");
                        LoadListCategoryFood();
                        if (insertFoodCategory != null)
                            insertFoodCategory(this, new EventArgs());
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi thêm danh mục");
                    }
                }
            }
        }


        private void btnEditFoodCategory_Click(object sender, EventArgs e)
        {
            string name = txbCategoryFoodName.Text;
            int id = Convert.ToInt32(txbCategoryFoodId.Text);

            DialogResult result = MessageBox.Show("Bạn có muốn sửa danh mục?", "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                MessageBox.Show("Sửa danh mục không thành công!");
            }
            else
            {
                if (FoodCategoryDAO.Instance.UpdateFoodCategory(name,id))
                {
                    MessageBox.Show("Sửa danh mục thành công");
                    LoadListCategoryFood();
                    if (updateFood != null)
                        updateFood(this, new EventArgs());
                }
                else
                {
                    MessageBox.Show("Có lỗi khi sửa danh mục");
                }
            }
        }

        private void btnDeleteFoodCategory_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbCategoryFoodId.Text);

            DialogResult result = MessageBox.Show("Bạn có muốn xoá danh mục?", "Xác nhận xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                MessageBox.Show("Xoá danh mục không thành công!");
            }
            else
            {
                if (FoodCategoryDAO.Instance.DeleteFoodCategory(id))
                {
                    MessageBox.Show("Xoá danh mục thành công");
                    LoadListCategoryFood();
                    if (deleteFoodCategory != null)
                        deleteFoodCategory(this, new EventArgs());
                }
                else
                {
                    MessageBox.Show("Có lỗi khi xoá danh mục");
                }
            }
        }



        private event EventHandler insertFoodCategory;
        public event EventHandler InsertFoodCategory
        {
            add { insertFoodCategory += value; }
            remove { insertFoodCategory -= value; }
        }

        private event EventHandler deleteFood;
        public event EventHandler DeleteFood
        {
            add { deleteFood += value; }
            remove { deleteFood -= value; }
        }

        private event EventHandler updateFood;
        public event EventHandler UpdateFood
        {
            add { updateFood += value; }
            remove { updateFood -= value; }
        }


        private event EventHandler deleteFoodCategory;
        public event EventHandler DeleteFoodCategory
        {
            add { deleteFoodCategory += value; }
            remove { deleteFoodCategory -= value; }
        }


        #endregion

     
    }
}