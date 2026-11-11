using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();

var app = builder.Build();


app.UseStaticFiles();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=CustomerOrders}/{action=Index}/{id?}");  // Varsayýlan route ayarladým. CustomerOrders/Index

app.Run();
