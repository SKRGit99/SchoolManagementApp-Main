using Microsoft.EntityFrameworkCore;
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
    //pattern: "{controller=StudentDetailsEF}/{action=fetchStudentDetailsUsingIEnumerable}/{id?}");
    pattern: "{controller=StudentDetailsEF}/{action=fetchStudentDetailsUsingList}/{id?}");
    //pattern: "{controller=StudentDetailsEF}/{action=displayStudentDetailsForDropDown}/{id?}");

    //pattern: "{controller=StudentDetailsADO}/{action=fetchStudentDetailsUsingADO}/{id?}");

app.Run();
