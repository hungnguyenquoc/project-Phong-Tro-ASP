namespace QuanLyPhongTro.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BookingRoom")]
    public partial class BookingRoom
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idBook { get; set; }

        public int idCus { get; set; }

        public int idRoom { get; set; }

        public int Status { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Room Room { get; set; }
    }
}
