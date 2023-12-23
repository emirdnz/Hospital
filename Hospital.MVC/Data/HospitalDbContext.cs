using Hospital.MVC.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Hospital.MVC.Data;

public class HospitalDbContext : DbContext
{
    public DbSet<Appointment> Appointments { get; set; }
  

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Appointment>().HasKey(a => a.Id); // Burada Id, birincil anahtarı temsil eden bir özellik olmalıdır.

    
    }

    public HospitalDbContext() { }



    public HospitalDbContext(DbContextOptions<HospitalDbContext> options) : base(options)
    {

    }

 



}
