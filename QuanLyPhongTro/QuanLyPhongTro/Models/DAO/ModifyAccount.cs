using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyPhongTro.Models.DAO
{
    public class ModifyAccount
    {
        public TaiKhoan selectTaiKhoan(string userName)
        {
            QuanLyPhongTroDBContext db = new QuanLyPhongTroDBContext();
            TaiKhoan tk = db.TaiKhoans.SingleOrDefault(x => x.username == userName);
            return tk;
        }
        public bool CheckUsernamePassword(string username, string password)
        {
            if (new QuanLyPhongTroDBContext().TaiKhoans.SingleOrDefault(x => x.username == username && x.password == password) != null)
                return true;
            else
                return false;
        }
        public bool CheckExistUsername(string username)
        {
            if (new QuanLyPhongTroDBContext().TaiKhoans.SingleOrDefault(x => x.username == username) == null)
            {
                return false;
            }
            else
                return true;
        }
        // Hàm cập nhật Password
        public void UpdatePassword(string username, string newpassword)
        {
            QuanLyPhongTroDBContext db = new QuanLyPhongTroDBContext();
            TaiKhoan tk = db.TaiKhoans.SingleOrDefault(x => x.username == username);
            tk.password = newpassword;
            db.SaveChanges();
        }
        // Hàm InsertDB
        public void InsertDB( string userName, string passWord, int position)
        {
            QuanLyPhongTroDBContext db = new QuanLyPhongTroDBContext();
            TaiKhoan tk = new TaiKhoan();
            tk.username = userName;
            tk.password = passWord;
            tk.position = position;
            db.TaiKhoans.Add(tk);
            db.SaveChanges();
        }
        // Hàm insertDB
        public void InsertDBCustomer (string userName)
        {
            QuanLyPhongTroDBContext db = new QuanLyPhongTroDBContext();
            TaiKhoan tk = new TaiKhoan();
            tk.username = userName;
            db.TaiKhoans.Add(tk);
            db.SaveChanges();
        }
    }
}