using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DAL.SuKienDataset;

namespace DAL
{
	public class SuKien
	{
		public int Id { get; set; }
		public string TenSuKien { get; set; }
		public string DiaDiem { get; set; }
		public string HinhAnh { get; set; }
		public int SoLuongVe { get; set; }

		public SuKien(SuKienRow suKien)
		{
			Id = suKien.Id;
			TenSuKien = suKien.TenSuKien;
			DiaDiem = suKien.DiaDiem;
			HinhAnh = suKien.HinhAnh;
			SoLuongVe = suKien.SoLuongVe;
		}
	}
}