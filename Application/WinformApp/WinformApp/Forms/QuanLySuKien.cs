using BLL;
using CustomControls;
using System;
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
			LoadDuLieu();
		}

		private void LoadDuLieu()
		{
			flowLayoutPanel_SuKien.Controls.Clear();
			var suKiens = bll_SuKien.GetAll();
			foreach (var item in suKiens)
			{
				Card card = new Card(item.Id, item.HinhAnh, item.TenSuKien);
				card.Tag = item.Id;
				card.Left.Click += Left_Click;
				card.Right.Click += Right_Click;
				card.Right.Text = "Cập nhật";
				flowLayoutPanel_SuKien.Controls.Add(card.GetItem());
			}
			flowLayoutPanel_SuKien.Visible = true;
		}

		private void Right_Click(object sender, EventArgs e)
		{
			Button button = (Button)sender;
			var id = (int)button.Tag;
			ChinhSuaSuKien f = new ChinhSuaSuKien();
			f.id = id;
			f.ShowDialog();
			LoadDuLieu();
		}

		private void Left_Click(object sender, EventArgs e)
		{
			Button button = (Button)sender;
			var id = (int)button.Tag;
			ChiTietSuKien f = new ChiTietSuKien();
			f.id = id;
			f.ShowDialog();
			LoadDuLieu();
		}

		private void guna2Button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_ThemSuKien_Click(object sender, EventArgs e)
		{
			ThemSuKien f = new ThemSuKien();
			f.ShowDialog();
			LoadDuLieu();
		}
	}
}