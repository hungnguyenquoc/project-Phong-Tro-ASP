using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuanLyPhongTro.Areas.Admin.Models
{
    public class ChangePasswordModel
    {
        [Required(ErrorMessage ="Chua nhap mat khau")]
        public string matKhauCu { get; set; }
        [Required(ErrorMessage ="Chua nhap mat khau moi")]
        public string matKhauMoi { get; set; }
        [Required(ErrorMessage ="Nhaapj lai mat khau moi")]
        [Compare("matKhauMoi",ErrorMessage ="xaC NHAN MAT KHAU K TRUNG VOI MK MOI")]
        public string xacNhanMKMoi { get; set; }
    }
}