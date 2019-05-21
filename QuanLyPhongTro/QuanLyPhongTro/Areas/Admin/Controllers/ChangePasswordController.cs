using QuanLyPhongTro.Areas.Admin.Models;
using QuanLyPhongTro.Models.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyPhongTro.Areas.Admin.Controllers
{
    public class ChangePasswordController : Controller
    {
        // GET: Admin/ChangePassword
        public ActionResult Index()
        {
            if (Session["taikhoan"] == null || (string)Session["vitri"] != "admin")
            {
                return RedirectToAction("Index", "Login", new { @area = "" });
            }
            return View();
            
        }
        public JsonResult ChangePasswordVerify(ChangePasswordModel model)
        {
            if (new ModifyAccount().CheckUsernamePassword((string)Session["taikhoan"], model.matKhauCu))
            {
                new ModifyAccount().UpdatePassword((string)Session["taikhoan"],model.matKhauMoi);
                return Json("", JsonRequestBehavior.AllowGet);
            }
            else
                return Json("false", JsonRequestBehavior.AllowGet);
        }
    }
}