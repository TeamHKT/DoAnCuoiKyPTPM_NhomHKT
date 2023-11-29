using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformApp.Forms
{
	public partial class ThemVe : Form
	{
		public int idSuKien { get; set; }
		private VeBLL veBLL = new VeBLL();
		private SuKienBLL suKienBLL = new SuKienBLL();

		public ThemVe()
		{
			InitializeComponent();
		}

		private void guna2ImageButton1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_XacNhan_Click(object sender, EventArgs e)
		{
			try
			{
				var soVe = int.Parse(txt_SoVe.Text);
				var donGia = double.Parse(txt_DonGia.Text);
				veBLL.TaoVe(idSuKien, donGia, soVe);
				suKienBLL.CapNhatSoLuongVe(idSuKien, soVe);
				this.Close();
			}
			catch (Exception ec)
			{
				throw;
			}
		}
	}
}