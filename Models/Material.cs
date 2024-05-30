namespace Doctor_Booking.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Material")]
    public partial class Material
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required]
        [StringLength(10)]
        public string DayInWeek { get; set; }

        [Required]
        [StringLength(50)]
        public string TimeSlot { get; set; }

        public int Is_Booked { get; set; }
    }
}
