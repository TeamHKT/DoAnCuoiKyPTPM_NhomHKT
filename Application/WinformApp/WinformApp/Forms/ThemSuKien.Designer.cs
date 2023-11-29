namespace WinformApp.Forms
{
	partial class ThemSuKien
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemSuKien));
			this.btn_ThemHinh = new Guna.UI2.WinForms.Guna2Button();
			this.btn_XacNhan = new Guna.UI2.WinForms.Guna2Button();
			this.label1 = new System.Windows.Forms.Label();
			this.datepicker_NgayDienRa = new Guna.UI2.WinForms.Guna2DateTimePicker();
			this.txt_DiaDiem = new Guna.UI2.WinForms.Guna2TextBox();
			this.txt_TenSuKien = new Guna.UI2.WinForms.Guna2TextBox();
			this.lb_soVe = new System.Windows.Forms.Label();
			this.lb_DiaDiem = new System.Windows.Forms.Label();
			this.lb_SuKien = new System.Windows.Forms.Label();
			this.guna2ImageButton2 = new Guna.UI2.WinForms.Guna2ImageButton();
			this.pictureBox_ChiTiet = new System.Windows.Forms.PictureBox();
			this.txt_SoVe = new CustomControls.TextBoxDigit();
			this.txt_DonGia = new CustomControls.TextBoxDigit();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_ChiTiet)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_ThemHinh
			// 
			this.btn_ThemHinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(115)))), ((int)(((byte)(65)))));
			this.btn_ThemHinh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btn_ThemHinh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btn_ThemHinh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btn_ThemHinh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btn_ThemHinh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(115)))), ((int)(((byte)(65)))));
			this.btn_ThemHinh.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_ThemHinh.ForeColor = System.Drawing.Color.White;
			this.btn_ThemHinh.Location = new System.Drawing.Point(367, 258);
			this.btn_ThemHinh.Name = "btn_ThemHinh";
			this.btn_ThemHinh.Size = new System.Drawing.Size(180, 45);
			this.btn_ThemHinh.TabIndex = 35;
			this.btn_ThemHinh.Text = "Thêm hình ảnh";
			this.btn_ThemHinh.Click += new System.EventHandler(this.btn_ThemHinh_Click);
			// 
			// btn_XacNhan
			// 
			this.btn_XacNhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(115)))), ((int)(((byte)(65)))));
			this.btn_XacNhan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btn_XacNhan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btn_XacNhan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btn_XacNhan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btn_XacNhan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(115)))), ((int)(((byte)(65)))));
			this.btn_XacNhan.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_XacNhan.ForeColor = System.Drawing.Color.White;
			this.btn_XacNhan.Location = new System.Drawing.Point(367, 661);
			this.btn_XacNhan.Name = "btn_XacNhan";
			this.btn_XacNhan.Size = new System.Drawing.Size(180, 45);
			this.btn_XacNhan.TabIndex = 34;
			this.btn_XacNhan.Text = "Xác nhận";
			this.btn_XacNhan.Click += new System.EventHandler(this.btn_XacNhan_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(226, 602);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(135, 24);
			this.label1.TabIndex = 33;
			this.label1.Text = "Ngày diễn ra:";
			// 
			// datepicker_NgayDienRa
			// 
			this.datepicker_NgayDienRa.Checked = true;
			this.datepicker_NgayDienRa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.datepicker_NgayDienRa.ForeColor = System.Drawing.Color.White;
			this.datepicker_NgayDienRa.Format = System.Windows.Forms.DateTimePickerFormat.Long;
			this.datepicker_NgayDienRa.Location = new System.Drawing.Point(367, 597);
			this.datepicker_NgayDienRa.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
			this.datepicker_NgayDienRa.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
			this.datepicker_NgayDienRa.Name = "datepicker_NgayDienRa";
			this.datepicker_NgayDienRa.Size = new System.Drawing.Size(258, 36);
			this.datepicker_NgayDienRa.TabIndex = 32;
			this.datepicker_NgayDienRa.Value = new System.DateTime(2023, 11, 29, 22, 20, 38, 748);
			// 
			// txt_DiaDiem
			// 
			this.txt_DiaDiem.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_DiaDiem.DefaultText = "";
			this.txt_DiaDiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txt_DiaDiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txt_DiaDiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_DiaDiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_DiaDiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_DiaDiem.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txt_DiaDiem.ForeColor = System.Drawing.Color.Black;
			this.txt_DiaDiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_DiaDiem.Location = new System.Drawing.Point(367, 385);
			this.txt_DiaDiem.Name = "txt_DiaDiem";
			this.txt_DiaDiem.PasswordChar = '\0';
			this.txt_DiaDiem.PlaceholderText = "";
			this.txt_DiaDiem.SelectedText = "";
			this.txt_DiaDiem.Size = new System.Drawing.Size(258, 45);
			this.txt_DiaDiem.TabIndex = 30;
			// 
			// txt_TenSuKien
			// 
			this.txt_TenSuKien.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_TenSuKien.DefaultText = "";
			this.txt_TenSuKien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txt_TenSuKien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txt_TenSuKien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_TenSuKien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_TenSuKien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_TenSuKien.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txt_TenSuKien.ForeColor = System.Drawing.Color.Black;
			this.txt_TenSuKien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_TenSuKien.Location = new System.Drawing.Point(367, 323);
			this.txt_TenSuKien.Name = "txt_TenSuKien";
			this.txt_TenSuKien.PasswordChar = '\0';
			this.txt_TenSuKien.PlaceholderText = "";
			this.txt_TenSuKien.SelectedText = "";
			this.txt_TenSuKien.Size = new System.Drawing.Size(258, 45);
			this.txt_TenSuKien.TabIndex = 29;
			// 
			// lb_soVe
			// 
			this.lb_soVe.AutoSize = true;
			this.lb_soVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_soVe.Location = new System.Drawing.Point(226, 464);
			this.lb_soVe.Name = "lb_soVe";
			this.lb_soVe.Size = new System.Drawing.Size(81, 24);
			this.lb_soVe.TabIndex = 28;
			this.lb_soVe.Text = "Số vé:  ";
			// 
			// lb_DiaDiem
			// 
			this.lb_DiaDiem.AutoSize = true;
			this.lb_DiaDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_DiaDiem.Location = new System.Drawing.Point(226, 398);
			this.lb_DiaDiem.Name = "lb_DiaDiem";
			this.lb_DiaDiem.Size = new System.Drawing.Size(105, 24);
			this.lb_DiaDiem.TabIndex = 27;
			this.lb_DiaDiem.Text = "Địa điểm: ";
			// 
			// lb_SuKien
			// 
			this.lb_SuKien.AutoSize = true;
			this.lb_SuKien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_SuKien.Location = new System.Drawing.Point(226, 341);
			this.lb_SuKien.Name = "lb_SuKien";
			this.lb_SuKien.Size = new System.Drawing.Size(132, 24);
			this.lb_SuKien.TabIndex = 26;
			this.lb_SuKien.Text = "Tên sự kiện: ";
			// 
			// guna2ImageButton2
			// 
			this.guna2ImageButton2.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
			this.guna2ImageButton2.HoverState.ImageSize = new System.Drawing.Size(64, 64);
			this.guna2ImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton2.Image")));
			this.guna2ImageButton2.ImageOffset = new System.Drawing.Point(0, 0);
			this.guna2ImageButton2.ImageRotate = 0F;
			this.guna2ImageButton2.ImageSize = new System.Drawing.Size(32, 32);
			this.guna2ImageButton2.Location = new System.Drawing.Point(768, 27);
			this.guna2ImageButton2.Margin = new System.Windows.Forms.Padding(2);
			this.guna2ImageButton2.Name = "guna2ImageButton2";
			this.guna2ImageButton2.PressedState.ImageSize = new System.Drawing.Size(64, 64);
			this.guna2ImageButton2.Size = new System.Drawing.Size(37, 35);
			this.guna2ImageButton2.TabIndex = 25;
			this.guna2ImageButton2.Click += new System.EventHandler(this.guna2ImageButton2_Click);
			// 
			// pictureBox_ChiTiet
			// 
			this.pictureBox_ChiTiet.Location = new System.Drawing.Point(230, 32);
			this.pictureBox_ChiTiet.Name = "pictureBox_ChiTiet";
			this.pictureBox_ChiTiet.Size = new System.Drawing.Size(395, 209);
			this.pictureBox_ChiTiet.TabIndex = 24;
			this.pictureBox_ChiTiet.TabStop = false;
			// 
			// txt_SoVe
			// 
			this.txt_SoVe.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_SoVe.DefaultText = "";
			this.txt_SoVe.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txt_SoVe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txt_SoVe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_SoVe.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_SoVe.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_SoVe.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txt_SoVe.ForeColor = System.Drawing.Color.Black;
			this.txt_SoVe.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_SoVe.Location = new System.Drawing.Point(367, 452);
			this.txt_SoVe.Name = "txt_SoVe";
			this.txt_SoVe.PasswordChar = '\0';
			this.txt_SoVe.PlaceholderText = "";
			this.txt_SoVe.SelectedText = "";
			this.txt_SoVe.Size = new System.Drawing.Size(258, 45);
			this.txt_SoVe.TabIndex = 36;
			// 
			// txt_DonGia
			// 
			this.txt_DonGia.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_DonGia.DefaultText = "";
			this.txt_DonGia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txt_DonGia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txt_DonGia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_DonGia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_DonGia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_DonGia.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txt_DonGia.ForeColor = System.Drawing.Color.Black;
			this.txt_DonGia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_DonGia.Location = new System.Drawing.Point(367, 516);
			this.txt_DonGia.Name = "txt_DonGia";
			this.txt_DonGia.PasswordChar = '\0';
			this.txt_DonGia.PlaceholderText = "";
			this.txt_DonGia.SelectedText = "";
			this.txt_DonGia.Size = new System.Drawing.Size(258, 45);
			this.txt_DonGia.TabIndex = 38;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(226, 530);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(128, 24);
			this.label2.TabIndex = 37;
			this.label2.Text = "Đơn giá vé:  ";
			// 
			// ThemSuKien
			// 
			this.AcceptButton = this.btn_XacNhan;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(850, 734);
			this.Controls.Add(this.txt_DonGia);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txt_SoVe);
			this.Controls.Add(this.btn_ThemHinh);
			this.Controls.Add(this.btn_XacNhan);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.datepicker_NgayDienRa);
			this.Controls.Add(this.txt_DiaDiem);
			this.Controls.Add(this.txt_TenSuKien);
			this.Controls.Add(this.lb_soVe);
			this.Controls.Add(this.lb_DiaDiem);
			this.Controls.Add(this.lb_SuKien);
			this.Controls.Add(this.guna2ImageButton2);
			this.Controls.Add(this.pictureBox_ChiTiet);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "ThemSuKien";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ThemSuKien";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_ChiTiet)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Guna.UI2.WinForms.Guna2Button btn_ThemHinh;
		private Guna.UI2.WinForms.Guna2Button btn_XacNhan;
		private System.Windows.Forms.Label label1;
		private Guna.UI2.WinForms.Guna2DateTimePicker datepicker_NgayDienRa;
		private Guna.UI2.WinForms.Guna2TextBox txt_DiaDiem;
		private Guna.UI2.WinForms.Guna2TextBox txt_TenSuKien;
		private System.Windows.Forms.Label lb_soVe;
		private System.Windows.Forms.Label lb_DiaDiem;
		private System.Windows.Forms.Label lb_SuKien;
		private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton2;
		private System.Windows.Forms.PictureBox pictureBox_ChiTiet;
		private CustomControls.TextBoxDigit txt_SoVe;
		private CustomControls.TextBoxDigit txt_DonGia;
		private System.Windows.Forms.Label label2;
	}
}