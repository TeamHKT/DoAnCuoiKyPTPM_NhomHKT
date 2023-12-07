
using BLL;
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
	public partial class ThemSuKien : Form
	{
		private SuKienBLL suKienBLL = new SuKienBLL();

		public ThemSuKien()
		{
			InitializeComponent();
		}

		private string filename = "";
		private string path = $@"..\..\img\";
		private Bitmap myBitmap;

		private void btn_ThemHinh_Click(object sender, EventArgs e)
		{
			OpenFileDialog opnfd = new OpenFileDialog();
			opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
			if (opnfd.ShowDialog() == DialogResult.OK)
			{
				pictureBox_ChiTiet.Image = new Bitmap(opnfd.FileName);
				filename = opnfd.SafeFileName;
				pictureBox_ChiTiet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
				path += filename;
				myBitmap = new Bitmap(opnfd.FileName);
			}
		}

		private void btn_XacNhan_Click(object sender, EventArgs e)
		{
			try
			{
				if (!string.IsNullOrEmpty(filename))
				{
					myBitmap.Save(path);
				}
			}
			catch
			{
			}
			var tenSuKien = txt_TenSuKien.Text;
			var diaDiem = txt_DiaDiem.Text;
			var ngayDienRa = datepicker_NgayDienRa.Value.ToString("dd/MM/yyyy");
			if (string.IsNullOrEmpty(tenSuKien) || string.IsNullOrEmpty(diaDiem) || string.IsNullOrEmpty(txt_SoVe.Text) || string.IsNullOrEmpty(txt_DonGia.Text) || string.IsNullOrEmpty(ngayDienRa))
			{
				MessageBox.Show("Vui lòng nhập dữ liệu đầy đủ", "Thông báo");
				return;
			}
			var soVe = int.Parse(txt_SoVe.Text);
			var donGiaVe = double.Parse(txt_DonGia.Text);
			if (!suKienBLL.ThemSuKien(tenSuKien, diaDiem, ngayDienRa, soVe, filename, donGiaVe))
			{
				MessageBox.Show("Thêm thất bại, vui lòng thử lại sau", "Thất bại");
				return;
			}
			this.Close();
		}

		private void guna2ImageButton2_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}