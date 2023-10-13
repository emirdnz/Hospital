using Hospital.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Data.Context
{
    public class HospitalContext : DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Appointment> Apointments { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Role> Roller { get; set; }
        public DbSet<Menu> Menuler { get; set; }

        public HospitalContext()
        {

        }
        public HospitalContext(DbContextOptions<HospitalContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(LocalDB)\\MSSQLLocalDB;Database=HospitalDB; Trusted_Connection=True; TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }


    }
}
