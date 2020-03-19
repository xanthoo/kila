namespace KILR_Project
{
    partial class AddEmployeesToDept
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEmployeesToDept));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRmvEmp = new System.Windows.Forms.Button();
            this.lbAddEmployees = new System.Windows.Forms.ListBox();
            this.btnAddEmp = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbAllEmployees = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Jupiterlbl = new System.Windows.Forms.Label();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFindEmployee = new System.Windows.Forms.TextBox();
            this.btnSearchEmp = new System.Windows.Forms.Button();
            this.btnCreateDep = new System.Windows.Forms.Button();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnRmvEmp);
            this.groupBox2.Controls.Add(this.lbAddEmployees);
            this.groupBox2.Controls.Add(this.btnAddEmp);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lbAllEmployees);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(157, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(546, 354);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Employees";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(329, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 21);
            this.label1.TabIndex = 27;
            this.label1.Text = "Added Employees";
            // 
            // btnRmvEmp
            // 
            this.btnRmvEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(3)))));
            this.btnRmvEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRmvEmp.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRmvEmp.Location = new System.Drawing.Point(229, 47);
            this.btnRmvEmp.Name = "btnRmvEmp";
            this.btnRmvEmp.Size = new System.Drawing.Size(88, 137);
            this.btnRmvEmp.TabIndex = 26;
            this.btnRmvEmp.Text = "<<<";
            this.btnRmvEmp.UseVisualStyleBackColor = false;
            // 
            // lbAddEmployees
            // 
            this.lbAddEmployees.FormattingEnabled = true;
            this.lbAddEmployees.Location = new System.Drawing.Point(333, 47);
            this.lbAddEmployees.Name = "lbAddEmployees";
            this.lbAddEmployees.Size = new System.Drawing.Size(207, 290);
            this.lbAddEmployees.TabIndex = 25;
            // 
            // btnAddEmp
            // 
            this.btnAddEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(3)))));
            this.btnAddEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEmp.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddEmp.Location = new System.Drawing.Point(229, 213);
            this.btnAddEmp.Name = "btnAddEmp";
            this.btnAddEmp.Size = new System.Drawing.Size(88, 137);
            this.btnAddEmp.TabIndex = 11;
            this.btnAddEmp.Text = ">>>";
            this.btnAddEmp.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 21);
            this.label4.TabIndex = 24;
            this.label4.Text = "Select Employees";
            // 
            // lbAllEmployees
            // 
            this.lbAllEmployees.FormattingEnabled = true;
            this.lbAllEmployees.Location = new System.Drawing.Point(6, 47);
            this.lbAllEmployees.Name = "lbAllEmployees";
            this.lbAllEmployees.Size = new System.Drawing.Size(207, 290);
            this.lbAllEmployees.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(3)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Jupiterlbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(717, 44);
            this.panel1.TabIndex = 27;
            // 
            // Jupiterlbl
            // 
            this.Jupiterlbl.AutoSize = true;
            this.Jupiterlbl.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Jupiterlbl.Location = new System.Drawing.Point(243, -5);
            this.Jupiterlbl.Name = "Jupiterlbl";
            this.Jupiterlbl.Size = new System.Drawing.Size(241, 45);
            this.Jupiterlbl.TabIndex = 6;
            this.Jupiterlbl.Text = "Add Employees";
            // 
            // gbSearch
            // 
            this.gbSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(121)))), ((int)(((byte)(3)))));
            this.gbSearch.Controls.Add(this.label2);
            this.gbSearch.Controls.Add(this.tbFindEmployee);
            this.gbSearch.Controls.Add(this.btnSearchEmp);
            this.gbSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbSearch.Location = new System.Drawing.Point(6, 50);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(145, 168);
            this.gbSearch.TabIndex = 28;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Search for an Employee";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Employee number:";
            // 
            // tbFindEmployee
            // 
            this.tbFindEmployee.Location = new System.Drawing.Point(22, 65);
            this.tbFindEmployee.Name = "tbFindEmployee";
            this.tbFindEmployee.Size = new System.Drawing.Size(105, 23);
            this.tbFindEmployee.TabIndex = 7;
            // 
            // btnSearchEmp
            // 
            this.btnSearchEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(3)))));
            this.btnSearchEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchEmp.Location = new System.Drawing.Point(22, 99);
            this.btnSearchEmp.Name = "btnSearchEmp";
            this.btnSearchEmp.Size = new System.Drawing.Size(105, 40);
            this.btnSearchEmp.TabIndex = 5;
            this.btnSearchEmp.Text = "Search";
            this.btnSearchEmp.UseVisualStyleBackColor = false;
            this.btnSearchEmp.Click += new System.EventHandler(this.Button5_Click);
            // 
            // btnCreateDep
            // 
            this.btnCreateDep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(3)))));
            this.btnCreateDep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateDep.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreateDep.Location = new System.Drawing.Point(163, 406);
            this.btnCreateDep.Name = "btnCreateDep";
            this.btnCreateDep.Size = new System.Drawing.Size(540, 84);
            this.btnCreateDep.TabIndex = 29;
            this.btnCreateDep.Text = "Create Department\r\n";
            this.btnCreateDep.UseVisualStyleBackColor = false;
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(3)))));
            this.btnGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoBack.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGoBack.Location = new System.Drawing.Point(6, 224);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(145, 266);
            this.btnGoBack.TabIndex = 28;
            this.btnGoBack.Text = "Go Back";
            this.btnGoBack.UseVisualStyleBackColor = false;
            // 
            // AddEmployeesToDept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(121)))), ((int)(((byte)(3)))));
            this.ClientSize = new System.Drawing.Size(717, 498);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.btnCreateDep);
            this.Controls.Add(this.gbSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddEmployeesToDept";
            this.Text = "S";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRmvEmp;
        private System.Windows.Forms.ListBox lbAddEmployees;
        private System.Windows.Forms.Button btnAddEmp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbAllEmployees;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Jupiterlbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFindEmployee;
        private System.Windows.Forms.Button btnSearchEmp;
        private System.Windows.Forms.Button btnCreateDep;
        private System.Windows.Forms.Button btnGoBack;
    }
}