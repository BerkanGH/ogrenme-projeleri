var builder = WebApplication.CreateBuilder(args);

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
// wwwroot klasöründeki statik dosyaların erişilebilir olmasını sağlıyoruz
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

//Tarayıcıdan gelen isteklerin doğru controller ve action'a yönlendirilmesi için routing yapılandırmasını yapıyoruz
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// 4. Uygulamanın çalışmasını sağlıyoruz
app.Run();
