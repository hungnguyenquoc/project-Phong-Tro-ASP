using QuanLyPhongTro.Models.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyPhongTro.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
    
        public JsonResult VerifyLogin (login modal)
        {
            login lg = new login();
            int s = lg.SelectTaiKhoan(modal.userName, modal.passWord);
           
            if ( s == 1)
            {
                Session["taikhoan"] = modal.userName;
                Session["vitri"] = "admin";
            }
            else if ( s == 2)
            {
                Session["taikhoan"] = modal.userName;
                Session["vitri"] = "user";
            }
            else
            {
                //
            }
            return Json(s, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Logout()
        {
            Session.Abandon();
            Session.Clear();
            return RedirectToAction("Index", "Home", "Home");
        }
    }
}