using Microsoft.EntityFrameworkCore;
using MySportsClub.Data;
using MySportsClub.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

string connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// Add a DBContext to the container,
// see also: https://stackoverflow.com/questions/68980778/config-connection-string-in-net-core-6
builder.Services.AddDbContext<SportsClubContext>(options => options.UseSqlServer(connectionString))
    .AddTransient<IMemberRepository, EFMemberRepository>()
    .AddTransient<IWorkoutRepository, EFWorkoutRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
