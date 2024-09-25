using Microsoft.EntityFrameworkCore;
using StoreApp.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();//view nesneleri ile dahil olmasini istiyoruz
builder.Services.AddDbContext<RepositoryContext>(options =>
{
    options.UseSqlite(builder.Configuration.GetConnectionString("sqlconnection"));
}); //veri tabanini istenen yerde kullanilabilecek

var app = builder.Build();

app.UseHttpsRedirection();
app.UseRouting();
app.MapControllerRoute(name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run();
