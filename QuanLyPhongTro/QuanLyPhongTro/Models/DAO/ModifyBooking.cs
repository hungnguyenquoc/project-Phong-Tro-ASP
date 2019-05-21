using QuanLyPhongTro.Areas.Admin.Models;
using QuanLyPhongTro.Areas.User.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyPhongTro.Models.DAO
{
    public class ModifyBooking
    {
        public List<BookingRoom> GetListForUser(int IDCus)
        {
            return new QuanLyPhongTroDBContext().BookingRooms.Where(x => x.idCus == IDCus).ToList();
        }
        public List<ConfirmRoomModel> GetListToConfirmRoomForAdmin()
        {
            return new QuanLyPhongTroDBContext().BookingRooms.Where(x => x.Status == 1).Select(x => new ConfirmRoomModel { idPhong = x.idRoom, idUser = x.idCus, diaChiPhong = x.Room.address, diaChiND = x.Customer.address, tenPhong = x.Room.nameroom, TenND = x.Customer.name, giaPhong = x.Room.price, soDT = x.Customer.phone }).ToList();
        }
        public void InsertDB(int idCus, int idRoom)
        {
            QuanLyPhongTroDBContext db = new QuanLyPhongTroDBContext();
            BookingRoom bR = new BookingRoom();
            bR.idBook = GetNextID();
            bR.idCus = idCus;
            bR.idRoom = idRoom;
            bR.Status = 1;
            db.BookingRooms.Add(bR);
            db.SaveChanges();
        }
        public int GetNextID()
        {
            QuanLyPhongTroDBContext db = new QuanLyPhongTroDBContext();
            if(db.BookingRooms.Count() == 0)
            {
                return 1;
            }
            else
            {
                List<BookingRoom> list = db.BookingRooms.OrderByDescending(x => x.idBook).Take(1).ToList();
                return list[0].idBook + 1;

            }
        }
        public bool CheckNumberOfRoom(int IDcus)
        {
            if (new QuanLyPhongTroDBContext().BookingRooms.Where(x => x.idCus == IDcus).ToList().Count >= 2)
                return false;
            else
                return true;
        }
        public void UpdateStatusAcceptCustomer(int CusID, int RoomID)
        {
            QuanLyPhongTroDBContext db = new QuanLyPhongTroDBContext();
            BookingRoom br = db.BookingRooms.SingleOrDefault(x => x.idCus == CusID && x.idRoom == RoomID);
            br.Status = 2;
            db.SaveChanges();
        }
        public void UpdateStatusDeclineCustomer(int CusID, int RoomID)
        {
            QuanLyPhongTroDBContext db = new QuanLyPhongTroDBContext();
            BookingRoom br = db.BookingRooms.SingleOrDefault(x => x.idCus == CusID && x.idRoom == RoomID);
            br.Status = 3;
            db.SaveChanges();
        }
        // Hàm xem lịch sử đặt phòng.
        public List<XemLichSuDatPhong> GetListHistoryRoom(int IDCus) {
            QuanLyPhongTroDBContext db = new QuanLyPhongTroDBContext();
            return db.BookingRooms.Where(x => x.idCus == IDCus).Select(x => new XemLichSuDatPhong { ID = x.idRoom, diaChi = x.Room.address, tenPhong = x.Room.nameroom, trangThai = x.Status }).ToList();
        }
        public void Delete(int IDcus)
        {
            QuanLyPhongTroDBContext db = new QuanLyPhongTroDBContext();
            List<BookingRoom> list = db.BookingRooms.Where(x => x.idCus == IDcus).ToList();
            if(list.Count()==0)
            {
                //
            }
            else
            {
                for (int i = 0; i < list.Count(); i++)
                {
                    db.BookingRooms.Remove(list[i]);
                    db.SaveChanges();
                }
            }
        }
        public int getUserIDOffer(int IDRoom)
        {
            QuanLyPhongTroDBContext db = new QuanLyPhongTroDBContext();
            BookingRoom bk = db.BookingRooms.SingleOrDefault(x => x.idRoom == IDRoom && x.Status == 4);
            return bk.idCus;
        }
        public void InsertOGhep(int IDRoom, int IDcus)
        {
            QuanLyPhongTroDBContext db = new QuanLyPhongTroDBContext();
            BookingRoom bk = new BookingRoom();
            bk.idBook = GetNextID();
            bk.idCus = IDcus;
            bk.idRoom = IDRoom;
            bk.Status = 4;
            db.BookingRooms.Add(bk);
            db.SaveChanges();
        }
        public void UpdateStatus(int IDRoom, int IDStatusIn, int IDStatusOut)
        {
            QuanLyPhongTroDBContext db = new QuanLyPhongTroDBContext();
            BookingRoom bk = db.BookingRooms.SingleOrDefault(x => x.idRoom == IDRoom && x.Status == IDStatusIn);
            bk.Status = IDStatusOut;
            db.SaveChanges();
        }
    }
}