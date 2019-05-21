using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuanLyPhongTro.Models.DAO
{
    public class register
    {
        [Required(ErrorMessage = "Vui lòng nhập tài khoản")]
        public string userName { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập mật khẩu")]
        public string passWord { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập họ tên")]
        public string name { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập email")]
        public string email { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập số điện thoại")]
        [RegularExpression("^(09|01[2|6|8|9])+([0-9]{8})$",ErrorMessage ="Bạn nhập không đúng định dạng số điện thoại")]
        public int phone { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập địa chỉ")]
        public string address { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập giới tính")]
        public string gender { get; set; }

        public string Register(register model)
        {
            QuanLyPhongTroDBContext db = new QuanLyPhongTroDBContext();
            TaiKhoan tk = db.TaiKhoans.SingleOrDefault(x => x.username == userName);
            if(tk == null)
            {
                ModifyAccount modifyAccount = new ModifyAccount();
                ModifyCustomer modifyCustomer = new ModifyCustomer();
                modifyAccount.InsertDB(model.userName, model.passWord, 2);
                modifyCustomer.InsertDB(model.name, model.userName, model.email, model.phone, model.address,model.gender);
                return "true";
            }
            else
            {
                return "false";
            }
        }
    }
}