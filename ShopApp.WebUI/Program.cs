using ShopApp.Business.Abstract;
using ShopApp.Business.Concrete;
using ShopApp.DataAccess.Abstract;
using ShopApp.DataAccess.Concrete.Memory;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IProductDal, MemoryProductDal>();
builder.Services.AddScoped<IProductService, ProductManager>();
builder.Services.AddControllersWithViews();//mvc ekledik

var app = builder.Build();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run();
