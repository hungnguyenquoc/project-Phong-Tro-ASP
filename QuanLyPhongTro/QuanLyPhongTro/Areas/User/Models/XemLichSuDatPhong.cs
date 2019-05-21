using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyPhongTro.Areas.User.Models
{
    public class XemLichSuDatPhong
    {
        public int ID { get; set; }
        public string tenPhong { get; set; }
        public string diaChi { get; set; }
        public int trangThai { get; set; }
    }
}