using QuanLyPhongTro.Models.DAO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace QuanLyPhongTro.Areas.Admin.Models
{
    public class ListRoomDetailModel
    {
        public ListRoomModel Insert { get; set; }
        public HttpPostedFileWrapper ImageGet { get; set; }
        public void InsertRoom(ListRoomDetailModel model)
        {
            if (model.ImageGet != null)
            {
                model.Insert.hinhAnh = GetByteArray(model.ImageGet);
            }
            new ModifyRoom().Insert(model.Insert);
        }
        public byte[] GetByteArray(HttpPostedFileWrapper file)
        {
            var files = file;
            byte[] imagebyte = null;
            BinaryReader reader = new BinaryReader(files.InputStream);
            imagebyte = reader.ReadBytes(files.ContentLength);
            return imagebyte;
        }
    }
}