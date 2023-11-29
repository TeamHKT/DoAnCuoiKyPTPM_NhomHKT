using BLL;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinformApp.Forms
{
	public partial class ChinhSuaSuKien : Form
	{
		private SuKienBLL suKienBLL = new SuKienBLL();
		public int id { get; set; }

		public ChinhSuaSuKien()
		{
			InitializeComponent();
			this.Load += ChinhSuaSuKien_Load;
		}

		private void ChinhSuaSuKien_Load(object sender, EventArgs e)
		{
			var suKien = suKienBLL.Get(id);
			string _path = $@"..\..\img\{suKien.HinhAnh}";
			pictureBox_ChiTiet.Image = Image.FromFile(_path);
			pictureBox_ChiTiet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			txt_TenSuKien.Text = suKien.TenSuKien;
			txt_DiaDiem.Text = suKien.DiaDiem;
			txt_SoVe.Text = suKien.SoLuongVe.ToString();
			datepicker_NgayDienRa.Text = suKien.NgayToChuc.ToString("dd/MM/yyyy");
		}

		private void guna2ImageButton2_Click(object sender, EventArgs e)
		{
			this.Close();
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
			var soVe = int.Parse(txt_SoVe.Text);
			var ngayDienRa = datepicker_NgayDienRa.Value.ToString("dd/MM/yyyy");
			if (!suKienBLL.CapNhatSuKien(id, tenSuKien, diaDiem, ngayDienRa, soVe, filename))
			{
				MessageBox.Show("Cập nhật thất bại, vui lòng thử lại sau", "Thất bại");
				return;
			}
			this.Close();
		}

		private string filename = "";
		private string path = $@"..\..\img\";
		private Bitmap myBitmap;

		private void btn_DoiHinhAnh_Click(object sender, EventArgs e)
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

		private void txt_SoVe_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
				e.Handled = false;
			else
				e.Handled = true;
		}

		private void txt_SoVe_TextChanged(object sender, EventArgs e)
		{
		}
	}
}