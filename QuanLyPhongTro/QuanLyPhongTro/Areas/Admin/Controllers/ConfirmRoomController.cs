using QuanLyPhongTro.Areas.Admin.Models;
using QuanLyPhongTro.Models.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyPhongTro.Areas.Admin.Controllers
{
    public class ConfirmRoomController : Controller
    {
        // GET: Admin/ConfirmRoom
        public ActionResult Index()
        {
            if(Session["taikhoan"] == null || (string)Session["vitri"] != "admin")
            {
                return RedirectToAction("Index", "Login", new { @area = "" });
            }
            ViewBag.ListRoom = new ModifyBooking().GetListToConfirmRoomForAdmin();
            return View();
        }
        public JsonResult Accept(int IDCus, int IDRoom)
        {
            new ConfirmRoomModel().AccpetRoom(IDCus, IDRoom);
            return Json("", JsonRequestBehavior.AllowGet);
        }
        public JsonResult Decline(int IDCus, int IDRoom)
        {
            new ConfirmRoomModel().DeclineRoom(IDCus, IDRoom); 
            return Json("", JsonRequestBehavior.AllowGet);
        }
    }
}