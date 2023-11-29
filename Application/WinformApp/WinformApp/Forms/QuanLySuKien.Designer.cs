namespace WinformApp
{
    partial class QuanLySuKien
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
			this.flowLayoutPanel_SuKien = new System.Windows.Forms.FlowLayoutPanel();
			this.btn_ThemSuKien = new Guna.UI2.WinForms.Guna2Button();
			this.SuspendLayout();
			// 
			// flowLayoutPanel_SuKien
			// 
			this.flowLayoutPanel_SuKien.AutoScroll = true;
			this.flowLayoutPanel_SuKien.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.flowLayoutPanel_SuKien.Location = new System.Drawing.Point(0, 98);
			this.flowLayoutPanel_SuKien.Name = "flowLayoutPanel_SuKien";
			this.flowLayoutPanel_SuKien.Size = new System.Drawing.Size(830, 488);
			this.flowLayoutPanel_SuKien.TabIndex = 0;
			// 
			// btn_ThemSuKien
			// 
			this.btn_ThemSuKien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btn_ThemSuKien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btn_ThemSuKien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btn_ThemSuKien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btn_ThemSuKien.Dock = System.Windows.Forms.DockStyle.Top;
			this.btn_ThemSuKien.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(115)))), ((int)(((byte)(65)))));
			this.btn_ThemSuKien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_ThemSuKien.ForeColor = System.Drawing.Color.White;
			this.btn_ThemSuKien.Location = new System.Drawing.Point(0, 0);
			this.btn_ThemSuKien.Name = "btn_ThemSuKien";
			this.btn_ThemSuKien.Size = new System.Drawing.Size(830, 45);
			this.btn_ThemSuKien.TabIndex = 1;
			this.btn_ThemSuKien.Text = "Thêm sự kiện";
			this.btn_ThemSuKien.Click += new System.EventHandler(this.btn_ThemSuKien_Click);
			// 
			// QuanLySuKien
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Honeydew;
			this.ClientSize = new System.Drawing.Size(830, 586);
			this.Controls.Add(this.btn_ThemSuKien);
			this.Controls.Add(this.flowLayoutPanel_SuKien);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "QuanLySuKien";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "QuanLySuKien";
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_SuKien;
		private Guna.UI2.WinForms.Guna2Button btn_ThemSuKien;
	}
}