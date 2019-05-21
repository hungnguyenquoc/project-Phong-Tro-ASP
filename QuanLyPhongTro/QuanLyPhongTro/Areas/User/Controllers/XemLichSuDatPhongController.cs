using QuanLyPhongTro.Models.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyPhongTro.Areas.User.Controllers
{
    public class XemLichSuDatPhongController : Controller
    {
        // GET: User/XemLichSuDatPhong
        public ActionResult Index()
        {

            if (Session["taikhoan"] == null || (string)Session["vitri"] != "user")
            {
                return RedirectToAction("Index", "Login", new { @area = "" });
            }
            ViewBag.PhongOGhep = new ModifyRoom().GetlistRoom();
            ViewBag.LichSuPhong = new ModifyBooking().GetListHistoryRoom(new ModifyCustomer().GetIDByUsername((string)Session["taikhoan"]));
            return View();
        }
        public JsonResult ShareRoom(int ID)
        {
            new ModifyRoom().UpdateStatusRoom(ID, "wait");
            return Json("", JsonRequestBehavior.AllowGet);
        }
        public JsonResult LoadInfo(int ID)
        {

            return Json(new ModifyCustomer().getInfoByID(new ModifyBooking().getUserIDOffer(ID)), JsonRequestBehavior.AllowGet);
        }
        public JsonResult RemoveOffer(int ID)
        {
            new ModifyBooking().UpdateStatus(ID, 4, 5);
            new ModifyRoom().UpdateStatusRoom(ID, "wait");
            return Json("", JsonRequestBehavior.AllowGet);
        }
        public JsonResult ConfirmOffer(int ID)
        {
            new ModifyBooking().UpdateStatus(ID, 4, 6);
            return Json("", JsonRequestBehavior.AllowGet);
        }
    }
}