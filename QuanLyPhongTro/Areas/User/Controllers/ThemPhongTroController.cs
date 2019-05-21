using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyPhongTro.Areas.User.Controllers
{
    public class ThemPhongTroController : Controller
    {
        // GET: User/ThemPhongTro
        public ActionResult Index()
        {
            if (Session["taikhoan"] == null || (string)Session["vitri"] != "user")
            {
                return RedirectToAction("Index", "Login", new { @area = "" });
            }
            return View();
        }

            
    
    }
}