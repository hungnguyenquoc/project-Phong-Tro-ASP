using QuanLyPhongTro.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;

namespace QuanLyPhongTro.Models.DAO
{
    public class ModifyRoom
    {
        public List<Room> GetlistRoom()
        {
            return new QuanLyPhongTroDBContext().Rooms.ToList();
        }
        public void UpdateStatusRoom(int RoomID)
        {
            QuanLyPhongTroDBContext db = new QuanLyPhongTroDBContext();
            Room r = db.Rooms.SingleOrDefault(x => x.idRoom == RoomID);
            r.status = "owner";
            db.SaveChanges();
        }
        public void UpdateStatusRoom(int RoomID, string Status)
        {
            QuanLyPhongTroDBContext db = new QuanLyPhongTroDBContext();
            Room r = db.Rooms.SingleOrDefault(x => x.idRoom == RoomID);
            r.status = Status;
            db.SaveChanges();
        }
        //
        public void Delete(int ID)
        {

            QuanLyPhongTroDBContext db = new QuanLyPhongTroDBContext();
            Customer cus = db.Customers.SingleOrDefault(x => x.idCus == ID);
            db.Customers.Remove(cus);
            db.SaveChanges();
            //new ModifyBooking().Delete(ID);
            //Customer cus = db.Customers.SingleOrDefault(x => x.idCus == ID);
            //db.Customers.Remove(cus);
            //db.SaveChanges();
        }
        // 
        public void Insert(ListRoomModel model)
        {
            QuanLyPhongTroDBContext db = new QuanLyPhongTroDBContext();
            Room r = new Room();
            r.idRoom = GetNextID();
            r.nameroom = model.tenPhong;
            r.price = model.gia;
            r.address = model.diaChi;
            r.location = model.viTri;
            if (model.hinhAnh != null){
                r.image = model.hinhAnh;
            }
            r.status = "empty";
            r.phone = model.soDienThoai;
            db.Rooms.Add(r);
            db.SaveChanges();
        }
        //
        public int GetNextID()
        {
            List<Room> list = new QuanLyPhongTroDBContext().Rooms.OrderByDescending(x => x.idRoom).Take(1).ToList();
            return list[0].idRoom + 1;
        }

    }
}