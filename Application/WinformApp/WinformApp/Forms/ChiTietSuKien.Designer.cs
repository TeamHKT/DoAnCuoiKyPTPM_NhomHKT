namespace WinformApp.Forms
{
	partial class ChiTietSuKien
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChiTietSuKien));
			this.pictureBox_ChiTiet = new System.Windows.Forms.PictureBox();
			this.guna2ImageButton2 = new Guna.UI2.WinForms.Guna2ImageButton();
			this.lb_SuKien = new System.Windows.Forms.Label();
			this.lb_DiaDiem = new System.Windows.Forms.Label();
			this.lb_soVe = new System.Windows.Forms.Label();
			this.lb_ngayDienRa = new System.Windows.Forms.Label();
			this.btn_XoaSuKien = new Guna.UI2.WinForms.Guna2Button();
			this.btn_ThemVe = new Guna.UI2.WinForms.Guna2Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_ChiTiet)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox_ChiTiet
			// 
			this.pictureBox_ChiTiet.Location = new System.Drawing.Point(214, 41);
			this.pictureBox_ChiTiet.Name = "pictureBox_ChiTiet";
			this.pictureBox_ChiTiet.Size = new System.Drawing.Size(392, 246);
			this.pictureBox_ChiTiet.TabIndex = 0;
			this.pictureBox_ChiTiet.TabStop = false;
			// 
			// guna2ImageButton2
			// 
			this.guna2ImageButton2.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
			this.guna2ImageButton2.HoverState.ImageSize = new System.Drawing.Size(64, 64);
			this.guna2ImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton2.Image")));
			this.guna2ImageButton2.ImageOffset = new System.Drawing.Point(0, 0);
			this.guna2ImageButton2.ImageRotate = 0F;
			this.guna2ImageButton2.ImageSize = new System.Drawing.Size(32, 32);
			this.guna2ImageButton2.Location = new System.Drawing.Point(752, 11);
			this.guna2ImageButton2.Margin = new System.Windows.Forms.Padding(2);
			this.guna2ImageButton2.Name = "guna2ImageButton2";
			this.guna2ImageButton2.PressedState.ImageSize = new System.Drawing.Size(64, 64);
			this.guna2ImageButton2.Size = new System.Drawing.Size(37, 35);
			this.guna2ImageButton2.TabIndex = 8;
			this.guna2ImageButton2.Click += new System.EventHandler(this.guna2ImageButton2_Click);
			// 
			// lb_SuKien
			// 
			this.lb_SuKien.AutoSize = true;
			this.lb_SuKien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_SuKien.Location = new System.Drawing.Point(210, 305);
			this.lb_SuKien.Name = "lb_SuKien";
			this.lb_SuKien.Size = new System.Drawing.Size(132, 24);
			this.lb_SuKien.TabIndex = 9;
			this.lb_SuKien.Text = "Tên sự kiện: ";
			// 
			// lb_DiaDiem
			// 
			this.lb_DiaDiem.AutoSize = true;
			this.lb_DiaDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_DiaDiem.Location = new System.Drawing.Point(210, 348);
			this.lb_DiaDiem.Name = "lb_DiaDiem";
			this.lb_DiaDiem.Size = new System.Drawing.Size(105, 24);
			this.lb_DiaDiem.TabIndex = 10;
			this.lb_DiaDiem.Text = "Địa điểm: ";
			// 
			// lb_soVe
			// 
			this.lb_soVe.AutoSize = true;
			this.lb_soVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_soVe.Location = new System.Drawing.Point(210, 382);
			this.lb_soVe.Name = "lb_soVe";
			this.lb_soVe.Size = new System.Drawing.Size(149, 24);
			this.lb_soVe.TabIndex = 11;
			this.lb_soVe.Text = "Số vé còn lại:  ";
			// 
			// lb_ngayDienRa
			// 
			this.lb_ngayDienRa.AutoSize = true;
			this.lb_ngayDienRa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_ngayDienRa.Location = new System.Drawing.Point(210, 423);
			this.lb_ngayDienRa.Name = "lb_ngayDienRa";
			this.lb_ngayDienRa.Size = new System.Drawing.Size(141, 24);
			this.lb_ngayDienRa.TabIndex = 12;
			this.lb_ngayDienRa.Text = "Ngày diễn ra: ";
			// 
			// btn_XoaSuKien
			// 
			this.btn_XoaSuKien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btn_XoaSuKien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btn_XoaSuKien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btn_XoaSuKien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btn_XoaSuKien.FillColor = System.Drawing.Color.Red;
			this.btn_XoaSuKien.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_XoaSuKien.ForeColor = System.Drawing.Color.White;
			this.btn_XoaSuKien.Location = new System.Drawing.Point(441, 467);
			this.btn_XoaSuKien.Name = "btn_XoaSuKien";
			this.btn_XoaSuKien.Size = new System.Drawing.Size(165, 49);
			this.btn_XoaSuKien.TabIndex = 13;
			this.btn_XoaSuKien.Text = "Xóa sự kiện này";
			this.btn_XoaSuKien.Click += new System.EventHandler(this.btn_XoaSuKien_Click);
			// 
			// btn_ThemVe
			// 
			this.btn_ThemVe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btn_ThemVe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btn_ThemVe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btn_ThemVe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btn_ThemVe.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(115)))), ((int)(((byte)(65)))));
			this.btn_ThemVe.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_ThemVe.ForeColor = System.Drawing.Color.White;
			this.btn_ThemVe.Location = new System.Drawing.Point(214, 467);
			this.btn_ThemVe.Name = "btn_ThemVe";
			this.btn_ThemVe.Size = new System.Drawing.Size(179, 49);
			this.btn_ThemVe.TabIndex = 14;
			this.btn_ThemVe.Text = "Thêm vé";
			this.btn_ThemVe.Click += new System.EventHandler(this.btn_ThemVe_Click);
			// 
			// ChiTietSuKien
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 545);
			this.Controls.Add(this.btn_ThemVe);
			this.Controls.Add(this.btn_XoaSuKien);
			this.Controls.Add(this.lb_ngayDienRa);
			this.Controls.Add(this.lb_soVe);
			this.Controls.Add(this.lb_DiaDiem);
			this.Controls.Add(this.lb_SuKien);
			this.Controls.Add(this.guna2ImageButton2);
			this.Controls.Add(this.pictureBox_ChiTiet);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "ChiTietSuKien";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ChiTietSuKien";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_ChiTiet)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox_ChiTiet;
		private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton2;
		private System.Windows.Forms.Label lb_SuKien;
		private System.Windows.Forms.Label lb_DiaDiem;
		private System.Windows.Forms.Label lb_soVe;
		private System.Windows.Forms.Label lb_ngayDienRa;
		private Guna.UI2.WinForms.Guna2Button btn_XoaSuKien;
		private Guna.UI2.WinForms.Guna2Button btn_ThemVe;
	}
}