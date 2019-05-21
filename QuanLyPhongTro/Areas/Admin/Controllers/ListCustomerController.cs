using QuanLyPhongTro.Areas.Admin.Models;
using QuanLyPhongTro.Models;
using QuanLyPhongTro.Models.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyPhongTro.Areas.Admin.Controllers
{
    public class ListCustomerController : Controller
    {
        // GET: Admin/ListCustomer
        public ActionResult Index()
        {
            if (Session["taikhoan"] == null || (string)Session["vitri"] != "admin")
            {
                return RedirectToAction("Index", "Login", new { @area = "" });
            }
            ViewBag.DanhSachKhachHang = new ModifyCustomer().GetList();
            return View();
        }
        [HttpPost]
        public JsonResult AddList(ThemNguoiDung model)
        {
            if(new ModifyAccount().CheckExistUsername(model.userName))
            {
                return Json("Username trung", JsonRequestBehavior.AllowGet);
            }
            else
            {
                new ModifyAccount().InsertDB(model.userName, model.passWord, 2);
                new ModifyCustomer().InsertDB(model.name,model.userName,model.email,model.phone,model.address,model.gender);
                return Json("", JsonRequestBehavior.AllowGet);
            }
        }
        public JsonResult Delete(int UserID)
        {
            new ModifyCustomer().Delete(UserID);
            return Json("true", JsonRequestBehavior.AllowGet);
        }
       
    }
}