using Hospital.MVC.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Hospital.MVC.Data;

public class HospitalDbContext : IdentityDbContext<HospitalUser>
{
   public DbSet<Appointment> Appointments { get; set; } 
    
    public HospitalDbContext() { }
    
    
    
    public HospitalDbContext(DbContextOptions<HospitalDbContext> options) : base(options)
    {
    
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("appsettings.json");
    }


    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
       
    }
}
