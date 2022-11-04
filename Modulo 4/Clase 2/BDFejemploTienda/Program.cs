using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BDFejemploTienda.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<BDFejemploTiendaContext>(options =>
    //options.UseSqlServer(builder.Configuration.GetConnectionString("BDFejemploTiendaContext") ?? throw new InvalidOperationException("Connection string 'BDFejemploTiendaContext' not found.")));
    options.UseSqlServer(builder.Configuration["Tienda"] ?? throw new InvalidOperationException("Connection string 'BDFejemploTiendaContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

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




/*
 Almacen
- Producto:
  - SKU
  - Nombre
  - Descripcion
  - Caducidad
 */