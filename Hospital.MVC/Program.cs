using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Hospital.MVC.Data;
using Hospital.MVC.Areas.Identity.Data;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("HospitalDbContextConnection") ?? throw new InvalidOperationException("Connection string 'HospitalDbContextConnection' not found.");

builder.Services.AddDbContext<HospitalDbContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<HospitalMVCUser>(options => options.SignIn.RequireConfirmedAccount = false).AddEntityFrameworkStores<HospitalDbContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddRazorPages();

builder.Services.Configure<IdentityOptions>(options =>
{
    options.Password.RequireUppercase = false;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.MapRazorPages();

app.Run();
