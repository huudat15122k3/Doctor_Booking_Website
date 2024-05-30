namespace Doctor_Booking.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Appointment")]
    public partial class Appointment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int Patient_ID { get; set; }

        public int Doctor_ID { get; set; }

        public int Slot_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Appoitment_Time { get; set; }

        public int Status { get; set; }

        [StringLength(500)]
        public string Description { get; set; }
    }
}
