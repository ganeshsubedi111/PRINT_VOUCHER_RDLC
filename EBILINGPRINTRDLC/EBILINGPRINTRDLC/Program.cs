using EBILINGPRINTRDLC.Models;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddOptions();
builder.Services.AddTransient<IRepositoryVoucher, VoucherRepository>();
builder.Services.AddControllersWithViews();
builder.Services.Configure<AppDbConnection>(options =>
{
    options.ConnectionString = builder.Configuration.GetConnectionString("DefaultConnection");
});

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
    pattern: "{controller=Report}/{action=Index}/{id?}");

app.Run();