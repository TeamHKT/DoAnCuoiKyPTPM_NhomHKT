using System;

namespace DAL
{
	public class ChiTietVe
	{
		public int Id { get; set; }
		public DateTime NgayDat { get; set; }
		public int IdNguoiDung { get; set; }
		public int IdVe { get; set; }
	}
}