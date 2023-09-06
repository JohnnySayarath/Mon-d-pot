using Microsoft.EntityFrameworkCore;
using TPASPCaisse.Data;
using TPASPCaisse.Models;
using TPASPCaisse.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddControllersWithViews();
//builder.Services.AddScoped<IRepository<Product>, ProductRepository>();
//builder.Services.AddScoped<IRepository<Category>, CategoryRepository>();

string connectionString = builder.Configuration.GetConnectionString("DefaultConnexionString");

builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));

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
