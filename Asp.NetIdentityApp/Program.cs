using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using asp.netIdentityApp.Data;
using asp.netIdentityApp.Areas.Identity.Data;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("aspnetIdentityAppContextConnection") ?? throw new InvalidOperationException("Connection string 'aspnetIdentityAppContextConnection' not found.");

builder.Services.AddDbContext<aspnetIdentityAppContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<aspnetIdentityAppUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<aspnetIdentityAppContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();;

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();
app.Run();
