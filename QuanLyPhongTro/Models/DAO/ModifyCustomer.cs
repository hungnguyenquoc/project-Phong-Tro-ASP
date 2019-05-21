using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyPhongTro.Models.DAO
{
    public class ModifyCustomer
    {
        public void InsertDB (string name, string userName, string email, int phone, string address, string gender)
        {
            QuanLyPhongTroDBContext db = new QuanLyPhongTroDBContext();
            Customer cus = new Customer();
            cus.idCus = GetNextIDCustomer();
            cus.username = userName;
            cus.email = email;
            cus.phone = phone;
            cus.address = address;
            cus.gender = gender;
            cus.name = name;
            db.Customers.Add(cus);
            db.SaveChanges();
        }
        public int GetNextIDCustomer()
        {
            QuanLyPhongTroDBContext db = new QuanLyPhongTroDBContext();
            if(db.Customers.Count() == 0)
            {
                return 1;
            }
            else
            {
                List<Customer> list = db.Customers.OrderByDescending(x => x.idCus).Take(1).ToList();
                return list[0].idCus + 1;
            }
        }
        //internal void InsertDB(string userName, string email, string phone, string address, string gender)
        //{
        //    throw new NotImplementedException();
        //}
        public List<Customer> GetList()
        {
            return new QuanLyPhongTroDBContext().Customers.ToList();
        }
        // Hàm Xóa Người Dùng.
        public void Delete(int ID)
        {
            
            QuanLyPhongTroDBContext db = new QuanLyPhongTroDBContext();
            new ModifyBooking().Delete(ID);
            Customer cus = db.Customers.SingleOrDefault(x => x.idCus == ID);
            db.Customers.Remove(cus);
            db.SaveChanges();
        }


        // Hàm Cập Nhật Người Dùng
        public void AddList (string userName)
        {
            QuanLyPhongTroDBContext db = new QuanLyPhongTroDBContext();
            Customer cus = db.Customers.SingleOrDefault(x => x.username == userName);
            db.Customers.Add(cus);
            db.SaveChanges();
        }
        // Hàm use username lấy id của khách.
        public int GetIDByUsername(string userName)
        {
            QuanLyPhongTroDBContext db = new QuanLyPhongTroDBContext();
            Customer cus = db.Customers.SingleOrDefault(x => x.username == userName);
            return cus.idCus;
        }
        public string getInfoByID(int IDCus)
        {
            QuanLyPhongTroDBContext db = new QuanLyPhongTroDBContext();
            Customer cus = db.Customers.SingleOrDefault(x => x.idCus == IDCus);
            return cus.name + "-" + cus.address + "-" + cus.phone + "-" + cus.gender;
        }
    }
}