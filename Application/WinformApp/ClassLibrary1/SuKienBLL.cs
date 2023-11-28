using DAL.SuKienDatasetTableAdapters;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using System.Threading;

namespace BLL
{
	public class SuKienBLL : IRepository<SuKien>
	{
		private SuKienTableAdapter tableAdapter = new SuKienTableAdapter();

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
	}
}