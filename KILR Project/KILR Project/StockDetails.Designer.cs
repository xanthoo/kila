namespace KILR_Project
{
    partial class StockDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockDetails));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRestockRequest = new System.Windows.Forms.Label();
            this.Jupiterlbl = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblMinAmount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.quantitylbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pricelbl = new System.Windows.Forms.Label();
            this.buyingLbl = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.stockNameLbl = new System.Windows.Forms.Label();
            this.idlbl = new System.Windows.Forms.Label();
            this.statuslbl = new System.Windows.Forms.Label();
            this.btnUpdStock = new System.Windows.Forms.Button();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDateCreated = new System.Windows.Forms.Label();
            this.lblUpdated = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(3)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblRestockRequest);
            this.panel1.Controls.Add(this.Jupiterlbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(747, 69);
            this.panel1.TabIndex = 28;
            // 
            // lblRestockRequest
            // 
            this.lblRestockRequest.AutoSize = true;
            this.lblRestockRequest.BackColor = System.Drawing.Color.Black;
            this.lblRestockRequest.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRestockRequest.ForeColor = System.Drawing.Color.Red;
            this.lblRestockRequest.Location = new System.Drawing.Point(246, 35);
            this.lblRestockRequest.Name = "lblRestockRequest";
            this.lblRestockRequest.Size = new System.Drawing.Size(279, 32);
            this.lblRestockRequest.TabIndex = 37;
            this.lblRestockRequest.Text = "Restock Request Active";
            // 
            // Jupiterlbl
            // 
            this.Jupiterlbl.AutoSize = true;
            this.Jupiterlbl.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Jupiterlbl.Location = new System.Drawing.Point(288, -10);
            this.Jupiterlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Jupiterlbl.Name = "Jupiterlbl";
            this.Jupiterlbl.Size = new System.Drawing.Size(202, 45);
            this.Jupiterlbl.TabIndex = 6;
            this.Jupiterlbl.Text = "Stock Details";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(121)))), ((int)(((byte)(3)))));
            this.groupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox3.Controls.Add(this.lblMinAmount);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.quantitylbl);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.pricelbl);
            this.groupBox3.Controls.Add(this.buyingLbl);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Location = new System.Drawing.Point(0, 199);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(802, 59);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.GroupBox3_Enter);
            // 
            // lblMinAmount
            // 
            this.lblMinAmount.AutoSize = true;
            this.lblMinAmount.Location = new System.Drawing.Point(680, 26);
            this.lblMinAmount.Name = "lblMinAmount";
            this.lblMinAmount.Size = new System.Drawing.Size(58, 17);
            this.lblMinAmount.TabIndex = 24;
            this.lblMinAmount.Text = "Amount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(544, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Minimum Quantity:";
            // 
            // quantitylbl
            // 
            this.quantitylbl.AutoSize = true;
            this.quantitylbl.Location = new System.Drawing.Point(491, 27);
            this.quantitylbl.Name = "quantitylbl";
            this.quantitylbl.Size = new System.Drawing.Size(0, 17);
            this.quantitylbl.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(382, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Total Quantity:";
            // 
            // pricelbl
            // 
            this.pricelbl.AutoSize = true;
            this.pricelbl.Location = new System.Drawing.Point(284, 27);
            this.pricelbl.Name = "pricelbl";
            this.pricelbl.Size = new System.Drawing.Size(58, 17);
            this.pricelbl.TabIndex = 20;
            this.pricelbl.Text = "Amount";
            // 
            // buyingLbl
            // 
            this.buyingLbl.AutoSize = true;
            this.buyingLbl.Location = new System.Drawing.Point(103, 27);
            this.buyingLbl.Name = "buyingLbl";
            this.buyingLbl.Size = new System.Drawing.Size(58, 17);
            this.buyingLbl.TabIndex = 19;
            this.buyingLbl.Text = "Amount";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(8, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "Buying Price:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(190, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Selling Price:";
            // 
            // stockNameLbl
            // 
            this.stockNameLbl.AutoSize = true;
            this.stockNameLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stockNameLbl.Location = new System.Drawing.Point(362, 69);
            this.stockNameLbl.Name = "stockNameLbl";
            this.stockNameLbl.Size = new System.Drawing.Size(0, 32);
            this.stockNameLbl.TabIndex = 5;
            // 
            // idlbl
            // 
            this.idlbl.AutoSize = true;
            this.idlbl.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idlbl.Location = new System.Drawing.Point(361, 101);
            this.idlbl.Name = "idlbl";
            this.idlbl.Size = new System.Drawing.Size(0, 25);
            this.idlbl.TabIndex = 19;
            // 
            // statuslbl
            // 
            this.statuslbl.AutoSize = true;
            this.statuslbl.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statuslbl.Location = new System.Drawing.Point(362, 126);
            this.statuslbl.Name = "statuslbl";
            this.statuslbl.Size = new System.Drawing.Size(0, 25);
            this.statuslbl.TabIndex = 30;
            // 
            // btnUpdStock
            // 
            this.btnUpdStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(3)))));
            this.btnUpdStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdStock.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdStock.Location = new System.Drawing.Point(119, 264);
            this.btnUpdStock.Name = "btnUpdStock";
            this.btnUpdStock.Size = new System.Drawing.Size(522, 82);
            this.btnUpdStock.TabIndex = 32;
            this.btnUpdStock.Text = "Update Stock Details";
            this.btnUpdStock.UseVisualStyleBackColor = false;
            this.btnUpdStock.Click += new System.EventHandler(this.BtnUpdStock_Click);
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(3)))));
            this.btnGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoBack.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGoBack.Location = new System.Drawing.Point(254, 352);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(256, 48);
            this.btnGoBack.TabIndex = 33;
            this.btnGoBack.Text = "Go Back";
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.BtnGoBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(323, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 25);
            this.label1.TabIndex = 34;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(291, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 35;
            this.label2.Text = "Status:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(291, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 36;
            this.label3.Text = "Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(232, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 25);
            this.label5.TabIndex = 37;
            this.label5.Text = "Date Created:";
            // 
            // lblDateCreated
            // 
            this.lblDateCreated.AutoSize = true;
            this.lblDateCreated.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDateCreated.Location = new System.Drawing.Point(363, 151);
            this.lblDateCreated.Name = "lblDateCreated";
            this.lblDateCreated.Size = new System.Drawing.Size(0, 25);
            this.lblDateCreated.TabIndex = 38;
            // 
            // lblUpdated
            // 
            this.lblUpdated.AutoSize = true;
            this.lblUpdated.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUpdated.Location = new System.Drawing.Point(362, 176);
            this.lblUpdated.Name = "lblUpdated";
            this.lblUpdated.Size = new System.Drawing.Size(0, 25);
            this.lblUpdated.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(202, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 25);
            this.label8.TabIndex = 39;
            this.label8.Text = "Last Updated On:";
            // 
            // StockDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(121)))), ((int)(((byte)(3)))));
            this.ClientSize = new System.Drawing.Size(747, 404);
            this.Controls.Add(this.lblUpdated);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblDateCreated);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.btnUpdStock);
            this.Controls.Add(this.statuslbl);
            this.Controls.Add(this.idlbl);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.stockNameLbl);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StockDetails";
            this.Text = "Stock Details";
            this.Load += new System.EventHandler(this.StockDetails_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Jupiterlbl;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label stockNameLbl;
        private System.Windows.Forms.Label pricelbl;
        private System.Windows.Forms.Label buyingLbl;
        private System.Windows.Forms.Label idlbl;
        private System.Windows.Forms.Label statuslbl;
        private System.Windows.Forms.Button btnUpdStock;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label quantitylbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMinAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblRestockRequest;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDateCreated;
        private System.Windows.Forms.Label lblUpdated;
        private System.Windows.Forms.Label label8;
    }
}