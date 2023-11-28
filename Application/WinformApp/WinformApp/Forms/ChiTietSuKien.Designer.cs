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
			this.label1 = new System.Windows.Forms.Label();
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
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(210, 387);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(81, 24);
			this.label1.TabIndex = 11;
			this.label1.Text = "Số vé:  ";
			// 
			// ChiTietSuKien
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lb_DiaDiem);
			this.Controls.Add(this.lb_SuKien);
			this.Controls.Add(this.guna2ImageButton2);
			this.Controls.Add(this.pictureBox_ChiTiet);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "ChiTietSuKien";
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
		private System.Windows.Forms.Label label1;
	}
}