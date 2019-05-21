using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuanLyPhongTro.Areas.Admin.Models
{
    public class ListRoomModel
    {

        [Required(ErrorMessage = "Vui lòng nhập mật khẩu")]
        public string tenPhong { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập họ tên")]
        public float gia { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập email")]
        public string diaChi { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập email")]
        public string viTri { get; set; }
        public byte[] hinhAnh { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập email")]
        public int soDienThoai { get; set; }
    }
}