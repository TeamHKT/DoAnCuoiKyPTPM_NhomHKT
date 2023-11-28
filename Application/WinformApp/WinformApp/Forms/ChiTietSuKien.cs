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
		private SuKienTableAdapter suKienTableAdapter = new SuKienTableAdapter();
		public int id { get; set; }

		public ChiTietSuKien()
		{
			InitializeComponent();

			//this.Load += ChiTietSuKien_Load;
		}

		//private void ChiTietSuKien_Load(object sender, EventArgs e)
		//{
		//	string imgBook = suKienTableAdapter.GetData();
		//	string path = $@"..\..\Resources\{imgBook}";
		//	pictureBox_sach.Image = Image.FromFile(path);
		//	pictureBox_sach.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		//}
	}
}