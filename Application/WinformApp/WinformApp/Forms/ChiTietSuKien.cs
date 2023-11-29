using BLL;
using DAL.SuKienDatasetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformApp.Forms
{
	public partial class ChiTietSuKien : Form
	{
		private SuKienBLL suKienBLL = new SuKienBLL();
		public int id { get; set; }

		public ChiTietSuKien()
		{
			InitializeComponent();

			this.Load += ChiTietSuKien_Load;
		}

		private void ChiTietSuKien_Load(object sender, EventArgs e)
		{
			var suKien = suKienBLL.Get(id);
			string path = $@"..\..\img\{suKien.HinhAnh}";
			pictureBox_ChiTiet.Image = Image.FromFile(path);
			pictureBox_ChiTiet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			lb_DiaDiem.Text += " " + suKien.DiaDiem;
			lb_SuKien.Text += " " + suKien.TenSuKien;
			lb_soVe.Text += " " + suKien.SoLuongVe;
		}

		private void guna2ImageButton2_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}