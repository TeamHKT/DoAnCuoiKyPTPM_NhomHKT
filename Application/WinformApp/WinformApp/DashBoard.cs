﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformApp
{
	public partial class DashBoard : Form
	{
		//Drag Form
		[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
		private static extern void ReleaseCapture();

		[DllImport("user32.DLL", EntryPoint = "SendMessage")]
		private static extern void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

		private Form currentChildForm;

		public DashBoard()
		{
			InitializeComponent();
		}

		private void guna2ImageButton2_Click(object sender, EventArgs e)
		{
			DangNhap frmdangnhap = new DangNhap();
			frmdangnhap.Show();
			this.Close();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			if (btnQuanLySuKien.Checked == true)
			{
				//ThongTinSuKien frmttsk = new ThongTinSuKien();
				//frmttsk.Show();
				this.Close();
			}
		}

		private void btnQuanLySuKien_Click(object sender, EventArgs e)
		{
			lblTieuDe.Text = "Quản lý sự kiện";
			OpenChildForm(new QuanLySuKien());
			guna2Button1.Visible = false;
			guna2Button2.Visible = false;
		}

		private void btnQuanLyVe_Click(object sender, EventArgs e)
		{
			lblTieuDe.Text = "Quản lý vé";
			OpenChildForm(new QuanLyVe());
			guna2Button1.Visible = false;
			guna2Button2.Visible = false;
		}

		private void guna2ImageButton1_Click(object sender, EventArgs e)
		{
			guna2Button1.Visible = true;
			guna2Button2.Visible = true;
			lblTieuDe.Text = null;
			CloseChildForm();
		}


		private void guna2Button1_Click(object sender, EventArgs e)
		{
			lblTieuDe.Text = "Quản lý sự kiện";
			OpenChildForm(new QuanLySuKien());
			guna2Button1.Visible = false;
			guna2Button2.Visible = false;
		}

		private void guna2Button2_Click(object sender, EventArgs e)
		{
			lblTieuDe.Text = "Quản lý Vé";
			OpenChildForm(new QuanLyVe());
			guna2Button1.Visible = false;
			guna2Button2.Visible = false;
		}


		private void OpenChildForm(Form childform)
		{
			if (currentChildForm != null)
			{
				currentChildForm.Close();
			}
			currentChildForm = childform;
			childform.TopLevel = false;
			childform.FormBorderStyle = FormBorderStyle.None;
			childform.Dock = DockStyle.Fill;
			childform.Size = new Size(guna2Panel2.Size.Width, guna2Panel2.Size.Height);
			guna2Panel2.Controls.Add(childform);
			guna2Panel2.Tag = childform;
			childform.BringToFront();
			childform.Show();
		}

		private void CloseChildForm()
		{
			if (currentChildForm != null)
			{
				currentChildForm.Close();
				currentChildForm = null; // Đặt currentChildForm thành null để không có form con nào được theo dõi.
			}
		}

		private void lblTieuDe_MouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}
	}
}