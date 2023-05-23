using Assessment2_MVC.Context;
using Assessment2_MVC;
using Microsoft.EntityFrameworkCore;
using Assessment2_MVC.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<TrainingDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("UserDbConnection"));
});
builder.Services.AddTransient<InterfaceUser, UserRepository>();
builder.Services.AddTransient<InterfaceCourse, CourseRepository>();
builder.Services.AddTransient<InterfaceBatch, BatchRepository>();

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

app.Run();
