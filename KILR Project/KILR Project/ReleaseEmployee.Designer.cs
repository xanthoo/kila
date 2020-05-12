namespace KILR_Project
{
    partial class ReleaseEmployee
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
            this.btnRmv = new System.Windows.Forms.Button();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.dtpRelease = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnRmv
            // 
            this.btnRmv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(3)))));
            this.btnRmv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRmv.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRmv.Location = new System.Drawing.Point(40, 163);
            this.btnRmv.Name = "btnRmv";
            this.btnRmv.Size = new System.Drawing.Size(262, 73);
            this.btnRmv.TabIndex = 44;
            this.btnRmv.Text = "Release";
            this.btnRmv.UseVisualStyleBackColor = false;
            this.btnRmv.Click += new System.EventHandler(this.BtnRmv_Click);
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(3)))));
            this.btnGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoBack.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGoBack.Location = new System.Drawing.Point(12, 257);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(111, 62);
            this.btnGoBack.TabIndex = 45;
            this.btnGoBack.Text = "Back";
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.BtnGoBack_Click);
            // 
            // dtpRelease
            // 
            this.dtpRelease.Location = new System.Drawing.Point(40, 92);
            this.dtpRelease.Name = "dtpRelease";
            this.dtpRelease.Size = new System.Drawing.Size(262, 22);
            this.dtpRelease.TabIndex = 46;
            // 
            // ReleaseEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(121)))), ((int)(((byte)(3)))));
            this.ClientSize = new System.Drawing.Size(329, 331);
            this.Controls.Add(this.dtpRelease);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.btnRmv);
            this.Name = "ReleaseEmployee";
            this.Text = "ReleaseEmployee";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRmv;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.DateTimePicker dtpRelease;
    }
}