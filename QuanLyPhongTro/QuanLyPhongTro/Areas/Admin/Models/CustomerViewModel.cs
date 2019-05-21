using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyPhongTro.Areas.Admin.Models
{
    public class CustomerViewModel
    {
        public int IDCus { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public int phone { get; set; }
        public string address { get; set; }
        public string gender { get; set; }
        public string name { get; set; }
        // 
    }
}