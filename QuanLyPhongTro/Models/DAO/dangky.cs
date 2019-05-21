using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuanLyPhongTro.Models.DAO
{
    public class dangky
    {
        [Required(ErrorMessage = "bug")]
        public string userName { get; set; }
        [Required(ErrorMessage = "bug")]
        public string passWord { get; set; }
        [Required(ErrorMessage = "bug")]
        public string name { get; set; }
        [Required(ErrorMessage = "bug")]
        public string email { get; set; }
        [Required(ErrorMessage = "bug")]
        public int phone { get; set; }
        [Required(ErrorMessage ="fsdf")]
        public string address { get; set; }
        [Required(ErrorMessage = "fsdf")]
        public string gender { get; set; }
        
    }
}