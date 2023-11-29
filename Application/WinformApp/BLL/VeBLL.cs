using DAL;
using DAL.SuKienDatasetTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
	public class VeBLL
	{
		private VeTableAdapter tableAdapter = new VeTableAdapter();

		public void TaoVe(int IdSuKien, double DonGia, int SoVe)
		{
			for (int i = 0; i < SoVe; i++)
			{
				tableAdapter.Insert(DonGia, IdSuKien, 0);
			}
		}

		public List<Ve> GetVeBySuKien(int IdSuKien, string tenSuKien)
		{
			var list = new List<Ve>();
			var rows = tableAdapter.GetData().ToList();
			foreach (var row in rows)
			{
				if (row.idSuKien == IdSuKien)
				{
					var ve = new Ve(row);
					ve.TenSuKien = tenSuKien;
					list.Add(ve);
				}
			}
			return list;
		}
	}
}