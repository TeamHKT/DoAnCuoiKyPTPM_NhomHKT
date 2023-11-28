using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
	public interface IRepository<T> where T : class
	{
		T Get(int id);

		List<T> GetAll();
	}
}