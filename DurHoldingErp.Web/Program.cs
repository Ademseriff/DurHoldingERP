using DurHoldingErp.Data.Context;
using DurHoldingErp.Data.Extensions;
using DurHoldingErp.Entity.Entities;
using DurHoldingErp.Service.Extensions;
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
            //ioc conteinara ekleme i�lemini yapt�k dependency injection.
            builder.Services.LoadDataLayerExtension(builder.Configuration);
            builder.Services.LoadServiceLayerExtension();
            //cokkie i�lemleri
            builder.Services.AddSession();
            // Add services to the container.
            builder.Services.AddControllersWithViews();
            //db contex ayarlar�.
            builder.Services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
            //cookie ayarlar�
            builder.Services.AddIdentity<AppUser, IdentityRole>(opt =>
            {
                opt.Password.RequireNonAlphanumeric = false;
                opt.Password.RequireLowercase = false;
                opt.Password.RequireUppercase = false;

            } ).AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();


            builder.Services.ConfigureApplicationCookie(opt =>
            {
                opt.LoginPath = new PathString("/Admin/Auth/Login");
                opt.LogoutPath = new PathString("/Admin/Auth/Logout");
                opt.Cookie = new CookieBuilder
                {
                    Name = "ERP",
                    HttpOnly = true
                    


                };
                opt.ExpireTimeSpan = TimeSpan.FromDays(2);
                opt.SlidingExpiration = true;
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


            app.UseSession();
            app.UseAuthentication();
            app.UseAuthorization();
           
            //default rotalar olu�turmam�za olanak sa�lar.
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