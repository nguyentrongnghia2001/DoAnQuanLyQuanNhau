
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
            this.lsvOrder = new System.Windows.Forms.ListView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.nmPriceFoodMain = new System.Windows.Forms.NumericUpDown();
            this.btnAddFoodMain = new System.Windows.Forms.Button();
            this.cbbCategoryMain = new System.Windows.Forms.ComboBox();
            this.cbbFoodMain = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flpTableFood = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmPriceFoodMain)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(1428, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // danhMucjToolStripMenuItem
            // 
            this.danhMucjToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.danhMucjToolStripMenuItem.Name = "danhMucjToolStripMenuItem";
            this.danhMucjToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.danhMucjToolStripMenuItem.Text = "Danh Mục";
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinTàiKhoảnToolStripMenuItem1,
            this.đăngXuấtToolStripMenuItem});
            this.thôngTinTàiKhoảnToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
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
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.lsvOrder);
            this.panel2.Location = new System.Drawing.Point(636, 137);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(555, 520);
            this.panel2.TabIndex = 2;
            // 
            // lsvOrder
            // 
            this.lsvOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvOrder.HideSelection = false;
            this.lsvOrder.Location = new System.Drawing.Point(2, 3);
            this.lsvOrder.Name = "lsvOrder";
            this.lsvOrder.Size = new System.Drawing.Size(550, 514);
            this.lsvOrder.TabIndex = 0;
            this.lsvOrder.UseCompatibleStateImageBehavior = false;
            this.lsvOrder.SelectedIndexChanged += new System.EventHandler(this.lsvOrder_SelectedIndexChanged);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.nmPriceFoodMain);
            this.panel4.Controls.Add(this.btnAddFoodMain);
            this.panel4.Controls.Add(this.cbbCategoryMain);
            this.panel4.Controls.Add(this.cbbFoodMain);
            this.panel4.Location = new System.Drawing.Point(636, 31);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(555, 100);
            this.panel4.TabIndex = 4;
            // 
            // nmPriceFoodMain
            // 
            this.nmPriceFoodMain.Location = new System.Drawing.Point(490, 39);
            this.nmPriceFoodMain.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmPriceFoodMain.Name = "nmPriceFoodMain";
            this.nmPriceFoodMain.Size = new System.Drawing.Size(53, 22);
            this.nmPriceFoodMain.TabIndex = 3;
            this.nmPriceFoodMain.Value = new decimal(new int[] {
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
            this.btnAddFoodMain.Location = new System.Drawing.Point(282, 8);
            this.btnAddFoodMain.Name = "btnAddFoodMain";
            this.btnAddFoodMain.Size = new System.Drawing.Size(202, 80);
            this.btnAddFoodMain.TabIndex = 2;
            this.btnAddFoodMain.Text = "Thêm Món";
            this.btnAddFoodMain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddFoodMain.UseVisualStyleBackColor = true;
            // 
            // cbbCategoryMain
            // 
            this.cbbCategoryMain.FormattingEnabled = true;
            this.cbbCategoryMain.Location = new System.Drawing.Point(10, 52);
            this.cbbCategoryMain.Name = "cbbCategoryMain";
            this.cbbCategoryMain.Size = new System.Drawing.Size(266, 24);
            this.cbbCategoryMain.TabIndex = 1;
            // 
            // cbbFoodMain
            // 
            this.cbbFoodMain.FormattingEnabled = true;
            this.cbbFoodMain.Location = new System.Drawing.Point(10, 22);
            this.cbbFoodMain.Name = "cbbFoodMain";
            this.cbbFoodMain.Size = new System.Drawing.Size(266, 24);
            this.cbbFoodMain.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(1197, 31);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(219, 623);
            this.panel3.TabIndex = 5;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(61, 582);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 30);
            this.textBox1.TabIndex = 5;
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
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Coral;
            this.button2.Image = global::DoAnQuanLyQuanNhau.Properties.Resources.money;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(3, 281);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(211, 69);
            this.button2.TabIndex = 3;
            this.button2.Text = "Thanh Toán";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 251);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(211, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::DoAnQuanLyQuanNhau.Properties.Resources.transfer;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(3, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 69);
            this.button1.TabIndex = 1;
            this.button1.Text = "Chuyển Bàn";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
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
            this.flpTableFood.Location = new System.Drawing.Point(12, 31);
            this.flpTableFood.Name = "flpTableFood";
            this.flpTableFood.Size = new System.Drawing.Size(614, 620);
            this.flpTableFood.TabIndex = 0;
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
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Phầm Mềm Quản Lí Quán Nhậu ";
            this.Load += new System.EventHandler(this.frmManager_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmPriceFoodMain)).EndInit();
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
        private System.Windows.Forms.ListView lsvOrder;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cbbCategoryMain;
        private System.Windows.Forms.ComboBox cbbFoodMain;
        private System.Windows.Forms.NumericUpDown nmPriceFoodMain;
        private System.Windows.Forms.Button btnAddFoodMain;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem danhMucjToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flpTableFood;
    }
}

