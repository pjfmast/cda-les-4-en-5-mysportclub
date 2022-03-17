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
    options => {
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
    options => {
        // todo lesson 4-16c configureren:
        options.LoginPath = "/Users/Login";

        // todo lesson 4-18 configureren: acces denied
        options.AccessDeniedPath = "/Users/AccessDenied";
    });


// todo lesson 5-1: configure google api console 
// todo lesson 5-2: 
builder.Services
    .AddAuthentication()
    .AddGoogle(googleOptions => {
        IConfigurationSection googleAuthNSection
            = builder.Configuration.GetSection("Authentication:Google");

        googleOptions.ClientId = googleAuthNSection["ClientId"];
        googleOptions.ClientSecret = googleAuthNSection["ClientSecret"];
    });
// previous steps:
// todo lesson 6-01: install using NuGet manager: MailKit en MimeKit packages
// todo lesson 6-02: Create data class MailRequest (see Models/MailRequest)

// todo lesson 6-03: create an Ethereal Account aan (https://ethereal.email/) and
// todo lesson 6-04: use Manage User Secrets (preferred instead of AppSettings.json) for SMTP server data 
//      also see: https://docs.microsoft.com/en-us/aspnet/core/security/app-secrets?view=aspnetcore-6.0&tabs=windows#json-structure-flattening-in-visual-studio
// todo lesson 6-05a: Create data class MailSettings (see Models/MailSettings)
// todo lesson 6-05b: Register the configuration MailSettings
//      also see: https://docs.microsoft.com/en-us/aspnet/core/fundamentals/configuration/options?view=aspnetcore-6.0
builder.Services.Configure<MailSettings>(
    builder.Configuration.GetSection("MailSettings"));

// todo Lesson 6-06a: Create interface IMailService (see Services/IMailService)
// todo Lesson 6-06b: Create class MailService (see Services/MailService)

// todo lesson 6-07: Add services for using dependency injection on IMailService
builder.Services.AddTransient<
    MySportsClub.Services.IMailService,
    MySportsClub.Services.MailService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment()) {
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
