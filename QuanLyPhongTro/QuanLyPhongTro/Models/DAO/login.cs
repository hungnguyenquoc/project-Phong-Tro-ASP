using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuanLyPhongTro.Models.DAO
{
    public class login
    {
        [Required(ErrorMessage ="Vui lòng nhập tài khoản")]
        public string userName { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập mật khẩu")]
        public string passWord { get; set; }

        public int SelectTaiKhoan(string userName, string passWord)
        {
            QuanLyPhongTroDBContext db = new QuanLyPhongTroDBContext();
            TaiKhoan tk = db.TaiKhoans.SingleOrDefault(x => x.username == userName);

            if (tk.password.Split(' ')[0] == passWord)
            {
                return tk.position;
            }
            return 0;


        }


    }
}