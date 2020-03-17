namespace KILR_Project
{
    partial class DepartmentInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartmentInformation));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Jupiterlbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDepartmentName = new System.Windows.Forms.Label();
            this.lbDepEmps = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.btnEmpInfo = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.tbFindEmployee = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.chkbxEmps = new System.Windows.Forms.CheckBox();
            this.chkbxAdmin = new System.Windows.Forms.CheckBox();
            this.chckbxMngrs = new System.Windows.Forms.CheckBox();
            this.btnEditDep = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbSearch.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(3)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Jupiterlbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(709, 76);
            this.panel1.TabIndex = 30;
            // 
            // Jupiterlbl
            // 
            this.Jupiterlbl.AutoSize = true;
            this.Jupiterlbl.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Jupiterlbl.Location = new System.Drawing.Point(167, 8);
            this.Jupiterlbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Jupiterlbl.Name = "Jupiterlbl";
            this.Jupiterlbl.Size = new System.Drawing.Size(366, 45);
            this.Jupiterlbl.TabIndex = 6;
            this.Jupiterlbl.Text = "Department Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(271, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 30);
            this.label1.TabIndex = 32;
            this.label1.Text = "ID";
            // 
            // lblDepartmentName
            // 
            this.lblDepartmentName.AutoSize = true;
            this.lblDepartmentName.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDepartmentName.Location = new System.Drawing.Point(254, 0);
            this.lblDepartmentName.Name = "lblDepartmentName";
            this.lblDepartmentName.Size = new System.Drawing.Size(220, 32);
            this.lblDepartmentName.TabIndex = 31;
            this.lblDepartmentName.Text = "Department Name";
            // 
            // lbDepEmps
            // 
            this.lbDepEmps.FormattingEnabled = true;
            this.lbDepEmps.ItemHeight = 17;
            this.lbDepEmps.Location = new System.Drawing.Point(415, 172);
            this.lbDepEmps.Name = "lbDepEmps";
            this.lbDepEmps.Size = new System.Drawing.Size(280, 361);
            this.lbDepEmps.TabIndex = 33;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblDepartmentName);
            this.panel2.Location = new System.Drawing.Point(0, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(856, 66);
            this.panel2.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(410, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 25);
            this.label2.TabIndex = 33;
            this.label2.Text = "Employees in this department";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(27, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 21);
            this.label3.TabIndex = 35;
            this.label3.Text = "Maximum amount of staff:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(246, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 36;
            this.label4.Text = "Amount";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 172);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 195);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Department details";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(235, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 17);
            this.label6.TabIndex = 38;
            this.label6.Text = "Text";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(121, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 21);
            this.label5.TabIndex = 37;
            this.label5.Text = "Date Created:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(246, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 17);
            this.label8.TabIndex = 40;
            this.label8.Text = "Amount";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(132, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 21);
            this.label7.TabIndex = 39;
            this.label7.Text = "Manager ID:";
            // 
            // gbSearch
            // 
            this.gbSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(121)))), ((int)(((byte)(3)))));
            this.gbSearch.Controls.Add(this.btnEmpInfo);
            this.gbSearch.Controls.Add(this.label11);
            this.gbSearch.Controls.Add(this.tbFindEmployee);
            this.gbSearch.Location = new System.Drawing.Point(12, 373);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(180, 175);
            this.gbSearch.TabIndex = 43;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Search for Employee";
            // 
            // btnEmpInfo
            // 
            this.btnEmpInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(3)))));
            this.btnEmpInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpInfo.Location = new System.Drawing.Point(31, 76);
            this.btnEmpInfo.Name = "btnEmpInfo";
            this.btnEmpInfo.Size = new System.Drawing.Size(130, 93);
            this.btnEmpInfo.TabIndex = 9;
            this.btnEmpInfo.Text = "Employee Information";
            this.btnEmpInfo.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(38, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 17);
            this.label11.TabIndex = 8;
            this.label11.Text = "Employee number:";
            // 
            // tbFindEmployee
            // 
            this.tbFindEmployee.Location = new System.Drawing.Point(31, 41);
            this.tbFindEmployee.Name = "tbFindEmployee";
            this.tbFindEmployee.Size = new System.Drawing.Size(132, 25);
            this.tbFindEmployee.TabIndex = 7;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnFilter);
            this.groupBox4.Controls.Add(this.chkbxEmps);
            this.groupBox4.Controls.Add(this.chkbxAdmin);
            this.groupBox4.Controls.Add(this.chckbxMngrs);
            this.groupBox4.Location = new System.Drawing.Point(198, 373);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(192, 175);
            this.groupBox4.TabIndex = 44;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Filter by Job Position";
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
            // chkbxEmps
            // 
            this.chkbxEmps.AutoSize = true;
            this.chkbxEmps.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkbxEmps.Location = new System.Drawing.Point(33, 87);
            this.chkbxEmps.Name = "chkbxEmps";
            this.chkbxEmps.Size = new System.Drawing.Size(101, 24);
            this.chkbxEmps.TabIndex = 2;
            this.chkbxEmps.Text = "Employees";
            this.chkbxEmps.UseVisualStyleBackColor = true;
            // 
            // chkbxAdmin
            // 
            this.chkbxAdmin.AutoSize = true;
            this.chkbxAdmin.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkbxAdmin.Location = new System.Drawing.Point(33, 57);
            this.chkbxAdmin.Name = "chkbxAdmin";
            this.chkbxAdmin.Size = new System.Drawing.Size(129, 24);
            this.chkbxAdmin.TabIndex = 1;
            this.chkbxAdmin.Text = "Administration";
            this.chkbxAdmin.UseVisualStyleBackColor = true;
            // 
            // chckbxMngrs
            // 
            this.chckbxMngrs.AutoSize = true;
            this.chckbxMngrs.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chckbxMngrs.Location = new System.Drawing.Point(33, 27);
            this.chckbxMngrs.Name = "chckbxMngrs";
            this.chckbxMngrs.Size = new System.Drawing.Size(96, 24);
            this.chckbxMngrs.TabIndex = 0;
            this.chckbxMngrs.Text = "Managers";
            this.chckbxMngrs.UseVisualStyleBackColor = true;
            // 
            // btnEditDep
            // 
            this.btnEditDep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(3)))));
            this.btnEditDep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditDep.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditDep.Location = new System.Drawing.Point(415, 556);
            this.btnEditDep.Name = "btnEditDep";
            this.btnEditDep.Size = new System.Drawing.Size(280, 75);
            this.btnEditDep.TabIndex = 45;
            this.btnEditDep.Text = "Edit Department Details";
            this.btnEditDep.UseVisualStyleBackColor = false;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(3)))));
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRemove.Location = new System.Drawing.Point(129, 556);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(280, 75);
            this.btnRemove.TabIndex = 46;
            this.btnRemove.Text = "Remove Department";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(3)))));
            this.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGo.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGo.Location = new System.Drawing.Point(12, 556);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(114, 75);
            this.btnGo.TabIndex = 47;
            this.btnGo.Text = "Go Back";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // DepartmentInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(121)))), ((int)(((byte)(3)))));
            this.ClientSize = new System.Drawing.Size(709, 635);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnEditDep);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.gbSearch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbDepEmps);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DepartmentInformation";
            this.Text = "Department Information";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Jupiterlbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbDepEmps;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.Button btnEmpInfo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbFindEmployee;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.CheckBox chkbxEmps;
        private System.Windows.Forms.CheckBox chkbxAdmin;
        private System.Windows.Forms.CheckBox chckbxMngrs;
        private System.Windows.Forms.Button btnEditDep;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnGo;
        public System.Windows.Forms.Label lblDepartmentName;
    }
}