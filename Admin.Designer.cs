
namespace QuanLyNhaHang
{
    partial class Admin
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
            this.tp_Account = new System.Windows.Forms.TabPage();
            this.panel23 = new System.Windows.Forms.Panel();
            this.btn_ResetPassword = new System.Windows.Forms.Button();
            this.panel24 = new System.Windows.Forms.Panel();
            this.nm_AccountType = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.panel25 = new System.Windows.Forms.Panel();
            this.txt_DisplayName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel26 = new System.Windows.Forms.Panel();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel27 = new System.Windows.Forms.Panel();
            this.btn_ShowAccount = new System.Windows.Forms.Button();
            this.btn_EditAccount = new System.Windows.Forms.Button();
            this.btn_DeleteAccount = new System.Windows.Forms.Button();
            this.btn_AddAccount = new System.Windows.Forms.Button();
            this.panel28 = new System.Windows.Forms.Panel();
            this.dtgv_Account = new System.Windows.Forms.DataGridView();
            this.tp_Food = new System.Windows.Forms.TabPage();
            this.panel10 = new System.Windows.Forms.Panel();
            this.nm_FoodPrice = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txt_SearchFoodName = new System.Windows.Forms.TextBox();
            this.btn_SearchFood = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.cb_FoodCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txt_FoodName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txt_FoodId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_ShowFood = new System.Windows.Forms.Button();
            this.btn_EditFood = new System.Windows.Forms.Button();
            this.btn_DeleteFood = new System.Windows.Forms.Button();
            this.btn_AddFood = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgw_Food = new System.Windows.Forms.DataGridView();
            this.tp_Bill = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_ViewBill = new System.Windows.Forms.Button();
            this.dtpk_ToDay = new System.Windows.Forms.DateTimePicker();
            this.dtpk_FromDay = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgv_Bill = new System.Windows.Forms.DataGridView();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tp_Account.SuspendLayout();
            this.panel23.SuspendLayout();
            this.panel24.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nm_AccountType)).BeginInit();
            this.panel25.SuspendLayout();
            this.panel26.SuspendLayout();
            this.panel27.SuspendLayout();
            this.panel28.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Account)).BeginInit();
            this.tp_Food.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nm_FoodPrice)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgw_Food)).BeginInit();
            this.tp_Bill.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Bill)).BeginInit();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tp_Account
            // 
            this.tp_Account.Controls.Add(this.panel23);
            this.tp_Account.Controls.Add(this.panel27);
            this.tp_Account.Controls.Add(this.panel28);
            this.tp_Account.Location = new System.Drawing.Point(4, 22);
            this.tp_Account.Name = "tp_Account";
            this.tp_Account.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Account.Size = new System.Drawing.Size(859, 517);
            this.tp_Account.TabIndex = 4;
            this.tp_Account.Text = "Tài khoản";
            this.tp_Account.UseVisualStyleBackColor = true;
            // 
            // panel23
            // 
            this.panel23.Controls.Add(this.btn_ResetPassword);
            this.panel23.Controls.Add(this.panel24);
            this.panel23.Controls.Add(this.panel25);
            this.panel23.Controls.Add(this.panel26);
            this.panel23.Location = new System.Drawing.Point(517, 75);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(332, 435);
            this.panel23.TabIndex = 6;
            // 
            // btn_ResetPassword
            // 
            this.btn_ResetPassword.Location = new System.Drawing.Point(222, 210);
            this.btn_ResetPassword.Name = "btn_ResetPassword";
            this.btn_ResetPassword.Size = new System.Drawing.Size(97, 49);
            this.btn_ResetPassword.TabIndex = 4;
            this.btn_ResetPassword.Text = "Đặt lại mật khẩu";
            this.btn_ResetPassword.UseVisualStyleBackColor = true;
            this.btn_ResetPassword.Click += new System.EventHandler(this.btn_ResetPassword_Click);
            // 
            // panel24
            // 
            this.panel24.Controls.Add(this.nm_AccountType);
            this.panel24.Controls.Add(this.label10);
            this.panel24.Location = new System.Drawing.Point(3, 137);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(319, 57);
            this.panel24.TabIndex = 3;
            // 
            // nm_AccountType
            // 
            this.nm_AccountType.Location = new System.Drawing.Point(133, 21);
            this.nm_AccountType.Name = "nm_AccountType";
            this.nm_AccountType.Size = new System.Drawing.Size(44, 20);
            this.nm_AccountType.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 21);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(111, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Loại tài khoản";
            // 
            // panel25
            // 
            this.panel25.Controls.Add(this.txt_DisplayName);
            this.panel25.Controls.Add(this.label11);
            this.panel25.Location = new System.Drawing.Point(3, 74);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(319, 57);
            this.panel25.TabIndex = 2;
            // 
            // txt_DisplayName
            // 
            this.txt_DisplayName.Location = new System.Drawing.Point(129, 18);
            this.txt_DisplayName.Name = "txt_DisplayName";
            this.txt_DisplayName.Size = new System.Drawing.Size(187, 20);
            this.txt_DisplayName.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(15, 21);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label11.Size = new System.Drawing.Size(95, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Tên hiển thị";
            // 
            // panel26
            // 
            this.panel26.Controls.Add(this.txt_UserName);
            this.panel26.Controls.Add(this.label12);
            this.panel26.Location = new System.Drawing.Point(3, 11);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(319, 57);
            this.panel26.TabIndex = 1;
            // 
            // txt_UserName
            // 
            this.txt_UserName.Location = new System.Drawing.Point(129, 18);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(187, 20);
            this.txt_UserName.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(15, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Tên tài khoản";
            // 
            // panel27
            // 
            this.panel27.Controls.Add(this.btn_ShowAccount);
            this.panel27.Controls.Add(this.btn_EditAccount);
            this.panel27.Controls.Add(this.btn_DeleteAccount);
            this.panel27.Controls.Add(this.btn_AddAccount);
            this.panel27.Location = new System.Drawing.Point(10, 7);
            this.panel27.Name = "panel27";
            this.panel27.Size = new System.Drawing.Size(489, 56);
            this.panel27.TabIndex = 5;
            // 
            // btn_ShowAccount
            // 
            this.btn_ShowAccount.Location = new System.Drawing.Point(382, 4);
            this.btn_ShowAccount.Name = "btn_ShowAccount";
            this.btn_ShowAccount.Size = new System.Drawing.Size(97, 49);
            this.btn_ShowAccount.TabIndex = 3;
            this.btn_ShowAccount.Text = "Xem";
            this.btn_ShowAccount.UseVisualStyleBackColor = true;
            this.btn_ShowAccount.Click += new System.EventHandler(this.btn_ShowAccount_Click);
            // 
            // btn_EditAccount
            // 
            this.btn_EditAccount.Location = new System.Drawing.Point(260, 4);
            this.btn_EditAccount.Name = "btn_EditAccount";
            this.btn_EditAccount.Size = new System.Drawing.Size(97, 49);
            this.btn_EditAccount.TabIndex = 2;
            this.btn_EditAccount.Text = "Sửa";
            this.btn_EditAccount.UseVisualStyleBackColor = true;
            this.btn_EditAccount.Click += new System.EventHandler(this.btn_EditAccount_Click);
            // 
            // btn_DeleteAccount
            // 
            this.btn_DeleteAccount.Location = new System.Drawing.Point(136, 4);
            this.btn_DeleteAccount.Name = "btn_DeleteAccount";
            this.btn_DeleteAccount.Size = new System.Drawing.Size(97, 49);
            this.btn_DeleteAccount.TabIndex = 1;
            this.btn_DeleteAccount.Text = "Xóa";
            this.btn_DeleteAccount.UseVisualStyleBackColor = true;
            this.btn_DeleteAccount.Click += new System.EventHandler(this.btn_DeleteAccount_Click);
            // 
            // btn_AddAccount
            // 
            this.btn_AddAccount.Location = new System.Drawing.Point(8, 4);
            this.btn_AddAccount.Name = "btn_AddAccount";
            this.btn_AddAccount.Size = new System.Drawing.Size(97, 49);
            this.btn_AddAccount.TabIndex = 0;
            this.btn_AddAccount.Text = "Thêm";
            this.btn_AddAccount.UseVisualStyleBackColor = true;
            this.btn_AddAccount.Click += new System.EventHandler(this.btn_AddAccount_Click);
            // 
            // panel28
            // 
            this.panel28.Controls.Add(this.dtgv_Account);
            this.panel28.Location = new System.Drawing.Point(10, 75);
            this.panel28.Name = "panel28";
            this.panel28.Size = new System.Drawing.Size(490, 435);
            this.panel28.TabIndex = 4;
            // 
            // dtgv_Account
            // 
            this.dtgv_Account.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_Account.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Account.Location = new System.Drawing.Point(8, 11);
            this.dtgv_Account.Name = "dtgv_Account";
            this.dtgv_Account.Size = new System.Drawing.Size(471, 413);
            this.dtgv_Account.TabIndex = 0;
            // 
            // tp_Food
            // 
            this.tp_Food.Controls.Add(this.panel10);
            this.tp_Food.Controls.Add(this.panel6);
            this.tp_Food.Controls.Add(this.panel5);
            this.tp_Food.Controls.Add(this.panel4);
            this.tp_Food.Controls.Add(this.panel3);
            this.tp_Food.Location = new System.Drawing.Point(4, 22);
            this.tp_Food.Name = "tp_Food";
            this.tp_Food.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Food.Size = new System.Drawing.Size(859, 517);
            this.tp_Food.TabIndex = 1;
            this.tp_Food.Text = "Thức ăn";
            this.tp_Food.UseVisualStyleBackColor = true;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.nm_FoodPrice);
            this.panel10.Controls.Add(this.label4);
            this.panel10.Location = new System.Drawing.Point(521, 281);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(319, 57);
            this.panel10.TabIndex = 3;
            // 
            // nm_FoodPrice
            // 
            this.nm_FoodPrice.Location = new System.Drawing.Point(110, 21);
            this.nm_FoodPrice.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nm_FoodPrice.Name = "nm_FoodPrice";
            this.nm_FoodPrice.Size = new System.Drawing.Size(120, 20);
            this.nm_FoodPrice.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 21);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(33, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giá";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txt_SearchFoodName);
            this.panel6.Controls.Add(this.btn_SearchFood);
            this.panel6.Location = new System.Drawing.Point(521, 13);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(332, 55);
            this.panel6.TabIndex = 3;
            // 
            // txt_SearchFoodName
            // 
            this.txt_SearchFoodName.Location = new System.Drawing.Point(21, 15);
            this.txt_SearchFoodName.Name = "txt_SearchFoodName";
            this.txt_SearchFoodName.Size = new System.Drawing.Size(201, 20);
            this.txt_SearchFoodName.TabIndex = 5;
            // 
            // btn_SearchFood
            // 
            this.btn_SearchFood.Location = new System.Drawing.Point(232, 3);
            this.btn_SearchFood.Name = "btn_SearchFood";
            this.btn_SearchFood.Size = new System.Drawing.Size(97, 49);
            this.btn_SearchFood.TabIndex = 4;
            this.btn_SearchFood.Text = "Tìm";
            this.btn_SearchFood.UseVisualStyleBackColor = true;
            this.btn_SearchFood.Click += new System.EventHandler(this.btn_SearchFood_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Location = new System.Drawing.Point(521, 81);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(332, 435);
            this.panel5.TabIndex = 2;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.cb_FoodCategory);
            this.panel9.Controls.Add(this.label3);
            this.panel9.Location = new System.Drawing.Point(3, 137);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(319, 57);
            this.panel9.TabIndex = 3;
            // 
            // cb_FoodCategory
            // 
            this.cb_FoodCategory.FormattingEnabled = true;
            this.cb_FoodCategory.Location = new System.Drawing.Point(107, 21);
            this.cb_FoodCategory.Name = "cb_FoodCategory";
            this.cb_FoodCategory.Size = new System.Drawing.Size(181, 21);
            this.cb_FoodCategory.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 21);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Danh mục";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txt_FoodName);
            this.panel8.Controls.Add(this.label2);
            this.panel8.Location = new System.Drawing.Point(3, 74);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(319, 57);
            this.panel8.TabIndex = 2;
            // 
            // txt_FoodName
            // 
            this.txt_FoodName.Location = new System.Drawing.Point(107, 18);
            this.txt_FoodName.Name = "txt_FoodName";
            this.txt_FoodName.Size = new System.Drawing.Size(181, 20);
            this.txt_FoodName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 21);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên món";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txt_FoodId);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Location = new System.Drawing.Point(3, 11);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(319, 57);
            this.panel7.TabIndex = 1;
            // 
            // txt_FoodId
            // 
            this.txt_FoodId.Location = new System.Drawing.Point(107, 18);
            this.txt_FoodId.Name = "txt_FoodId";
            this.txt_FoodId.ReadOnly = true;
            this.txt_FoodId.Size = new System.Drawing.Size(181, 20);
            this.txt_FoodId.TabIndex = 1;
            this.txt_FoodId.TextChanged += new System.EventHandler(this.txt_FoodId_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_ShowFood);
            this.panel4.Controls.Add(this.btn_EditFood);
            this.panel4.Controls.Add(this.btn_DeleteFood);
            this.panel4.Controls.Add(this.btn_AddFood);
            this.panel4.Location = new System.Drawing.Point(14, 13);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(489, 56);
            this.panel4.TabIndex = 1;
            // 
            // btn_ShowFood
            // 
            this.btn_ShowFood.Location = new System.Drawing.Point(382, 4);
            this.btn_ShowFood.Name = "btn_ShowFood";
            this.btn_ShowFood.Size = new System.Drawing.Size(97, 49);
            this.btn_ShowFood.TabIndex = 3;
            this.btn_ShowFood.Text = "Xem";
            this.btn_ShowFood.UseVisualStyleBackColor = true;
            this.btn_ShowFood.Click += new System.EventHandler(this.btn_ShowFood_Click);
            // 
            // btn_EditFood
            // 
            this.btn_EditFood.Location = new System.Drawing.Point(260, 4);
            this.btn_EditFood.Name = "btn_EditFood";
            this.btn_EditFood.Size = new System.Drawing.Size(97, 49);
            this.btn_EditFood.TabIndex = 2;
            this.btn_EditFood.Text = "Sửa";
            this.btn_EditFood.UseVisualStyleBackColor = true;
            this.btn_EditFood.Click += new System.EventHandler(this.btn_EditFood_Click);
            // 
            // btn_DeleteFood
            // 
            this.btn_DeleteFood.Location = new System.Drawing.Point(136, 4);
            this.btn_DeleteFood.Name = "btn_DeleteFood";
            this.btn_DeleteFood.Size = new System.Drawing.Size(97, 49);
            this.btn_DeleteFood.TabIndex = 1;
            this.btn_DeleteFood.Text = "Xóa";
            this.btn_DeleteFood.UseVisualStyleBackColor = true;
            this.btn_DeleteFood.Click += new System.EventHandler(this.btn_DeleteFood_Click);
            // 
            // btn_AddFood
            // 
            this.btn_AddFood.Location = new System.Drawing.Point(8, 4);
            this.btn_AddFood.Name = "btn_AddFood";
            this.btn_AddFood.Size = new System.Drawing.Size(97, 49);
            this.btn_AddFood.TabIndex = 0;
            this.btn_AddFood.Text = "Thêm";
            this.btn_AddFood.UseVisualStyleBackColor = true;
            this.btn_AddFood.Click += new System.EventHandler(this.btn_AddFood_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtgw_Food);
            this.panel3.Location = new System.Drawing.Point(14, 81);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(490, 435);
            this.panel3.TabIndex = 0;
            // 
            // dtgw_Food
            // 
            this.dtgw_Food.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgw_Food.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgw_Food.Location = new System.Drawing.Point(8, 11);
            this.dtgw_Food.Name = "dtgw_Food";
            this.dtgw_Food.Size = new System.Drawing.Size(471, 413);
            this.dtgw_Food.TabIndex = 0;
            // 
            // tp_Bill
            // 
            this.tp_Bill.Controls.Add(this.panel2);
            this.tp_Bill.Controls.Add(this.panel1);
            this.tp_Bill.Location = new System.Drawing.Point(4, 22);
            this.tp_Bill.Name = "tp_Bill";
            this.tp_Bill.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Bill.Size = new System.Drawing.Size(859, 517);
            this.tp_Bill.TabIndex = 0;
            this.tp_Bill.Text = "Doanh Thu";
            this.tp_Bill.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_ViewBill);
            this.panel2.Controls.Add(this.dtpk_ToDay);
            this.panel2.Controls.Add(this.dtpk_FromDay);
            this.panel2.Location = new System.Drawing.Point(10, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(846, 43);
            this.panel2.TabIndex = 1;
            // 
            // btn_ViewBill
            // 
            this.btn_ViewBill.Location = new System.Drawing.Point(354, 3);
            this.btn_ViewBill.Name = "btn_ViewBill";
            this.btn_ViewBill.Size = new System.Drawing.Size(130, 32);
            this.btn_ViewBill.TabIndex = 2;
            this.btn_ViewBill.Text = "Thống kê";
            this.btn_ViewBill.UseVisualStyleBackColor = true;
            this.btn_ViewBill.Click += new System.EventHandler(this.btn_ViewBill_Click);
            // 
            // dtpk_ToDay
            // 
            this.dtpk_ToDay.Location = new System.Drawing.Point(575, 12);
            this.dtpk_ToDay.Name = "dtpk_ToDay";
            this.dtpk_ToDay.Size = new System.Drawing.Size(218, 20);
            this.dtpk_ToDay.TabIndex = 1;
            // 
            // dtpk_FromDay
            // 
            this.dtpk_FromDay.Location = new System.Drawing.Point(15, 12);
            this.dtpk_FromDay.Name = "dtpk_FromDay";
            this.dtpk_FromDay.Size = new System.Drawing.Size(223, 20);
            this.dtpk_FromDay.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgv_Bill);
            this.panel1.Location = new System.Drawing.Point(7, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(846, 456);
            this.panel1.TabIndex = 0;
            // 
            // dtgv_Bill
            // 
            this.dtgv_Bill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_Bill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Bill.Location = new System.Drawing.Point(3, 3);
            this.dtgv_Bill.Name = "dtgv_Bill";
            this.dtgv_Bill.Size = new System.Drawing.Size(843, 453);
            this.dtgv_Bill.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tp_Bill);
            this.tabControl.Controls.Add(this.tp_Food);
            this.tabControl.Controls.Add(this.tp_Account);
            this.tabControl.Location = new System.Drawing.Point(26, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(867, 543);
            this.tabControl.TabIndex = 0;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 589);
            this.Controls.Add(this.tabControl);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.tp_Account.ResumeLayout(false);
            this.panel23.ResumeLayout(false);
            this.panel24.ResumeLayout(false);
            this.panel24.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nm_AccountType)).EndInit();
            this.panel25.ResumeLayout(false);
            this.panel25.PerformLayout();
            this.panel26.ResumeLayout(false);
            this.panel26.PerformLayout();
            this.panel27.ResumeLayout(false);
            this.panel28.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Account)).EndInit();
            this.tp_Food.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nm_FoodPrice)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgw_Food)).EndInit();
            this.tp_Bill.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Bill)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tp_Account;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.Button btn_ResetPassword;
        private System.Windows.Forms.Panel panel24;
        private System.Windows.Forms.NumericUpDown nm_AccountType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel25;
        private System.Windows.Forms.TextBox txt_DisplayName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel26;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel27;
        private System.Windows.Forms.Button btn_ShowAccount;
        private System.Windows.Forms.Button btn_EditAccount;
        private System.Windows.Forms.Button btn_DeleteAccount;
        private System.Windows.Forms.Button btn_AddAccount;
        private System.Windows.Forms.Panel panel28;
        private System.Windows.Forms.DataGridView dtgv_Account;
        private System.Windows.Forms.TabPage tp_Food;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.NumericUpDown nm_FoodPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txt_SearchFoodName;
        private System.Windows.Forms.Button btn_SearchFood;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.ComboBox cb_FoodCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txt_FoodName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txt_FoodId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_ShowFood;
        private System.Windows.Forms.Button btn_EditFood;
        private System.Windows.Forms.Button btn_DeleteFood;
        private System.Windows.Forms.Button btn_AddFood;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtgw_Food;
        private System.Windows.Forms.TabPage tp_Bill;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_ViewBill;
        private System.Windows.Forms.DateTimePicker dtpk_ToDay;
        private System.Windows.Forms.DateTimePicker dtpk_FromDay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgv_Bill;
        private System.Windows.Forms.TabControl tabControl;
    }
}