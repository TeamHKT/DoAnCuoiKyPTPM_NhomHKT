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
				card.Right.Text = "Cập nhật";
				flowLayoutPanel_SuKien.Controls.Add(card.GetItem());
			}
			flowLayoutPanel_SuKien.Visible = true;
		}

		private void guna2Button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}