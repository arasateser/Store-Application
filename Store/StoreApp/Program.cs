using Microsoft.EntityFrameworkCore;
using Entities.Models;
using Repositories;
using Repositories.Contracts;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();//view nesneleri ile dahil olmasini istiyoruz
builder.Services.AddDbContext<RepositoryContext>(options =>
{
    options.UseSqlite(builder.Configuration.GetConnectionString("sqlconnection"),
        b => b.MigrationsAssembly("StoreApp")); //migration storeappte olusacak default repositories e gidiyordu
}); //veri tabanini istenen yerde kullanilabilecek

builder.Services.AddScoped<IRepositoryManager, RepositoryManager>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();


var app = builder.Build();

app.UseStaticFiles();
app.UseHttpsRedirection();
app.UseRouting();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run();