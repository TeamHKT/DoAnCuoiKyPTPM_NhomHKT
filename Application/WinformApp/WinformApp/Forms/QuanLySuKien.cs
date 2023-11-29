using BLL;
using CustomControls;
using DAL;
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
using WinformApp.Forms;

namespace WinformApp
{
	public partial class QuanLySuKien : Form
	{
		private SuKienBLL bll_SuKien = new SuKienBLL();

		public QuanLySuKien()
		{
			InitializeComponent();
			this.Load += QuanLySuKien_Load;
		}

		private void QuanLySuKien_Load(object sender, EventArgs e)
		{
			var suKiens = bll_SuKien.GetAll();
			foreach (var item in suKiens)
			{
				Card card = new Card(item.Id, item.HinhAnh, item.TenSuKien);
				card.Tag = item.Id;
				card.Left.Click += Left_Click;
				card.Right.Text = "Cập nhật";
				flowLayoutPanel_SuKien.Controls.Add(card.GetItem());
			}
			flowLayoutPanel_SuKien.Visible = true;
		}

		private void Left_Click(object sender, EventArgs e)
		{
			Button button = (Button)sender;
			var id = (int)button.Tag;
			ChiTietSuKien f = new ChiTietSuKien();
			f.id = id;
			f.ShowDialog();
		}

		private void guna2Button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}