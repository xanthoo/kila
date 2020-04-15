namespace KILR_Project
{
    partial class AssignShifts
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
            this.dtpShift = new System.Windows.Forms.DateTimePicker();
            this.cbShift = new System.Windows.Forms.ComboBox();
            this.btnAssign = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // dtpShift
            // 
            this.dtpShift.Location = new System.Drawing.Point(192, 62);
            this.dtpShift.Name = "dtpShift";
            this.dtpShift.Size = new System.Drawing.Size(149, 22);
            this.dtpShift.TabIndex = 0;
            this.dtpShift.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // cbShift
            // 
            this.cbShift.FormattingEnabled = true;
            this.cbShift.Items.AddRange(new object[] {
            "Day",
            "Night",
            "Afternoon"});
            this.cbShift.Location = new System.Drawing.Point(65, 60);
            this.cbShift.Name = "cbShift";
            this.cbShift.Size = new System.Drawing.Size(121, 24);
            this.cbShift.TabIndex = 1;
            // 
            // btnAssign
            // 
            this.btnAssign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(3)))));
            this.btnAssign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssign.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAssign.Location = new System.Drawing.Point(65, 214);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(276, 87);
            this.btnAssign.TabIndex = 40;
            this.btnAssign.Text = "Assign Shift";
            this.btnAssign.UseVisualStyleBackColor = false;
            this.btnAssign.Click += new System.EventHandler(this.Button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(358, 62);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(194, 244);
            this.listBox1.TabIndex = 41;
            // 
            // AssignShifts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(121)))), ((int)(((byte)(3)))));
            this.ClientSize = new System.Drawing.Size(578, 345);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.cbShift);
            this.Controls.Add(this.dtpShift);
            this.Name = "AssignShifts";
            this.Text = "AssignShifts";
            this.Load += new System.EventHandler(this.AssignShifts_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpShift;
        private System.Windows.Forms.ComboBox cbShift;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.ListBox listBox1;
    }
}