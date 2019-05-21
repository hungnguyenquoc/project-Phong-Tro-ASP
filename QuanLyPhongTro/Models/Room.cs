namespace QuanLyPhongTro.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Room")]
    public partial class Room
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Room()
        {
            BookingRooms = new HashSet<BookingRoom>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idRoom { get; set; }

        [Required]
        [StringLength(50)]
        public string nameroom { get; set; }

        public double price { get; set; }

        [Required]
        [StringLength(50)]
        public string address { get; set; }

        [StringLength(50)]
        public string location { get; set; }

        [Column(TypeName = "image")]
        public byte[] image { get; set; }

        [StringLength(50)]
        public string status { get; set; }

        public int? phone { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookingRoom> BookingRooms { get; set; }
    }
}
