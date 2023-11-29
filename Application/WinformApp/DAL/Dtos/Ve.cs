using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DAL.SuKienDataset;

namespace DAL
{
	public class Ve
	{
		public int Id { get; set; }
		public string TenSuKien { get; set; }
		public double GiaVe { get; set; }
		public int IdSuKien { get; set; }
		public int TrangThai { get; set; }

		public string _TrangThai
		{
			get
			{
				if (TrangThai == 0)
				{
					return "Còn";
				}
				else
				{
					return "Hết";
				}
			}
		}

		public Ve(VeRow veRow)
		{
			Id = veRow.Id;
			GiaVe = veRow.GiaVe;
			IdSuKien = veRow.idSuKien;
			TrangThai = veRow.TrangThai;
		}
	}
}