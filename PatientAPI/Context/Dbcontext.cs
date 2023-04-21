using Appointment_Booking_App.Models;
using Microsoft.EntityFrameworkCore;

namespace PatientAPI.Context
{
    public class Dbcontext:DbContext
    {
        // contractor
        public Dbcontext(DbContextOptions<Dbcontext> Context) : base(Context)
        {


        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LoginInfo>().HasNoKey();
         // modelBuilder.Entity<Admin>().HasNoKey();
        //  modelBuilder.Entity<Doctor>().HasNoKey();
        //    modelBuilder.Entity<Appointments>().HasNoKey();
        }


        // Table creation-
        public DbSet<Patient> PatientsTable { get; set; }
        public DbSet<Admin> AdminTable { get; set; }
        public DbSet<Doctor> DoctorsTable { get; set; }
        public DbSet<LoginInfo> LoginInfo { get; set; }
        public DbSet<Appointments> AppointmentsTable { get; set; }
    }
}
