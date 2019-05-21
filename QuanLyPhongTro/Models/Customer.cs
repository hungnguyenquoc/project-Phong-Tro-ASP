namespace QuanLyPhongTro.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customer")]
    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            BookingRooms = new HashSet<BookingRoom>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idCus { get; set; }

        [Required]
        [StringLength(50)]
        public string username { get; set; }

        [Required]
        [StringLength(50)]
        public string email { get; set; }

        public int phone { get; set; }

        [Required]
        [StringLength(50)]
        public string address { get; set; }

        [Required]
        [StringLength(10)]
        public string gender { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookingRoom> BookingRooms { get; set; }

        public virtual TaiKhoan TaiKhoan { get; set; }
    }
}
