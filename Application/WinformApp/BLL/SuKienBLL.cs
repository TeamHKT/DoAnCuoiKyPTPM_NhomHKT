using DAL;
using DAL.SuKienDatasetTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL
{
	public class SuKienBLL : IRepository<SuKien>
	{
		private SuKienTableAdapter tableAdapter = new SuKienTableAdapter();
		private VeBLL VeBLL = new VeBLL();

		public SuKienBLL()
		{ }

		public SuKien Get(int id)
		{
			var suKiens = tableAdapter.GetData().ToList();
			foreach (var item in suKiens)
			{
				if (item.Id == id)
				{
					SuKien suKien = new SuKien(item);

					return suKien;
				}
			}
			return null;
		}

		public List<SuKien> GetAll()
		{
			var list = new List<SuKien>();
			var suKiens = tableAdapter.GetData().ToList();
			foreach (var item in suKiens)
			{
				SuKien suKien = new SuKien(item);
				list.Add(suKien);
			}
			return list;
		}

		public bool CapNhatSuKien(int id, string tenSuKien, string diaDiem, string ngayDienRa, int soVe, string hinhAnh)
		{
			try
			{
				var list = tableAdapter.GetData().ToList();
				foreach (var item in list)
				{
					if (item.Id == id)
					{
						item.TenSuKien = tenSuKien;
						item.DiaDiem = diaDiem;
						item.NgayToChuc = DateTime.Parse(ngayDienRa);
						item.SoLuongVe = soVe;
						if (!string.IsNullOrEmpty(hinhAnh))
						{
							item.HinhAnh = hinhAnh;
						}
						tableAdapter.Update(item);
						return true;
					}
				}
				return false;
			}
			catch
			{
				return false;
			}
		}

		public bool CapNhatSoLuongVe(int id, int soVe)
		{
			try
			{
				var list = tableAdapter.GetData().ToList();
				foreach (var item in list)
				{
					if (item.Id == id)
					{
						item.SoLuongVe += soVe;
						tableAdapter.Update(item);
						return true;
					}
				}
				return false;
			}
			catch
			{
				return false;
			}
		}

		public bool ThemSuKien(string tenSuKien, string diaDiem, string ngayDienRa, int soVe, string hinhAnh, double donGia)
		{
			try
			{
				var id = tableAdapter.InsertAndGetObject(tenSuKien, diaDiem, soVe, hinhAnh, DateTime.Parse(ngayDienRa));
				VeBLL.TaoVe(id, donGia, soVe);
				return true;
			}
			catch
			{
				return false;
			}
		}

		public bool XoaSuKien(int id)
		{
			try
			{
				tableAdapter.DeleteById(id);
				return true;
			}
			catch
			{
				return false;
			}
		}
	}
}