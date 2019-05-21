using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuanLyPhongTro.Areas.User.Models
{
    public class NguoiDung
    {

        [Required(ErrorMessage = "Vui lòng nhập tài khoản")]
        public string userName { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập mật khẩu")]
        public string passWord { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập họ tên")]
        public string email{ get; set; }
        [Required(ErrorMessage = "Vui lòng nhập email")]
        public string phone { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập email")]
        public string address { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập email")]
        public string gender { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập email")]
        public string name { get; set; }
        
    }
}