namespace KILR_Project
{
    partial class AssignShift
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
            this.rdbtnMonth = new System.Windows.Forms.RadioButton();
            this.rbtnDay = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.lbShifts = new System.Windows.Forms.ListBox();
            this.cbShift = new System.Windows.Forms.ComboBox();
            this.dtpShift = new System.Windows.Forms.DateTimePicker();
            this.btnShift = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdbtnMonth
            // 
            this.rdbtnMonth.AutoSize = true;
            this.rdbtnMonth.Location = new System.Drawing.Point(205, 166);
            this.rdbtnMonth.Name = "rdbtnMonth";
            this.rdbtnMonth.Size = new System.Drawing.Size(68, 21);
            this.rdbtnMonth.TabIndex = 53;
            this.rdbtnMonth.TabStop = true;
            this.rdbtnMonth.Text = "Month";
            this.rdbtnMonth.UseVisualStyleBackColor = true;
            // 
            // rbtnDay
            // 
            this.rbtnDay.AutoSize = true;
            this.rbtnDay.Location = new System.Drawing.Point(41, 166);
            this.rbtnDay.Name = "rbtnDay";
            this.rbtnDay.Size = new System.Drawing.Size(54, 21);
            this.rbtnDay.TabIndex = 52;
            this.rbtnDay.TabStop = true;
            this.rbtnDay.Text = "Day";
            this.rbtnDay.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(3)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(41, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 62);
            this.button1.TabIndex = 51;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // lbShifts
            // 
            this.lbShifts.FormattingEnabled = true;
            this.lbShifts.ItemHeight = 16;
            this.lbShifts.Location = new System.Drawing.Point(429, 84);
            this.lbShifts.Name = "lbShifts";
            this.lbShifts.Size = new System.Drawing.Size(330, 276);
            this.lbShifts.TabIndex = 50;
            // 
            // cbShift
            // 
            this.cbShift.FormattingEnabled = true;
            this.cbShift.Items.AddRange(new object[] {
            "Day",
            "Night",
            "Afternoon"});
            this.cbShift.Location = new System.Drawing.Point(41, 84);
            this.cbShift.Name = "cbShift";
            this.cbShift.Size = new System.Drawing.Size(121, 24);
            this.cbShift.TabIndex = 49;
            // 
            // dtpShift
            // 
            this.dtpShift.Location = new System.Drawing.Point(205, 86);
            this.dtpShift.Name = "dtpShift";
            this.dtpShift.Size = new System.Drawing.Size(200, 22);
            this.dtpShift.TabIndex = 48;
            // 
            // btnShift
            // 
            this.btnShift.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(3)))));
            this.btnShift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShift.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShift.Location = new System.Drawing.Point(41, 223);
            this.btnShift.Name = "btnShift";
            this.btnShift.Size = new System.Drawing.Size(350, 73);
            this.btnShift.TabIndex = 47;
            this.btnShift.Text = "Assign Shift";
            this.btnShift.UseVisualStyleBackColor = false;
            this.btnShift.Click += new System.EventHandler(this.BtnShift_Click_1);
            // 
            // AssignShift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(121)))), ((int)(((byte)(3)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rdbtnMonth);
            this.Controls.Add(this.rbtnDay);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbShifts);
            this.Controls.Add(this.cbShift);
            this.Controls.Add(this.dtpShift);
            this.Controls.Add(this.btnShift);
            this.Name = "AssignShift";
            this.Text = "AssignShift";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbtnMonth;
        private System.Windows.Forms.RadioButton rbtnDay;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lbShifts;
        private System.Windows.Forms.ComboBox cbShift;
        private System.Windows.Forms.DateTimePicker dtpShift;
        private System.Windows.Forms.Button btnShift;
    }
}