using QuanLyPhongTro.Areas.User.Models;
using QuanLyPhongTro.Models.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyPhongTro.Areas.User.Controllers
{
    public class DatPhongController : Controller
    {
        // GET: User/DatPhong
        public ActionResult Index()
        {
            if(Session["taikhoan"] == null || (string)Session["vitri"] != "user")
            {
                return RedirectToAction("Index","Login",new { @area = ""});
            }
            ViewBag.DatPhong = new ModifyRoom().GetlistRoom();
            ViewBag.listPhongDoi = new ModifyRoom().GetlistRoom();
            ViewBag.ListPhongDaDat = new ModifyBooking().GetListForUser(new ModifyCustomer().GetIDByUsername((string)Session["taikhoan"]));
            return View();
        }
        public JsonResult BookingRoom(int ID)
        {
            BookingRoom br = new BookingRoom();
            br.XuLyDatPhong(ID, Session["taikhoan"].ToString());
            return Json("", JsonRequestBehavior.AllowGet);
        }
        public JsonResult CheckNumberOfRoom()
        {
            if (new ModifyBooking().CheckNumberOfRoom(new ModifyCustomer().GetIDByUsername((string)Session["taikhoan"])))
                return Json("true", JsonRequestBehavior.AllowGet);
            else
                return Json("false", JsonRequestBehavior.AllowGet);

        }
        public JsonResult ConfirmRoomOGhep(int ID)
        {
            new ModifyBooking().InsertOGhep(ID, new ModifyCustomer().GetIDByUsername((string)Session["taikhoan"]));
            new ModifyRoom().UpdateStatusRoom(ID, "full");
            return Json("", JsonRequestBehavior.AllowGet);
        }
    }
}