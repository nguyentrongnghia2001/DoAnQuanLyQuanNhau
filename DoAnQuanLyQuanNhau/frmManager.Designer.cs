﻿
namespace DoAnQuanLyQuanNhau
{
    partial class frmManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManager));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMucjToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lsvBill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel4 = new System.Windows.Forms.Panel();
            this.nmCountFoodMain = new System.Windows.Forms.NumericUpDown();
            this.btnAddFoodMain = new System.Windows.Forms.Button();
            this.cbbCategoryMain = new System.Windows.Forms.ComboBox();
            this.cbbFoodMain = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txbTableFoodSelected = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txbTotalPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCheckOutMain = new System.Windows.Forms.Button();
            this.cbbTableFoodEmpty = new System.Windows.Forms.ComboBox();
            this.btnSwapTableFood = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flpTableFood = new System.Windows.Forms.FlowLayoutPanel();
            this.thanhToánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmMónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txbNameKh = new System.Windows.Forms.TextBox();
            this.btnSearchKh = new System.Windows.Forms.Button();
            this.txbPhoneKH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmCountFoodMain)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.danhMucjToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1428, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(75, 26);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // danhMucjToolStripMenuItem
            // 
            this.danhMucjToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thanhToánToolStripMenuItem,
            this.thêmMónToolStripMenuItem});
            this.danhMucjToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.danhMucjToolStripMenuItem.Name = "danhMucjToolStripMenuItem";
            this.danhMucjToolStripMenuItem.Size = new System.Drawing.Size(98, 26);
            this.danhMucjToolStripMenuItem.Text = "Phím Tắt";
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinTàiKhoảnToolStripMenuItem1,
            this.đăngXuấtToolStripMenuItem});
            this.thôngTinTàiKhoảnToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(107, 26);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Tài Khoản";
            // 
            // thôngTinTàiKhoảnToolStripMenuItem1
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem1.Name = "thôngTinTàiKhoảnToolStripMenuItem1";
            this.thôngTinTàiKhoảnToolStripMenuItem1.Size = new System.Drawing.Size(265, 26);
            this.thôngTinTàiKhoảnToolStripMenuItem1.Text = "Thông Tin Tài Khoản";
            this.thôngTinTàiKhoảnToolStripMenuItem1.Click += new System.EventHandler(this.thôngTinTàiKhoảnToolStripMenuItem1_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.lsvBill);
            this.panel2.Location = new System.Drawing.Point(636, 137);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(555, 520);
            this.panel2.TabIndex = 2;
            // 
            // lsvBill
            // 
            this.lsvBill.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvBill.GridLines = true;
            this.lsvBill.HideSelection = false;
            this.lsvBill.Location = new System.Drawing.Point(2, 3);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(550, 514);
            this.lsvBill.TabIndex = 0;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            this.lsvBill.View = System.Windows.Forms.View.Details;
            this.lsvBill.SelectedIndexChanged += new System.EventHandler(this.lsvOrder_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên Món";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số Lượng";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 65;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn Giá";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành Tiền";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 130;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.nmCountFoodMain);
            this.panel4.Controls.Add(this.btnAddFoodMain);
            this.panel4.Controls.Add(this.cbbCategoryMain);
            this.panel4.Controls.Add(this.cbbFoodMain);
            this.panel4.Location = new System.Drawing.Point(636, 31);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(555, 100);
            this.panel4.TabIndex = 4;
            // 
            // nmCountFoodMain
            // 
            this.nmCountFoodMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmCountFoodMain.Location = new System.Drawing.Point(499, 35);
            this.nmCountFoodMain.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmCountFoodMain.Name = "nmCountFoodMain";
            this.nmCountFoodMain.Size = new System.Drawing.Size(53, 24);
            this.nmCountFoodMain.TabIndex = 3;
            this.nmCountFoodMain.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAddFoodMain
            // 
            this.btnAddFoodMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFoodMain.Image = global::DoAnQuanLyQuanNhau.Properties.Resources.plus;
            this.btnAddFoodMain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddFoodMain.Location = new System.Drawing.Point(295, 8);
            this.btnAddFoodMain.Name = "btnAddFoodMain";
            this.btnAddFoodMain.Size = new System.Drawing.Size(185, 72);
            this.btnAddFoodMain.TabIndex = 2;
            this.btnAddFoodMain.Text = "Thêm Món";
            this.btnAddFoodMain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddFoodMain.UseVisualStyleBackColor = true;
            this.btnAddFoodMain.Click += new System.EventHandler(this.btnAddFoodMain_Click);
            // 
            // cbbCategoryMain
            // 
            this.cbbCategoryMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCategoryMain.FormattingEnabled = true;
            this.cbbCategoryMain.Location = new System.Drawing.Point(10, 52);
            this.cbbCategoryMain.Name = "cbbCategoryMain";
            this.cbbCategoryMain.Size = new System.Drawing.Size(266, 28);
            this.cbbCategoryMain.TabIndex = 1;
            this.cbbCategoryMain.SelectedIndexChanged += new System.EventHandler(this.cbbCategoryMain_SelectedIndexChanged);
            // 
            // cbbFoodMain
            // 
            this.cbbFoodMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbFoodMain.FormattingEnabled = true;
            this.cbbFoodMain.Location = new System.Drawing.Point(10, 22);
            this.cbbFoodMain.Name = "cbbFoodMain";
            this.cbbFoodMain.Size = new System.Drawing.Size(266, 28);
            this.cbbFoodMain.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txbPhoneKH);
            this.panel3.Controls.Add(this.btnSearchKh);
            this.panel3.Controls.Add(this.txbNameKh);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txbTableFoodSelected);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.txbTotalPrice);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnCheckOutMain);
            this.panel3.Controls.Add(this.cbbTableFoodEmpty);
            this.panel3.Controls.Add(this.btnSwapTableFood);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(1197, 31);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(219, 623);
            this.panel3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Chuyển đến";
            // 
            // txbTableFoodSelected
            // 
            this.txbTableFoodSelected.BackColor = System.Drawing.Color.Orange;
            this.txbTableFoodSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTableFoodSelected.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txbTableFoodSelected.Location = new System.Drawing.Point(7, 207);
            this.txbTableFoodSelected.Multiline = true;
            this.txbTableFoodSelected.Name = "txbTableFoodSelected";
            this.txbTableFoodSelected.ReadOnly = true;
            this.txbTableFoodSelected.Size = new System.Drawing.Size(203, 25);
            this.txbTableFoodSelected.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Bàn đang chọn:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DoAnQuanLyQuanNhau.Properties.Resources.business;
            this.pictureBox2.Location = new System.Drawing.Point(10, 563);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // txbTotalPrice
            // 
            this.txbTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTotalPrice.ForeColor = System.Drawing.Color.Red;
            this.txbTotalPrice.Location = new System.Drawing.Point(61, 582);
            this.txbTotalPrice.Multiline = true;
            this.txbTotalPrice.Name = "txbTotalPrice";
            this.txbTotalPrice.ReadOnly = true;
            this.txbTotalPrice.Size = new System.Drawing.Size(153, 30);
            this.txbTotalPrice.TabIndex = 5;
            this.txbTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 554);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tổng Tiền:";
            // 
            // btnCheckOutMain
            // 
            this.btnCheckOutMain.BackColor = System.Drawing.Color.White;
            this.btnCheckOutMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOutMain.ForeColor = System.Drawing.Color.Coral;
            this.btnCheckOutMain.Image = global::DoAnQuanLyQuanNhau.Properties.Resources.money;
            this.btnCheckOutMain.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCheckOutMain.Location = new System.Drawing.Point(8, 482);
            this.btnCheckOutMain.Name = "btnCheckOutMain";
            this.btnCheckOutMain.Size = new System.Drawing.Size(203, 69);
            this.btnCheckOutMain.TabIndex = 3;
            this.btnCheckOutMain.Text = "Thanh Toán";
            this.btnCheckOutMain.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCheckOutMain.UseVisualStyleBackColor = false;
            this.btnCheckOutMain.Click += new System.EventHandler(this.btnCheckOutMain_Click);
            // 
            // cbbTableFoodEmpty
            // 
            this.cbbTableFoodEmpty.BackColor = System.Drawing.Color.Aqua;
            this.cbbTableFoodEmpty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTableFoodEmpty.FormattingEnabled = true;
            this.cbbTableFoodEmpty.Location = new System.Drawing.Point(8, 258);
            this.cbbTableFoodEmpty.Name = "cbbTableFoodEmpty";
            this.cbbTableFoodEmpty.Size = new System.Drawing.Size(202, 26);
            this.cbbTableFoodEmpty.TabIndex = 2;
            // 
            // btnSwapTableFood
            // 
            this.btnSwapTableFood.BackColor = System.Drawing.Color.Orange;
            this.btnSwapTableFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSwapTableFood.Image = global::DoAnQuanLyQuanNhau.Properties.Resources.transfer;
            this.btnSwapTableFood.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSwapTableFood.Location = new System.Drawing.Point(7, 290);
            this.btnSwapTableFood.Name = "btnSwapTableFood";
            this.btnSwapTableFood.Size = new System.Drawing.Size(202, 69);
            this.btnSwapTableFood.TabIndex = 1;
            this.btnSwapTableFood.Text = "Chuyển Bàn";
            this.btnSwapTableFood.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSwapTableFood.UseVisualStyleBackColor = false;
            this.btnSwapTableFood.Click += new System.EventHandler(this.btnSwapTableFood_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(3, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // flpTableFood
            // 
            this.flpTableFood.AutoScroll = true;
            this.flpTableFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flpTableFood.Location = new System.Drawing.Point(12, 31);
            this.flpTableFood.Name = "flpTableFood";
            this.flpTableFood.Size = new System.Drawing.Size(614, 620);
            this.flpTableFood.TabIndex = 0;
            // 
            // thanhToánToolStripMenuItem
            // 
            this.thanhToánToolStripMenuItem.Name = "thanhToánToolStripMenuItem";
            this.thanhToánToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.thanhToánToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.thanhToánToolStripMenuItem.Text = "Thanh Toán";
            this.thanhToánToolStripMenuItem.Click += new System.EventHandler(this.thanhToánToolStripMenuItem_Click);
            // 
            // thêmMónToolStripMenuItem
            // 
            this.thêmMónToolStripMenuItem.Name = "thêmMónToolStripMenuItem";
            this.thêmMónToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.thêmMónToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.thêmMónToolStripMenuItem.Text = "Thêm Món";
            this.thêmMónToolStripMenuItem.Click += new System.EventHandler(this.thêmMónToolStripMenuItem_Click);
            // 
            // txbNameKh
            // 
            this.txbNameKh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNameKh.Location = new System.Drawing.Point(10, 365);
            this.txbNameKh.Multiline = true;
            this.txbNameKh.Name = "txbNameKh";
            this.txbNameKh.Size = new System.Drawing.Size(199, 53);
            this.txbNameKh.TabIndex = 4;
            // 
            // btnSearchKh
            // 
            this.btnSearchKh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchKh.Image = global::DoAnQuanLyQuanNhau.Properties.Resources.search;
            this.btnSearchKh.Location = new System.Drawing.Point(159, 425);
            this.btnSearchKh.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchKh.Name = "btnSearchKh";
            this.btnSearchKh.Size = new System.Drawing.Size(50, 50);
            this.btnSearchKh.TabIndex = 10;
            this.btnSearchKh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearchKh.UseVisualStyleBackColor = true;
            this.btnSearchKh.Click += new System.EventHandler(this.btnSearchKh_Click);
            // 
            // txbPhoneKH
            // 
            this.txbPhoneKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPhoneKH.Location = new System.Drawing.Point(12, 447);
            this.txbPhoneKH.Multiline = true;
            this.txbPhoneKH.Name = "txbPhoneKH";
            this.txbPhoneKH.Size = new System.Drawing.Size(142, 28);
            this.txbPhoneKH.TabIndex = 11;
            this.txbPhoneKH.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbPhoneKH_KeyDown);
            this.txbPhoneKH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPhoneKH_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 421);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Nhập SĐT khách:";
            // 
            // frmManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 669);
            this.Controls.Add(this.flpTableFood);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phầm Mềm Quản Lí Quán Nhậu ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmManager_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmManager_FormClosed);
            this.Load += new System.EventHandler(this.frmManager_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmCountFoodMain)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lsvBill;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cbbCategoryMain;
        private System.Windows.Forms.ComboBox cbbFoodMain;
        private System.Windows.Forms.NumericUpDown nmCountFoodMain;
        private System.Windows.Forms.Button btnAddFoodMain;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txbTotalPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCheckOutMain;
        private System.Windows.Forms.ComboBox cbbTableFoodEmpty;
        private System.Windows.Forms.Button btnSwapTableFood;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem danhMucjToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flpTableFood;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbTableFoodSelected;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem thanhToánToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmMónToolStripMenuItem;
        private System.Windows.Forms.TextBox txbNameKh;
        private System.Windows.Forms.TextBox txbPhoneKH;
        private System.Windows.Forms.Button btnSearchKh;
        private System.Windows.Forms.Label label4;
    }
}

