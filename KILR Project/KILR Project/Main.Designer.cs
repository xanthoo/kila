namespace KILR_Project
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.employeesPage = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbAdmin = new System.Windows.Forms.RadioButton();
            this.rbEmployees = new System.Windows.Forms.RadioButton();
            this.rbManagers = new System.Windows.Forms.RadioButton();
            this.btnFilter = new System.Windows.Forms.Button();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.Jupiterlbl = new System.Windows.Forms.Label();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.btnEmpInfo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFindEmployee = new System.Windows.Forms.TextBox();
            this.lbEmployees = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbHWage = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbDep = new System.Windows.Forms.ComboBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.tbFName = new System.Windows.Forms.TextBox();
            this.shiftLbl = new System.Windows.Forms.Label();
            this.departmentLbl = new System.Windows.Forms.Label();
            this.lastNamelbl = new System.Windows.Forms.Label();
            this.firstNamelbl = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.stockPage = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnFilterStock = new System.Windows.Forms.Button();
            this.cbInactive = new System.Windows.Forms.CheckBox();
            this.cbActive = new System.Windows.Forms.CheckBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbStockBuying = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbStockPrice = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbStockQuantity = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbStockName = new System.Windows.Forms.TextBox();
            this.stockNameLbl = new System.Windows.Forms.Label();
            this.btnAddStock = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbStockAmount = new System.Windows.Forms.TextBox();
            this.btnSell = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            this.stockIDlb = new System.Windows.Forms.Label();
            this.tbFindStock = new System.Windows.Forms.TextBox();
            this.btnStockInfo = new System.Windows.Forms.Button();
            this.lbStock = new System.Windows.Forms.ListBox();
            this.Stock = new System.Windows.Forms.Panel();
            this.Stocklbl = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.lbDepartments = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.statisticsPage = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPostition = new System.Windows.Forms.ComboBox();
            this.cbShift = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.employeesPage.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            this.gbSearch.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.stockPage.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Stock.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.statisticsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.employeesPage);
            this.tabControl1.Controls.Add(this.stockPage);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.statisticsPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(933, 515);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // employeesPage
            // 
            this.employeesPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(121)))), ((int)(((byte)(3)))));
            this.employeesPage.Controls.Add(this.groupBox4);
            this.employeesPage.Controls.Add(this.HeaderPanel);
            this.employeesPage.Controls.Add(this.gbSearch);
            this.employeesPage.Controls.Add(this.lbEmployees);
            this.employeesPage.Controls.Add(this.groupBox2);
            this.employeesPage.Location = new System.Drawing.Point(4, 27);
            this.employeesPage.Name = "employeesPage";
            this.employeesPage.Padding = new System.Windows.Forms.Padding(3);
            this.employeesPage.Size = new System.Drawing.Size(925, 484);
            this.employeesPage.TabIndex = 0;
            this.employeesPage.Text = "Employees";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbAdmin);
            this.groupBox4.Controls.Add(this.rbEmployees);
            this.groupBox4.Controls.Add(this.rbManagers);
            this.groupBox4.Controls.Add(this.btnFilter);
            this.groupBox4.Location = new System.Drawing.Point(237, 292);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(192, 175);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Filter by Job Position";
            // 
            // rbAdmin
            // 
            this.rbAdmin.AutoSize = true;
            this.rbAdmin.Location = new System.Drawing.Point(33, 89);
            this.rbAdmin.Name = "rbAdmin";
            this.rbAdmin.Size = new System.Drawing.Size(104, 19);
            this.rbAdmin.TabIndex = 20;
            this.rbAdmin.TabStop = true;
            this.rbAdmin.Text = "Administration";
            this.rbAdmin.UseVisualStyleBackColor = true;
            // 
            // rbEmployees
            // 
            this.rbEmployees.AutoSize = true;
            this.rbEmployees.Location = new System.Drawing.Point(33, 59);
            this.rbEmployees.Name = "rbEmployees";
            this.rbEmployees.Size = new System.Drawing.Size(82, 19);
            this.rbEmployees.TabIndex = 19;
            this.rbEmployees.TabStop = true;
            this.rbEmployees.Text = "Employees";
            this.rbEmployees.UseVisualStyleBackColor = true;
            // 
            // rbManagers
            // 
            this.rbManagers.AutoSize = true;
            this.rbManagers.Location = new System.Drawing.Point(33, 29);
            this.rbManagers.Name = "rbManagers";
            this.rbManagers.Size = new System.Drawing.Size(77, 19);
            this.rbManagers.TabIndex = 18;
            this.rbManagers.TabStop = true;
            this.rbManagers.Text = "Managers";
            this.rbManagers.UseVisualStyleBackColor = true;
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(3)))));
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Location = new System.Drawing.Point(33, 124);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(130, 45);
            this.btnFilter.TabIndex = 11;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = false;
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(3)))));
            this.HeaderPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HeaderPanel.Controls.Add(this.Jupiterlbl);
            this.HeaderPanel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(929, 49);
            this.HeaderPanel.TabIndex = 13;
            this.HeaderPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.HeaderPanel_Paint);
            // 
            // Jupiterlbl
            // 
            this.Jupiterlbl.AutoSize = true;
            this.Jupiterlbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(3)))));
            this.Jupiterlbl.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Jupiterlbl.Location = new System.Drawing.Point(355, -1);
            this.Jupiterlbl.Name = "Jupiterlbl";
            this.Jupiterlbl.Size = new System.Drawing.Size(173, 45);
            this.Jupiterlbl.TabIndex = 10;
            this.Jupiterlbl.Text = "Employees";
            // 
            // gbSearch
            // 
            this.gbSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(121)))), ((int)(((byte)(3)))));
            this.gbSearch.Controls.Add(this.btnEmpInfo);
            this.gbSearch.Controls.Add(this.label1);
            this.gbSearch.Controls.Add(this.tbFindEmployee);
            this.gbSearch.Location = new System.Drawing.Point(8, 292);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(192, 175);
            this.gbSearch.TabIndex = 11;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Search by Employee number";
            // 
            // btnEmpInfo
            // 
            this.btnEmpInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(3)))));
            this.btnEmpInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpInfo.Location = new System.Drawing.Point(31, 70);
            this.btnEmpInfo.Name = "btnEmpInfo";
            this.btnEmpInfo.Size = new System.Drawing.Size(130, 99);
            this.btnEmpInfo.TabIndex = 9;
            this.btnEmpInfo.Text = "Employee Information";
            this.btnEmpInfo.UseVisualStyleBackColor = false;
            this.btnEmpInfo.Click += new System.EventHandler(this.btnEmpInfo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Employee number:";
            // 
            // tbFindEmployee
            // 
            this.tbFindEmployee.Location = new System.Drawing.Point(31, 41);
            this.tbFindEmployee.Name = "tbFindEmployee";
            this.tbFindEmployee.Size = new System.Drawing.Size(132, 23);
            this.tbFindEmployee.TabIndex = 7;
            // 
            // lbEmployees
            // 
            this.lbEmployees.FormattingEnabled = true;
            this.lbEmployees.ItemHeight = 15;
            this.lbEmployees.Location = new System.Drawing.Point(433, 58);
            this.lbEmployees.Name = "lbEmployees";
            this.lbEmployees.Size = new System.Drawing.Size(484, 394);
            this.lbEmployees.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(121)))), ((int)(((byte)(3)))));
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox2.Controls.Add(this.cbShift);
            this.groupBox2.Controls.Add(this.cbPostition);
            this.groupBox2.Controls.Add(this.tbHWage);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbEmail);
            this.groupBox2.Controls.Add(this.tbAddress);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cbDep);
            this.groupBox2.Controls.Add(this.tbSurname);
            this.groupBox2.Controls.Add(this.tbFName);
            this.groupBox2.Controls.Add(this.shiftLbl);
            this.groupBox2.Controls.Add(this.departmentLbl);
            this.groupBox2.Controls.Add(this.lastNamelbl);
            this.groupBox2.Controls.Add(this.firstNamelbl);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(8, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(421, 228);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Employee";
            // 
            // tbHWage
            // 
            this.tbHWage.Location = new System.Drawing.Point(87, 177);
            this.tbHWage.Name = "tbHWage";
            this.tbHWage.Size = new System.Drawing.Size(123, 23);
            this.tbHWage.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(22, 181);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 17);
            this.label12.TabIndex = 20;
            this.label12.Text = "HWage:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(22, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Position:";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(290, 66);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(123, 23);
            this.tbEmail.TabIndex = 15;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(290, 33);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(123, 23);
            this.tbAddress.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(242, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Email:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(233, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Address:";
            // 
            // cbDep
            // 
            this.cbDep.FormattingEnabled = true;
            this.cbDep.Location = new System.Drawing.Point(87, 103);
            this.cbDep.Name = "cbDep";
            this.cbDep.Size = new System.Drawing.Size(123, 23);
            this.cbDep.TabIndex = 9;
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(87, 66);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(123, 23);
            this.tbSurname.TabIndex = 10;
            // 
            // tbFName
            // 
            this.tbFName.Location = new System.Drawing.Point(87, 33);
            this.tbFName.Name = "tbFName";
            this.tbFName.Size = new System.Drawing.Size(123, 23);
            this.tbFName.TabIndex = 9;
            // 
            // shiftLbl
            // 
            this.shiftLbl.AutoSize = true;
            this.shiftLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.shiftLbl.Location = new System.Drawing.Point(248, 103);
            this.shiftLbl.Name = "shiftLbl";
            this.shiftLbl.Size = new System.Drawing.Size(38, 17);
            this.shiftLbl.TabIndex = 8;
            this.shiftLbl.Text = "Shift:";
            // 
            // departmentLbl
            // 
            this.departmentLbl.AutoSize = true;
            this.departmentLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.departmentLbl.Location = new System.Drawing.Point(1, 103);
            this.departmentLbl.Name = "departmentLbl";
            this.departmentLbl.Size = new System.Drawing.Size(84, 17);
            this.departmentLbl.TabIndex = 7;
            this.departmentLbl.Text = "Department:";
            // 
            // lastNamelbl
            // 
            this.lastNamelbl.AutoSize = true;
            this.lastNamelbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastNamelbl.Location = new System.Drawing.Point(6, 67);
            this.lastNamelbl.Name = "lastNamelbl";
            this.lastNamelbl.Size = new System.Drawing.Size(75, 17);
            this.lastNamelbl.TabIndex = 6;
            this.lastNamelbl.Text = "Last Name:";
            // 
            // firstNamelbl
            // 
            this.firstNamelbl.AutoSize = true;
            this.firstNamelbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstNamelbl.Location = new System.Drawing.Point(7, 33);
            this.firstNamelbl.Name = "firstNamelbl";
            this.firstNamelbl.Size = new System.Drawing.Size(77, 17);
            this.firstNamelbl.TabIndex = 5;
            this.firstNamelbl.Text = "First Name:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(3)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(292, 155);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(124, 45);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.Button4_Click);
            // 
            // stockPage
            // 
            this.stockPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(121)))), ((int)(((byte)(3)))));
            this.stockPage.Controls.Add(this.groupBox6);
            this.stockPage.Controls.Add(this.btnRefresh);
            this.stockPage.Controls.Add(this.groupBox3);
            this.stockPage.Controls.Add(this.groupBox1);
            this.stockPage.Controls.Add(this.lbStock);
            this.stockPage.Controls.Add(this.Stock);
            this.stockPage.Location = new System.Drawing.Point(4, 27);
            this.stockPage.Name = "stockPage";
            this.stockPage.Padding = new System.Windows.Forms.Padding(3);
            this.stockPage.Size = new System.Drawing.Size(925, 484);
            this.stockPage.TabIndex = 1;
            this.stockPage.Text = "Stock";
            this.stockPage.Click += new System.EventHandler(this.StockPage_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnFilterStock);
            this.groupBox6.Controls.Add(this.cbInactive);
            this.groupBox6.Controls.Add(this.cbActive);
            this.groupBox6.Location = new System.Drawing.Point(40, 343);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(192, 135);
            this.groupBox6.TabIndex = 18;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Filter by Product Activity";
            // 
            // btnFilterStock
            // 
            this.btnFilterStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(3)))));
            this.btnFilterStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterStock.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFilterStock.Location = new System.Drawing.Point(32, 84);
            this.btnFilterStock.Name = "btnFilterStock";
            this.btnFilterStock.Size = new System.Drawing.Size(130, 45);
            this.btnFilterStock.TabIndex = 11;
            this.btnFilterStock.Text = "Filter";
            this.btnFilterStock.UseVisualStyleBackColor = false;
            this.btnFilterStock.Click += new System.EventHandler(this.BtnFilterStock_Click);
            // 
            // cbInactive
            // 
            this.cbInactive.AutoSize = true;
            this.cbInactive.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbInactive.Location = new System.Drawing.Point(33, 57);
            this.cbInactive.Name = "cbInactive";
            this.cbInactive.Size = new System.Drawing.Size(81, 24);
            this.cbInactive.TabIndex = 1;
            this.cbInactive.Text = "Inactive";
            this.cbInactive.UseVisualStyleBackColor = true;
            // 
            // cbActive
            // 
            this.cbActive.AutoSize = true;
            this.cbActive.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbActive.Location = new System.Drawing.Point(33, 27);
            this.cbActive.Name = "cbActive";
            this.cbActive.Size = new System.Drawing.Size(70, 24);
            this.cbActive.TabIndex = 0;
            this.cbActive.Text = "Active";
            this.cbActive.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(3)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRefresh.Location = new System.Drawing.Point(299, 427);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(337, 51);
            this.btnRefresh.TabIndex = 13;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(121)))), ((int)(((byte)(3)))));
            this.groupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox3.Controls.Add(this.tbStockBuying);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.tbStockPrice);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.tbStockQuantity);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.tbStockName);
            this.groupBox3.Controls.Add(this.stockNameLbl);
            this.groupBox3.Controls.Add(this.btnAddStock);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Location = new System.Drawing.Point(40, 66);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(253, 264);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add Stock";
            // 
            // tbStockBuying
            // 
            this.tbStockBuying.Location = new System.Drawing.Point(122, 139);
            this.tbStockBuying.Name = "tbStockBuying";
            this.tbStockBuying.Size = new System.Drawing.Size(124, 23);
            this.tbStockBuying.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(11, 139);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 17);
            this.label13.TabIndex = 22;
            this.label13.Text = "Buying Price:\r\n";
            // 
            // tbStockPrice
            // 
            this.tbStockPrice.Location = new System.Drawing.Point(122, 103);
            this.tbStockPrice.Name = "tbStockPrice";
            this.tbStockPrice.Size = new System.Drawing.Size(123, 23);
            this.tbStockPrice.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(14, 103);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 17);
            this.label14.TabIndex = 20;
            this.label14.Text = "Selling Price:";
            // 
            // tbStockQuantity
            // 
            this.tbStockQuantity.Location = new System.Drawing.Point(123, 69);
            this.tbStockQuantity.Name = "tbStockQuantity";
            this.tbStockQuantity.Size = new System.Drawing.Size(124, 23);
            this.tbStockQuantity.TabIndex = 15;
            this.tbStockQuantity.TextChanged += new System.EventHandler(this.TextBox5_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(33, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Quantity:";
            // 
            // tbStockName
            // 
            this.tbStockName.Location = new System.Drawing.Point(123, 33);
            this.tbStockName.Name = "tbStockName";
            this.tbStockName.Size = new System.Drawing.Size(123, 23);
            this.tbStockName.TabIndex = 9;
            // 
            // stockNameLbl
            // 
            this.stockNameLbl.AutoSize = true;
            this.stockNameLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stockNameLbl.Location = new System.Drawing.Point(50, 33);
            this.stockNameLbl.Name = "stockNameLbl";
            this.stockNameLbl.Size = new System.Drawing.Size(47, 17);
            this.stockNameLbl.TabIndex = 5;
            this.stockNameLbl.Text = "Name:";
            // 
            // btnAddStock
            // 
            this.btnAddStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(3)))));
            this.btnAddStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStock.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddStock.Location = new System.Drawing.Point(18, 182);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Size = new System.Drawing.Size(229, 66);
            this.btnAddStock.TabIndex = 4;
            this.btnAddStock.Text = "Add";
            this.btnAddStock.UseVisualStyleBackColor = false;
            this.btnAddStock.Click += new System.EventHandler(this.BtnAddStock_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(121)))), ((int)(((byte)(3)))));
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbStockAmount);
            this.groupBox1.Controls.Add(this.btnSell);
            this.groupBox1.Controls.Add(this.btnBuy);
            this.groupBox1.Controls.Add(this.stockIDlb);
            this.groupBox1.Controls.Add(this.tbFindStock);
            this.groupBox1.Controls.Add(this.btnStockInfo);
            this.groupBox1.Location = new System.Drawing.Point(652, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 349);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manipulate Stock";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(87, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "Quantity";
            // 
            // tbStockAmount
            // 
            this.tbStockAmount.Location = new System.Drawing.Point(38, 165);
            this.tbStockAmount.Name = "tbStockAmount";
            this.tbStockAmount.Size = new System.Drawing.Size(171, 23);
            this.tbStockAmount.TabIndex = 11;
            // 
            // btnSell
            // 
            this.btnSell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(3)))));
            this.btnSell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSell.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSell.Location = new System.Drawing.Point(8, 284);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(239, 51);
            this.btnSell.TabIndex = 10;
            this.btnSell.Text = "Increase";
            this.btnSell.UseVisualStyleBackColor = false;
            this.btnSell.Click += new System.EventHandler(this.BtnSell_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(3)))));
            this.btnBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuy.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBuy.Location = new System.Drawing.Point(8, 213);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(239, 51);
            this.btnBuy.TabIndex = 9;
            this.btnBuy.Text = "Decrease";
            this.btnBuy.UseVisualStyleBackColor = false;
            this.btnBuy.Click += new System.EventHandler(this.BtnBuy_Click);
            // 
            // stockIDlb
            // 
            this.stockIDlb.AutoSize = true;
            this.stockIDlb.Location = new System.Drawing.Point(13, 37);
            this.stockIDlb.Name = "stockIDlb";
            this.stockIDlb.Size = new System.Drawing.Size(56, 15);
            this.stockIDlb.TabIndex = 8;
            this.stockIDlb.Text = "Stock ID:";
            // 
            // tbFindStock
            // 
            this.tbFindStock.Location = new System.Drawing.Point(75, 34);
            this.tbFindStock.Name = "tbFindStock";
            this.tbFindStock.Size = new System.Drawing.Size(171, 23);
            this.tbFindStock.TabIndex = 7;
            // 
            // btnStockInfo
            // 
            this.btnStockInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(3)))));
            this.btnStockInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStockInfo.Location = new System.Drawing.Point(6, 76);
            this.btnStockInfo.Name = "btnStockInfo";
            this.btnStockInfo.Size = new System.Drawing.Size(241, 51);
            this.btnStockInfo.TabIndex = 6;
            this.btnStockInfo.Text = "Stock Information";
            this.btnStockInfo.UseVisualStyleBackColor = false;
            this.btnStockInfo.Click += new System.EventHandler(this.BtnStockInfo_Click);
            // 
            // lbStock
            // 
            this.lbStock.FormattingEnabled = true;
            this.lbStock.ItemHeight = 15;
            this.lbStock.Location = new System.Drawing.Point(299, 66);
            this.lbStock.Name = "lbStock";
            this.lbStock.Size = new System.Drawing.Size(337, 349);
            this.lbStock.TabIndex = 15;
            // 
            // Stock
            // 
            this.Stock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(3)))));
            this.Stock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Stock.Controls.Add(this.Stocklbl);
            this.Stock.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Stock.Location = new System.Drawing.Point(0, 0);
            this.Stock.Name = "Stock";
            this.Stock.Size = new System.Drawing.Size(925, 49);
            this.Stock.TabIndex = 14;
            // 
            // Stocklbl
            // 
            this.Stocklbl.AutoSize = true;
            this.Stocklbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(3)))));
            this.Stocklbl.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Stocklbl.Location = new System.Drawing.Point(396, 0);
            this.Stocklbl.Name = "Stocklbl";
            this.Stocklbl.Size = new System.Drawing.Size(97, 45);
            this.Stocklbl.TabIndex = 10;
            this.Stocklbl.Text = "Stock";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(121)))), ((int)(((byte)(3)))));
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.lbDepartments);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(925, 484);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Departments";
            this.tabPage1.Click += new System.EventHandler(this.TabPage1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(3)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(36, 328);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(377, 133);
            this.button2.TabIndex = 10;
            this.button2.Text = "Create Department\r\n";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(121)))), ((int)(((byte)(3)))));
            this.groupBox5.Controls.Add(this.button7);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.textBox8);
            this.groupBox5.Location = new System.Drawing.Point(454, 328);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(353, 133);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Search by Deparment name or number";
            this.groupBox5.Enter += new System.EventHandler(this.GroupBox5_Enter);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(3)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(184, 37);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(163, 78);
            this.button7.TabIndex = 20;
            this.button7.Text = "Department Information";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Department Name\r\n";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(23, 67);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(142, 23);
            this.textBox8.TabIndex = 9;
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // lbDepartments
            // 
            this.lbDepartments.FormattingEnabled = true;
            this.lbDepartments.ItemHeight = 15;
            this.lbDepartments.Location = new System.Drawing.Point(36, 67);
            this.lbDepartments.Name = "lbDepartments";
            this.lbDepartments.Size = new System.Drawing.Size(855, 244);
            this.lbDepartments.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(3)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label6);
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(925, 48);
            this.panel2.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(3)))));
            this.label6.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(348, -2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 45);
            this.label6.TabIndex = 10;
            this.label6.Text = "Departments";
            // 
            // statisticsPage
            // 
            this.statisticsPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(121)))), ((int)(((byte)(3)))));
            this.statisticsPage.Controls.Add(this.pictureBox1);
            this.statisticsPage.Controls.Add(this.panel1);
            this.statisticsPage.Location = new System.Drawing.Point(4, 27);
            this.statisticsPage.Name = "statisticsPage";
            this.statisticsPage.Size = new System.Drawing.Size(925, 484);
            this.statisticsPage.TabIndex = 2;
            this.statisticsPage.Text = "Statistics";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(192, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(526, 253);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(3)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(925, 49);
            this.panel1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(3)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(355, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 45);
            this.label2.TabIndex = 10;
            this.label2.Text = "Statistics";
            // 
            // cbPostition
            // 
            this.cbPostition.FormattingEnabled = true;
            this.cbPostition.Items.AddRange(new object[] {
            "Employee",
            "Manager",
            "Administrator"});
            this.cbPostition.Location = new System.Drawing.Point(87, 136);
            this.cbPostition.Name = "cbPostition";
            this.cbPostition.Size = new System.Drawing.Size(123, 23);
            this.cbPostition.TabIndex = 22;
            // 
            // cbShift
            // 
            this.cbShift.FormattingEnabled = true;
            this.cbShift.Items.AddRange(new object[] {
            "Night",
            "Day",
            "Afternoon"});
            this.cbShift.Location = new System.Drawing.Point(290, 103);
            this.cbShift.Name = "cbShift";
            this.cbShift.Size = new System.Drawing.Size(123, 23);
            this.cbShift.TabIndex = 23;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Jupiter Control App";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl1.ResumeLayout(false);
            this.employeesPage.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.stockPage.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Stock.ResumeLayout(false);
            this.Stock.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.statisticsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage employeesPage;
        private System.Windows.Forms.TabPage stockPage;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Label Jupiterlbl;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFindEmployee;
        private System.Windows.Forms.ListBox lbEmployees;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbDep;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.TextBox tbFName;
        private System.Windows.Forms.Label shiftLbl;
        private System.Windows.Forms.Label departmentLbl;
        private System.Windows.Forms.Label lastNamelbl;
        private System.Windows.Forms.Label firstNamelbl;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lbStock;
        private System.Windows.Forms.Panel Stock;
        private System.Windows.Forms.Label Stocklbl;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbStockName;
        private System.Windows.Forms.Label stockNameLbl;
        private System.Windows.Forms.Button btnAddStock;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label stockIDlb;
        private System.Windows.Forms.TextBox tbFindStock;
        private System.Windows.Forms.Button btnStockInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage statisticsPage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEmpInfo;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbStockQuantity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox8;
        public System.Windows.Forms.ListBox lbDepartments;
        private System.Windows.Forms.TextBox tbStockBuying;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbStockPrice;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbStockAmount;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnFilterStock;
        private System.Windows.Forms.CheckBox cbInactive;
        private System.Windows.Forms.CheckBox cbActive;
        private System.Windows.Forms.RadioButton rbAdmin;
        private System.Windows.Forms.RadioButton rbEmployees;
        private System.Windows.Forms.RadioButton rbManagers;
        private System.Windows.Forms.TextBox tbHWage;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbPostition;
        private System.Windows.Forms.ComboBox cbShift;
    }
}

