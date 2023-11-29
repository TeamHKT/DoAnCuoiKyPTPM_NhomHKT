using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
	public class HomeController : Controller
	{
        private QuanLySuKienEntities db = new QuanLySuKienEntities(); // Tên của bạn có thể khác

        public ActionResult Index()
        {
            var data = db.SuKiens.ToList();
            return View(data);
        }

        public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
	}
}