using QuanLyPhongTro.Areas.Admin.Models;
using QuanLyPhongTro.Models.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyPhongTro.Areas.Admin.Controllers
{
    public class ListRoomController : Controller
    {
        // GET: Admin/ListRoom
        public ActionResult Index()
        {
            if (Session["taikhoan"] == null || (string)Session["vitri"] != "admin")
            {
                return RedirectToAction("Index", "Login", new { @area = "" });
            }
            ViewBag.ListRoomAdmin = new ModifyRoom().GetlistRoom();
            return View();
        }
        public JsonResult InsertRoom(ListRoomDetailModel model)
        {
            new ListRoomDetailModel().InsertRoom(model);
            return Json("", JsonRequestBehavior.AllowGet);
        }
    }
}
