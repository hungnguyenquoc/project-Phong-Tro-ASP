using QuanLyPhongTro.Models.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyPhongTro.Areas.Admin.Models
{
    public class ConfirmRoomModel
    {
        public int idPhong { get; set; }
        public int idUser { get; set; }
        public string tenPhong { get; set; }
        public double giaPhong { get; set; }
        public string diaChiPhong { get; set; }
        public string diaChiND { get; set; }
        public int soDT { get; set; }
        public string TenND { get; set; }
        public void AccpetRoom(int cusID, int roomID)
        {
            new ModifyBooking().UpdateStatusAcceptCustomer(cusID, roomID);
            new ModifyRoom().UpdateStatusRoom(roomID);
        }
        public void DeclineRoom (int cusID, int roomID)
        {
            new ModifyBooking().UpdateStatusDeclineCustomer(cusID, roomID);
        }
    }
}