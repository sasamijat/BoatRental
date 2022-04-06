using HotelWorkOrderManagement.Models;
using HotelWorkOrderManagement.Service;
using HotelWorkOrderManagement.Service.EquipmentPiece;
using HotelWorkOrderManagement.Service.Group;
using HotelWorkOrderManagement.Service.Task;
using HotelWorkOrderManagement.Service.TaskStateChange;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<ITaskService, TaskService>();
builder.Services.AddScoped<IGroupService, GroupService>();
builder.Services.AddScoped<IEquipmentPieceService, EquipmentPieceService>();
builder.Services.AddScoped<ITaskStateChangeService, TaskStateChangeService>();



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
