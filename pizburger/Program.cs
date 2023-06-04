using Microsoft.EntityFrameworkCore;
using pizburger.Entities;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();










builder.Services.AddDbContext<AppDbContext>(opt =>

{

    opt.UseSqlServer(builder.Configuration.GetConnectionString("Bag"));
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

app.Run();
