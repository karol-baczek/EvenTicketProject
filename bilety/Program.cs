using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using bilety.Data;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<biletyContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("biletyContext")));

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSession(options => { options.IdleTimeout = TimeSpan.FromMinutes(1); });


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
app.UseSession();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=users}/{action=Login}/{id?}");

app.Run();
