using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyPhongTro.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        // GET: Admin/Home
        public ActionResult Index()
        {
            if(Session["taikhoan"] == null || (string)Session["vitri"] != "admin")
            {
                return RedirectToAction("Index", "Login", new { @area = "" });
            }
            return View();
        }
    }
}