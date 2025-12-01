using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using NuGet.Protocol.Core.Types;
using SchoolManagementAppWeb.Abstract;
using SchoolManagementAppWeb.Data;
using SchoolManagementAppWeb.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
// Source - https://stackoverflow.com/a
// Posted by Kirk Larkin, modified by community. See post 'Timeline' for change history
// Retrieved 2025-11-29, License - CC BY-SA 4.0

//For the Dependency Injection framework to resolve IStudentInfo, it must first be registered with the container. 
builder.Services.AddScoped<IStudentInfoUsingEF, StudentInfoRepoEF>();


/*Injected the following*/
builder.Services.AddDbContext<StudentInfoDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("SchoolManagementAppDbConnectionString")));
builder.Services.AddDbContext<AuthDatabaseContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("SchoolManagementAppAuthDbConnectionString")).ConfigureWarnings(w => w.Ignore(RelationalEventId.PendingModelChangesWarning)).EnableDetailedErrors());

builder.Services.AddIdentity<IdentityUser, IdentityRole>()
    .AddEntityFrameworkStores<AuthDatabaseContext>();

builder.Services.Configure<IdentityOptions>(options =>
{
    // Default settings
    options.Password.RequireDigit = true;
    options.Password.RequireLowercase = true;
    options.Password.RequireNonAlphanumeric = true;
    options.Password.RequireUppercase = false;
    options.Password.RequiredLength = 6;
    options.Password.RequiredUniqueChars = 1;
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

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    //pattern: "{controller=StudentDetailsEF}/{action=fetchStudentDetailsUsingIEnumerable}/{id?}");
    pattern: "{controller=StudentDetailsEF}/{action=fetchStudentDetailsUsingList}/{id?}");
    //pattern: "{controller=StudentDetailsEF}/{action=displayStudentDetailsForDropDown}/{id?}");
    //pattern: "{controller=Account}/{action=Register}/{id?}");


app.Run();
