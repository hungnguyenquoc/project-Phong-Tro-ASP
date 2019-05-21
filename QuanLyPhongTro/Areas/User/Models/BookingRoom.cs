using QuanLyPhongTro.Models.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyPhongTro.Areas.User.Models
{
    public class BookingRoom
    {
        public void XuLyDatPhong(int idPhong, string userName)
        {
            int IDCus = 0;
            ModifyCustomer mC = new ModifyCustomer();
            IDCus = mC.GetIDByUsername(userName);
            ModifyBooking mB = new ModifyBooking();
            mB.InsertDB(IDCus, idPhong);
            //int ID = new ModifyCustomer().GetIDByUsername(userName);
        }
    }
}