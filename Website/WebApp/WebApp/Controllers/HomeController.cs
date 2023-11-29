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

        public ActionResult Thongtinnguoidung()
        {
            // Kiểm tra xem Session có tồn tại không
            if (Session["Username"] != null)
            {
                // Lấy tên người dùng từ Session
                string username = Session["Username"].ToString();

                // Tìm người dùng trong cơ sở dữ liệu bằng tên người dùng
                var nguoiDung = db.NguoiDungs.FirstOrDefault(u => u.TenNguoiDung == username);

                // Kiểm tra xem người dùng có tồn tại không
                if (nguoiDung != null)
                {
                    // Truyền người dùng vào view
                    return View(nguoiDung);
                }
                else
                {
                    // Nếu người dùng không tồn tại, có thể xử lý tương ứng, ví dụ: đăng xuất
                    return RedirectToAction("Logout");
                }
            }
            else
            {
                // Nếu Session không tồn tại, chuyển hướng đến trang đăng nhập
                return RedirectToAction("Login");
            }
        }



        public ActionResult Login()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            // Thực hiện xác thực đăng nhập
            if (IsValidLogin(username, password))
            {
                // Lưu thông tin đăng nhập vào Session
                Session["Username"] = username;

                // Đăng nhập thành công, thực hiện chuyển hướng hoặc xử lý khác
                return RedirectToAction("Index");
            }
            else
            {
                // Đăng nhập không thành công, hiển thị thông báo lỗi
                ViewBag.ErrorMessage = "Tên đăng nhập hoặc mật khẩu không đúng.";
                return View("Login"); // Trở lại trang đăng nhập
            }
        }


        private bool IsValidLogin(string username, string password)
        {
            using (var db = new QuanLySuKienEntities()) 
            {
                // Kiểm tra xem có người dùng nào có tên đăng nhập và mật khẩu tương ứng không
                var user = db.NguoiDungs.FirstOrDefault(u => u.TenNguoiDung == username && u.MatKhau == password);

                return user != null;
            }
        }

        public ActionResult Logout()
        {
            // Xóa Session để đăng xuất người dùng
            Session.Remove("Username");

            // Chuyển hướng về trang chủ hoặc trang đăng nhập
            return RedirectToAction("Index");
        }


    }
}