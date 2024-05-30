namespace Doctor_Booking.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            Slot = new HashSet<Slot>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Username { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }

        [StringLength(100)]
        public string Fullname { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(10)]
        public string Phone { get; set; }

        public int Major_ID { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [StringLength(100)]
        public string ImagePath { get; set; }

        public virtual Major Major { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Slot> Slot { get; set; }
    }
}
