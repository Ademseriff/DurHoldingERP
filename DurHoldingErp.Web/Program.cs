using DurHoldingErp.Data.Context;
using DurHoldingErp.Data.Extensions;
using DurHoldingErp.Entity.Entities;
using DurHoldingErp.Service.Extensions;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Security.Principal;


namespace DurHoldingErp.Web
{
    
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            //ioc conteinara ekleme iþlemini yaptýk dependency injection.
            builder.Services.LoadDataLayerExtension(builder.Configuration);
            builder.Services.LoadServiceLayerExtension();
            
            // Add services to the container.
            builder.Services.AddControllersWithViews();
            //db contex ayarlarý.
            builder.Services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
     
            
            builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(opt =>
            {
                opt.Cookie.Name = "Erp";
                opt.LoginPath = new PathString("/Admin/Auth/Login");
                opt.LogoutPath = new PathString("/Admin/Auth/Logout");
                opt.ExpireTimeSpan = TimeSpan.FromHours(24);
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


           
            app.UseAuthentication();
            app.UseAuthorization();
           
            //default rotalar oluþturmamýza olanak saðlar.
            app.UseEndpoints(endpoints => {

                endpoints.MapAreaControllerRoute(
                    name: "Admin",
                    areaName: "Admin",
                    pattern: "Admin/{controller=Home}/{action=Index}/{id?}"
                    
                );

                endpoints.MapDefaultControllerRoute();

            });
            app.Run();
        }
    }
}