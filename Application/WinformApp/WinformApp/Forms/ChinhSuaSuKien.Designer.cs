namespace WinformApp.Forms
{
	partial class ChinhSuaSuKien
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChinhSuaSuKien));
			this.lb_soVe = new System.Windows.Forms.Label();
			this.lb_DiaDiem = new System.Windows.Forms.Label();
			this.lb_SuKien = new System.Windows.Forms.Label();
			this.guna2ImageButton2 = new Guna.UI2.WinForms.Guna2ImageButton();
			this.pictureBox_ChiTiet = new System.Windows.Forms.PictureBox();
			this.txt_TenSuKien = new Guna.UI2.WinForms.Guna2TextBox();
			this.txt_DiaDiem = new Guna.UI2.WinForms.Guna2TextBox();
			this.datepicker_NgayDienRa = new Guna.UI2.WinForms.Guna2DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_XacNhan = new Guna.UI2.WinForms.Guna2Button();
			this.btn_DoiHinhAnh = new Guna.UI2.WinForms.Guna2Button();
			this.txt_SoVe = new CustomControls.TextBoxDigit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_ChiTiet)).BeginInit();
			this.SuspendLayout();
			// 
			// lb_soVe
			// 
			this.lb_soVe.AutoSize = true;
			this.lb_soVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_soVe.Location = new System.Drawing.Point(210, 441);
			this.lb_soVe.Name = "lb_soVe";
			this.lb_soVe.Size = new System.Drawing.Size(81, 24);
			this.lb_soVe.TabIndex = 16;
			this.lb_soVe.Text = "Số vé:  ";
			// 
			// lb_DiaDiem
			// 
			this.lb_DiaDiem.AutoSize = true;
			this.lb_DiaDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_DiaDiem.Location = new System.Drawing.Point(210, 378);
			this.lb_DiaDiem.Name = "lb_DiaDiem";
			this.lb_DiaDiem.Size = new System.Drawing.Size(105, 24);
			this.lb_DiaDiem.TabIndex = 15;
			this.lb_DiaDiem.Text = "Địa điểm: ";
			// 
			// lb_SuKien
			// 
			this.lb_SuKien.AutoSize = true;
			this.lb_SuKien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_SuKien.Location = new System.Drawing.Point(210, 321);
			this.lb_SuKien.Name = "lb_SuKien";
			this.lb_SuKien.Size = new System.Drawing.Size(132, 24);
			this.lb_SuKien.TabIndex = 14;
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
			this.guna2ImageButton2.Location = new System.Drawing.Point(752, 7);
			this.guna2ImageButton2.Margin = new System.Windows.Forms.Padding(2);
			this.guna2ImageButton2.Name = "guna2ImageButton2";
			this.guna2ImageButton2.PressedState.ImageSize = new System.Drawing.Size(64, 64);
			this.guna2ImageButton2.Size = new System.Drawing.Size(37, 35);
			this.guna2ImageButton2.TabIndex = 13;
			this.guna2ImageButton2.Click += new System.EventHandler(this.guna2ImageButton2_Click);
			// 
			// pictureBox_ChiTiet
			// 
			this.pictureBox_ChiTiet.Location = new System.Drawing.Point(214, 12);
			this.pictureBox_ChiTiet.Name = "pictureBox_ChiTiet";
			this.pictureBox_ChiTiet.Size = new System.Drawing.Size(395, 209);
			this.pictureBox_ChiTiet.TabIndex = 12;
			this.pictureBox_ChiTiet.TabStop = false;
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
			this.txt_TenSuKien.Location = new System.Drawing.Point(351, 303);
			this.txt_TenSuKien.Name = "txt_TenSuKien";
			this.txt_TenSuKien.PasswordChar = '\0';
			this.txt_TenSuKien.PlaceholderText = "";
			this.txt_TenSuKien.SelectedText = "";
			this.txt_TenSuKien.Size = new System.Drawing.Size(258, 45);
			this.txt_TenSuKien.TabIndex = 17;
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
			this.txt_DiaDiem.Location = new System.Drawing.Point(351, 365);
			this.txt_DiaDiem.Name = "txt_DiaDiem";
			this.txt_DiaDiem.PasswordChar = '\0';
			this.txt_DiaDiem.PlaceholderText = "";
			this.txt_DiaDiem.SelectedText = "";
			this.txt_DiaDiem.Size = new System.Drawing.Size(258, 45);
			this.txt_DiaDiem.TabIndex = 18;
			// 
			// datepicker_NgayDienRa
			// 
			this.datepicker_NgayDienRa.Checked = true;
			this.datepicker_NgayDienRa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.datepicker_NgayDienRa.ForeColor = System.Drawing.Color.White;
			this.datepicker_NgayDienRa.Format = System.Windows.Forms.DateTimePickerFormat.Long;
			this.datepicker_NgayDienRa.Location = new System.Drawing.Point(351, 507);
			this.datepicker_NgayDienRa.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
			this.datepicker_NgayDienRa.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
			this.datepicker_NgayDienRa.Name = "datepicker_NgayDienRa";
			this.datepicker_NgayDienRa.Size = new System.Drawing.Size(258, 36);
			this.datepicker_NgayDienRa.TabIndex = 20;
			this.datepicker_NgayDienRa.Value = new System.DateTime(2023, 11, 29, 22, 20, 38, 748);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(210, 512);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(135, 24);
			this.label1.TabIndex = 21;
			this.label1.Text = "Ngày diễn ra:";
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
			this.btn_XacNhan.Location = new System.Drawing.Point(351, 571);
			this.btn_XacNhan.Name = "btn_XacNhan";
			this.btn_XacNhan.Size = new System.Drawing.Size(180, 45);
			this.btn_XacNhan.TabIndex = 22;
			this.btn_XacNhan.Text = "Xác nhận";
			this.btn_XacNhan.Click += new System.EventHandler(this.btn_XacNhan_Click);
			// 
			// btn_DoiHinhAnh
			// 
			this.btn_DoiHinhAnh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(115)))), ((int)(((byte)(65)))));
			this.btn_DoiHinhAnh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btn_DoiHinhAnh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btn_DoiHinhAnh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btn_DoiHinhAnh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btn_DoiHinhAnh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(115)))), ((int)(((byte)(65)))));
			this.btn_DoiHinhAnh.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_DoiHinhAnh.ForeColor = System.Drawing.Color.White;
			this.btn_DoiHinhAnh.Location = new System.Drawing.Point(351, 237);
			this.btn_DoiHinhAnh.Name = "btn_DoiHinhAnh";
			this.btn_DoiHinhAnh.Size = new System.Drawing.Size(180, 45);
			this.btn_DoiHinhAnh.TabIndex = 23;
			this.btn_DoiHinhAnh.Text = "Đổi Hình";
			this.btn_DoiHinhAnh.Click += new System.EventHandler(this.btn_DoiHinhAnh_Click);
			// 
			// txt_SoVe
			// 
			this.txt_SoVe.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_SoVe.DefaultText = "";
			this.txt_SoVe.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txt_SoVe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txt_SoVe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_SoVe.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_SoVe.Enabled = false;
			this.txt_SoVe.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_SoVe.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txt_SoVe.ForeColor = System.Drawing.Color.Black;
			this.txt_SoVe.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_SoVe.Location = new System.Drawing.Point(351, 427);
			this.txt_SoVe.Name = "txt_SoVe";
			this.txt_SoVe.PasswordChar = '\0';
			this.txt_SoVe.PlaceholderText = "";
			this.txt_SoVe.SelectedText = "";
			this.txt_SoVe.Size = new System.Drawing.Size(258, 45);
			this.txt_SoVe.TabIndex = 24;
			// 
			// ChinhSuaSuKien
			// 
			this.AcceptButton = this.btn_XacNhan;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 649);
			this.Controls.Add(this.txt_SoVe);
			this.Controls.Add(this.btn_DoiHinhAnh);
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
			this.Name = "ChinhSuaSuKien";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ChinhSuaSuKien";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_ChiTiet)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lb_soVe;
		private System.Windows.Forms.Label lb_DiaDiem;
		private System.Windows.Forms.Label lb_SuKien;
		private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton2;
		private System.Windows.Forms.PictureBox pictureBox_ChiTiet;
		private Guna.UI2.WinForms.Guna2TextBox txt_TenSuKien;
		private Guna.UI2.WinForms.Guna2TextBox txt_DiaDiem;
		private Guna.UI2.WinForms.Guna2DateTimePicker datepicker_NgayDienRa;
		private System.Windows.Forms.Label label1;
		private Guna.UI2.WinForms.Guna2Button btn_XacNhan;
		private Guna.UI2.WinForms.Guna2Button btn_DoiHinhAnh;
		private CustomControls.TextBoxDigit txt_SoVe;
	}
}