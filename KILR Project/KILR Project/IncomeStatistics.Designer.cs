namespace KILR_Project
{
    partial class IncomeStatistics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnRevenueDay = new System.Windows.Forms.Button();
            this.btnAllTransactions = new System.Windows.Forms.Button();
            this.btnTransactionsDaily = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chartRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelTotalRevenue = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.panelAllTransactions = new System.Windows.Forms.Panel();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.lbTransactions = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelTransactionsDay = new System.Windows.Forms.Panel();
            this.panelOrders = new System.Windows.Forms.Panel();
            this.chartTransactions = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotalTransactions = new System.Windows.Forms.Label();
            this.btnAllOrders = new System.Windows.Forms.Button();
            this.lbOrders = new System.Windows.Forms.ListBox();
            this.dateOrders = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.panelHide = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).BeginInit();
            this.panelTotalRevenue.SuspendLayout();
            this.panelAllTransactions.SuspendLayout();
            this.panelTransactionsDay.SuspendLayout();
            this.panelOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRevenueDay
            // 
            this.btnRevenueDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(3)))));
            this.btnRevenueDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRevenueDay.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRevenueDay.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRevenueDay.Location = new System.Drawing.Point(33, 110);
            this.btnRevenueDay.Name = "btnRevenueDay";
            this.btnRevenueDay.Size = new System.Drawing.Size(240, 59);
            this.btnRevenueDay.TabIndex = 6;
            this.btnRevenueDay.Text = "Revenue per Day";
            this.btnRevenueDay.UseVisualStyleBackColor = false;
            this.btnRevenueDay.Click += new System.EventHandler(this.BtnRevenueDay_Click);
            // 
            // btnAllTransactions
            // 
            this.btnAllTransactions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(3)))));
            this.btnAllTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllTransactions.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAllTransactions.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAllTransactions.Location = new System.Drawing.Point(33, 209);
            this.btnAllTransactions.Name = "btnAllTransactions";
            this.btnAllTransactions.Size = new System.Drawing.Size(240, 59);
            this.btnAllTransactions.TabIndex = 7;
            this.btnAllTransactions.Text = "All Transactions";
            this.btnAllTransactions.UseVisualStyleBackColor = false;
            this.btnAllTransactions.Click += new System.EventHandler(this.BtnAllTransactions_Click);
            // 
            // btnTransactionsDaily
            // 
            this.btnTransactionsDaily.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(3)))));
            this.btnTransactionsDaily.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransactionsDaily.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTransactionsDaily.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTransactionsDaily.Location = new System.Drawing.Point(33, 307);
            this.btnTransactionsDaily.Name = "btnTransactionsDaily";
            this.btnTransactionsDaily.Size = new System.Drawing.Size(240, 59);
            this.btnTransactionsDaily.TabIndex = 8;
            this.btnTransactionsDaily.Text = "Transactions per Day";
            this.btnTransactionsDaily.UseVisualStyleBackColor = false;
            this.btnTransactionsDaily.Click += new System.EventHandler(this.BtnTransactionsDaily_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(3)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1007, 42);
            this.panel1.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(3)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(354, -5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 45);
            this.label2.TabIndex = 10;
            this.label2.Text = "Jupiter Income View";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(199, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Revenue per Day";
            // 
            // chartRevenue
            // 
            this.chartRevenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(121)))), ((int)(((byte)(3)))));
            chartArea9.Name = "ChartArea1";
            this.chartRevenue.ChartAreas.Add(chartArea9);
            legend9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(121)))), ((int)(((byte)(3)))));
            legend9.Name = "Legend1";
            this.chartRevenue.Legends.Add(legend9);
            this.chartRevenue.Location = new System.Drawing.Point(17, 48);
            this.chartRevenue.Name = "chartRevenue";
            this.chartRevenue.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series9.BackSecondaryColor = System.Drawing.Color.Lavender;
            series9.BorderColor = System.Drawing.Color.WhiteSmoke;
            series9.ChartArea = "ChartArea1";
            series9.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(121)))), ((int)(((byte)(3)))));
            series9.LabelBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(121)))), ((int)(((byte)(3)))));
            series9.Legend = "Legend1";
            series9.MarkerColor = System.Drawing.Color.White;
            series9.Name = "Revenue";
            this.chartRevenue.Series.Add(series9);
            this.chartRevenue.Size = new System.Drawing.Size(667, 296);
            this.chartRevenue.TabIndex = 1;
            this.chartRevenue.Text = "chartYearlyRevenue";
            // 
            // panelTotalRevenue
            // 
            this.panelTotalRevenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(3)))));
            this.panelTotalRevenue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTotalRevenue.Controls.Add(this.chartRevenue);
            this.panelTotalRevenue.Controls.Add(this.label1);
            this.panelTotalRevenue.Location = new System.Drawing.Point(269, 110);
            this.panelTotalRevenue.Name = "panelTotalRevenue";
            this.panelTotalRevenue.Size = new System.Drawing.Size(703, 357);
            this.panelTotalRevenue.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(26, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Shop Revenue:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotal.Location = new System.Drawing.Point(280, 45);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(47, 37);
            this.lblTotal.TabIndex = 18;
            this.lblTotal.Text = "0€";
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(3)))));
            this.btnGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoBack.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGoBack.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGoBack.Location = new System.Drawing.Point(732, 473);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(240, 47);
            this.btnGoBack.TabIndex = 19;
            this.btnGoBack.Text = "Go Back";
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.GoBack_Click);
            // 
            // panelAllTransactions
            // 
            this.panelAllTransactions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(3)))));
            this.panelAllTransactions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAllTransactions.Controls.Add(this.datePicker);
            this.panelAllTransactions.Controls.Add(this.label5);
            this.panelAllTransactions.Controls.Add(this.lbTransactions);
            this.panelAllTransactions.Controls.Add(this.label4);
            this.panelAllTransactions.Location = new System.Drawing.Point(269, 110);
            this.panelAllTransactions.Name = "panelAllTransactions";
            this.panelAllTransactions.Size = new System.Drawing.Size(703, 357);
            this.panelAllTransactions.TabIndex = 10;
            // 
            // datePicker
            // 
            this.datePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.datePicker.Location = new System.Drawing.Point(471, 83);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(229, 22);
            this.datePicker.TabIndex = 23;
            this.datePicker.ValueChanged += new System.EventHandler(this.DatePicker_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(501, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "Search by Date";
            // 
            // lbTransactions
            // 
            this.lbTransactions.FormattingEnabled = true;
            this.lbTransactions.ItemHeight = 17;
            this.lbTransactions.Location = new System.Drawing.Point(10, 82);
            this.lbTransactions.Name = "lbTransactions";
            this.lbTransactions.Size = new System.Drawing.Size(455, 259);
            this.lbTransactions.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(229, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 37);
            this.label4.TabIndex = 11;
            this.label4.Text = "All Transactions";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // panelTransactionsDay
            // 
            this.panelTransactionsDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(3)))));
            this.panelTransactionsDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTransactionsDay.Controls.Add(this.chartTransactions);
            this.panelTransactionsDay.Controls.Add(this.label7);
            this.panelTransactionsDay.Location = new System.Drawing.Point(269, 110);
            this.panelTransactionsDay.Name = "panelTransactionsDay";
            this.panelTransactionsDay.Size = new System.Drawing.Size(703, 357);
            this.panelTransactionsDay.TabIndex = 24;
            // 
            // panelOrders
            // 
            this.panelOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(3)))));
            this.panelOrders.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOrders.Controls.Add(this.label8);
            this.panelOrders.Controls.Add(this.dateOrders);
            this.panelOrders.Controls.Add(this.lbOrders);
            this.panelOrders.Location = new System.Drawing.Point(269, 110);
            this.panelOrders.Name = "panelOrders";
            this.panelOrders.Size = new System.Drawing.Size(703, 357);
            this.panelOrders.TabIndex = 25;
            // 
            // chartTransactions
            // 
            this.chartTransactions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(121)))), ((int)(((byte)(3)))));
            chartArea10.Name = "ChartArea1";
            this.chartTransactions.ChartAreas.Add(chartArea10);
            legend10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(121)))), ((int)(((byte)(3)))));
            legend10.Name = "Legend1";
            this.chartTransactions.Legends.Add(legend10);
            this.chartTransactions.Location = new System.Drawing.Point(17, 48);
            this.chartTransactions.Name = "chartTransactions";
            this.chartTransactions.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series10.BackSecondaryColor = System.Drawing.Color.Lavender;
            series10.BorderColor = System.Drawing.Color.WhiteSmoke;
            series10.ChartArea = "ChartArea1";
            series10.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(121)))), ((int)(((byte)(3)))));
            series10.LabelBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(121)))), ((int)(((byte)(3)))));
            series10.Legend = "Legend1";
            series10.MarkerColor = System.Drawing.Color.White;
            series10.Name = "Amount";
            this.chartTransactions.Series.Add(series10);
            this.chartTransactions.Size = new System.Drawing.Size(667, 296);
            this.chartTransactions.TabIndex = 12;
            this.chartTransactions.Text = "chartYearlyRevenue";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(199, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(271, 37);
            this.label7.TabIndex = 11;
            this.label7.Text = "Transactions per Day";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(28, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 25);
            this.label6.TabIndex = 25;
            this.label6.Text = "Total Transactions:";
            // 
            // lblTotalTransactions
            // 
            this.lblTotalTransactions.AutoSize = true;
            this.lblTotalTransactions.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotalTransactions.Location = new System.Drawing.Point(192, 82);
            this.lblTotalTransactions.Name = "lblTotalTransactions";
            this.lblTotalTransactions.Size = new System.Drawing.Size(23, 25);
            this.lblTotalTransactions.TabIndex = 26;
            this.lblTotalTransactions.Text = "0";
            // 
            // btnAllOrders
            // 
            this.btnAllOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(3)))));
            this.btnAllOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllOrders.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAllOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAllOrders.Location = new System.Drawing.Point(33, 408);
            this.btnAllOrders.Name = "btnAllOrders";
            this.btnAllOrders.Size = new System.Drawing.Size(240, 59);
            this.btnAllOrders.TabIndex = 27;
            this.btnAllOrders.Text = "All Orders";
            this.btnAllOrders.UseVisualStyleBackColor = false;
            this.btnAllOrders.Click += new System.EventHandler(this.BtnAllOrders_Click);
            // 
            // lbOrders
            // 
            this.lbOrders.FormattingEnabled = true;
            this.lbOrders.ItemHeight = 17;
            this.lbOrders.Location = new System.Drawing.Point(10, 8);
            this.lbOrders.Name = "lbOrders";
            this.lbOrders.Size = new System.Drawing.Size(674, 191);
            this.lbOrders.TabIndex = 0;
            // 
            // dateOrders
            // 
            this.dateOrders.CalendarFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateOrders.Location = new System.Drawing.Point(17, 230);
            this.dateOrders.Name = "dateOrders";
            this.dateOrders.Size = new System.Drawing.Size(229, 21);
            this.dateOrders.TabIndex = 1;
            this.dateOrders.ValueChanged += new System.EventHandler(this.DateOrders_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(12, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 25);
            this.label8.TabIndex = 23;
            this.label8.Text = "Search by Date";
            // 
            // panelHide
            // 
            this.panelHide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(3)))));
            this.panelHide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHide.Location = new System.Drawing.Point(269, 110);
            this.panelHide.Name = "panelHide";
            this.panelHide.Size = new System.Drawing.Size(703, 357);
            this.panelHide.TabIndex = 26;
            // 
            // IncomeStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(121)))), ((int)(((byte)(3)))));
            this.ClientSize = new System.Drawing.Size(1004, 529);
            this.Controls.Add(this.panelHide);
            this.Controls.Add(this.panelOrders);
            this.Controls.Add(this.btnAllOrders);
            this.Controls.Add(this.panelTransactionsDay);
            this.Controls.Add(this.panelAllTransactions);
            this.Controls.Add(this.lblTotalTransactions);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTotalRevenue);
            this.Controls.Add(this.btnTransactionsDaily);
            this.Controls.Add(this.btnAllTransactions);
            this.Controls.Add(this.btnRevenueDay);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "IncomeStatistics";
            this.Text = "IncomeStatistics";
            this.Load += new System.EventHandler(this.IncomeStatistics_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).EndInit();
            this.panelTotalRevenue.ResumeLayout(false);
            this.panelTotalRevenue.PerformLayout();
            this.panelAllTransactions.ResumeLayout(false);
            this.panelAllTransactions.PerformLayout();
            this.panelTransactionsDay.ResumeLayout(false);
            this.panelTransactionsDay.PerformLayout();
            this.panelOrders.ResumeLayout(false);
            this.panelOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTransactions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRevenueDay;
        private System.Windows.Forms.Button btnAllTransactions;
        private System.Windows.Forms.Button btnTransactionsDaily;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRevenue;
        private System.Windows.Forms.Panel panelTotalRevenue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Panel panelAllTransactions;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbTransactions;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Panel panelTransactionsDay;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTransactions;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panelOrders;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotalTransactions;
        private System.Windows.Forms.Button btnAllOrders;
        private System.Windows.Forms.DateTimePicker dateOrders;
        private System.Windows.Forms.ListBox lbOrders;
        private System.Windows.Forms.Panel panelHide;
        private System.Windows.Forms.Label label8;
    }
}