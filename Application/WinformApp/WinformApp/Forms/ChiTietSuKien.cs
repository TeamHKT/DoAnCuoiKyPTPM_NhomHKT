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
			LoadDuLieu();
		}

		private void LoadDuLieu()
		{
			var suKien = suKienBLL.Get(id);
			string path = $@"..\..\img\{suKien.HinhAnh}";
			pictureBox_ChiTiet.Image = Image.FromFile(path);
			pictureBox_ChiTiet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			lb_DiaDiem.Text = "Địa Điểm: " + suKien.DiaDiem;
			lb_SuKien.Text = "Sự Kiện " + suKien.TenSuKien;
			lb_soVe.Text = "Tổng số vé: " + suKien.SoLuongVe;
			lb_ngayDienRa.Text = "Ngày diễn ra: " + suKien.NgayToChuc.ToString("dd/MM/yyyy");
		}

		private void guna2ImageButton2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_XoaSuKien_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Bạn muốn xóa sự kiện này?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
			{
				if (suKienBLL.XoaSuKien(id))
				{
					this.Close();
					return;
				}
				MessageBox.Show("Xóa không thành công vui lòng thử lại sau", "Thất bại");
			}
		}

		private void btn_ThemVe_Click(object sender, EventArgs e)
		{
			ThemVe themVe = new ThemVe();
			themVe.idSuKien = id;
			themVe.ShowDialog();
			LoadDuLieu();
		}
	}
}