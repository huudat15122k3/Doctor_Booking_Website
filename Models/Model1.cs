using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Doctor_Booking.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model13")
        {
        }

        public virtual DbSet<Appointment> Appointment { get; set; }
        public virtual DbSet<Disease> Disease { get; set; }
        public virtual DbSet<Major> Major { get; set; }
        public virtual DbSet<Material> Material { get; set; }
        public virtual DbSet<Slot> Slot { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appointment>()
                .Property(e => e.Appoitment_Time)
                .IsFixedLength();

            modelBuilder.Entity<Appointment>()
                .Property(e => e.Description)
                .IsFixedLength();

            modelBuilder.Entity<Disease>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Disease>()
                .Property(e => e.Description)
                .IsFixedLength();

            modelBuilder.Entity<Major>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Major>()
                .Property(e => e.Description)
                .IsFixedLength();

            modelBuilder.Entity<Major>()
                .Property(e => e.ImagePath)
                .IsFixedLength();

            modelBuilder.Entity<Major>()
                .HasMany(e => e.Disease)
                .WithRequired(e => e.Major)
                .HasForeignKey(e => e.Major_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Major>()
                .HasMany(e => e.User)
                .WithRequired(e => e.Major)
                .HasForeignKey(e => e.Major_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Material>()
                .Property(e => e.DayInWeek)
                .IsFixedLength();

            modelBuilder.Entity<Material>()
                .Property(e => e.TimeSlot)
                .IsFixedLength();

            modelBuilder.Entity<Slot>()
                .Property(e => e.DayInWeek)
                .IsFixedLength();

            modelBuilder.Entity<Slot>()
                .Property(e => e.TimeSlot)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.Username)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.Fullname)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.Email)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.Phone)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.Description)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.ImagePath)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .HasMany(e => e.Slot)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.User_ID)
                .WillCascadeOnDelete(false);
        }
    }
}
