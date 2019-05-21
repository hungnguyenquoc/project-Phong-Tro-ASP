using QuanLyPhongTro.Models.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuanLyPhongTro.Areas.User.Models
{
    public class ThemPhongTro
    {
        [Required(ErrorMessage = "Vui lòng nhập tên phòng")]
        public string tenPhong { get; set; }
        [Required(ErrorMessage = "Vui lòng giá phòng")]
        public double giaPhong { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập địa chỉ")]
        public string diaChi { get; set; }

        
    }
}