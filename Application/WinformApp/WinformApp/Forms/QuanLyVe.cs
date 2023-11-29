using BLL;
using DAL;
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
	public partial class QuanLyVe : Form
	{
		private SuKienBLL suKienBLL = new SuKienBLL();
		private VeBLL veBLL = new VeBLL();

		public QuanLyVe()
		{
			InitializeComponent();
			this.Load += QuanLyVe_Load;
			cbb_SuKien.SelectionChangeCommitted += Cbb_SuKien_SelectionChangeCommitted;
		}

		private void Cbb_SuKien_SelectionChangeCommitted(object sender, EventArgs e)
		{
			var idSuKien = int.Parse(cbb_SuKien.SelectedValue.ToString());
			var suKien = (SuKien)cbb_SuKien.SelectedItem;
			var listVe = veBLL.GetVeBySuKien(idSuKien, suKien.TenSuKien);
			dgv_Ve.DataSource = listVe;
			dgv_Ve.Columns["Id"].Visible = false;
			dgv_Ve.Columns["IdSuKien"].Visible = false;
			dgv_Ve.Columns["TrangThai"].Visible = false;
			//
			dgv_Ve.Columns["GiaVe"].HeaderText = "Giá vé";
			dgv_Ve.Columns["TenSuKien"].HeaderText = "Tên sự kiện";
			dgv_Ve.Columns["_TrangThai"].HeaderText = "Trạng thái";

		}

		private void QuanLyVe_Load(object sender, EventArgs e)
		{
			var listSuKien = suKienBLL.GetAll();
			cbb_SuKien.DataSource = listSuKien;
			cbb_SuKien.ValueMember = "Id";
			cbb_SuKien.DisplayMember = "TenSuKien";
		}
	}
}