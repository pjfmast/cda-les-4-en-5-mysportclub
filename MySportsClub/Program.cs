using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MySportsClub.Data;
using MySportsClub.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

string connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// Add a DBContext to the container,
// see also: https://stackoverflow.com/questions/68980778/config-connection-string-in-net-core-6
builder.Services
    .AddDbContext<SportsClubContext>(options =>
    options.UseSqlServer(connectionString)
    )
    .AddTransient<IMemberRepository, EFMemberRepository>()
    .AddTransient<IWorkoutRepository, EFWorkoutRepository>();

// todo lesson 4-02a. register services for Identity
// see also: https://stackoverflow.com/questions/55361533/addidentity-vs-addidentitycore
builder.Services
    .AddIdentity<IdentityUser, IdentityRole>()
    .AddEntityFrameworkStores<SportsClubContext>();

// todo lesson 4-09a - testen registreren en check op password
// todo lesson 4-09b - configureren check op password
//    (Kan ook als parameter in AddIdentity worden ingesteld.)
builder.Services.Configure<IdentityOptions>(
    options =>
    {
        // voor lesson 4-09b: Configuration check on password:
        options.Password.RequireNonAlphanumeric = false;
        options.Password.RequireDigit = true;
        options.Password.RequiredUniqueChars = 5;
        options.Password.RequiredLength = 8;
    });

// todo lesson 4-16c: indien gebruik niet ingelogd is, voor geauthoriseerde acties omleiden naar Login.
// De default redirect naar Login URL in Identity is: /Account/Login
// Dit kun je op deze manier wijzigen:
builder.Services.ConfigureApplicationCookie(
    options =>
    {
        // todo lesson 4-16c configureren:
        options.LoginPath = "/Users/Login";

        // todo lesson 4-18 configureren: acces denied
        options.AccessDeniedPath = "/Users/AccessDenied";
    });

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

// todo lesson 4-02b configure middleware for Authentication
app.UseAuthentication();
app.UseAuthorization();

// todo lesson 4-15. Seed Identity EF store with roles and users
UserAndRoleDataInitializer.SeedRoles(app.Services, app.Configuration);
UserAndRoleDataInitializer.SeedUsers(app.Services, app.Configuration);

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
