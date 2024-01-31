using DurHoldingErp.Data.UnitOfWorks;
using DurHoldingErp.Entity.DTOs;
using DurHoldingErp.Entity.Entities;
using DurHoldingErp.Service.Services.Abstractions;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Security.Claims;

namespace DurHoldingErp.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AuthController : Controller
    {
        
        private readonly IEmployeeService employeeService;
        private readonly IUsersService usersService;

        public AuthController( IEmployeeService EmployeeService,IUsersService UsersService)
        {
            
            employeeService = EmployeeService;
            usersService = UsersService;
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(UserLoginDto userLoginDto)
        {
            if(ModelState.IsValid)
            {
                try
                {
                    var user = await usersService.GetUserAsync(userLoginDto.Name);
                    
                    if (user != null && user.Password == userLoginDto.Password && user.Email == userLoginDto.Email)
                    {
                        if (user.Role.Equals("SüperAdmin"))
                        {
                            // Kullanıcı bilgileri
                            var claims = new List<Claim>
                          {
                          new Claim(ClaimTypes.Name,user.Name),
                       // Daha fazla kullanıcı bilgisi ekleyebilirsiniz.
                         new Claim(ClaimTypes.Email,user.Email),
                         new Claim(ClaimTypes.Anonymous,user.Password)

                           };
                            // Kimlik oluşturma
                            var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                            // Kimlik oluşturup kullanıcıyı giriş yapmış olarak işaretleme
                            var principal = new ClaimsPrincipal(identity);
                            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

                            return RedirectToAction("Index", "Home", new { Area = "Admin" });
                        }
                        else if (user.Role.Equals("SüperAdmin") || user.Role.Equals("Admin"))
                        {
                            // Kullanıcı bilgileri
                            var claims = new List<Claim>
                          {
                          new Claim(ClaimTypes.Name,user.Name),
                       // Daha fazla kullanıcı bilgisi ekleyebilirsiniz.
                         new Claim(ClaimTypes.Email,user.Email),
                         new Claim(ClaimTypes.Anonymous,user.Password)

                           };
                            // Kimlik oluşturma
                            var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                            // Kimlik oluşturup kullanıcıyı giriş yapmış olarak işaretleme
                            var principal = new ClaimsPrincipal(identity);
                            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

                            return RedirectToAction("Index", "Home", new { Area = "Person" });
                        }
                        else
                        {
                            ModelState.AddModelError("", "Kullanıcı adı veya şifre yanlış..");
                            return View();
                        }

                    }
                    else
                    {
                        ModelState.AddModelError("", "Kullanıcı adı veya şifre yanlış..");
                        return View();
                    }
                }
                catch (ArgumentException ex)
                {
                    ModelState.AddModelError("", "Kullanıcı adı veya şifre yanlış..");
                    return View();
                }

                

            }
           
            return View();
        }
        [AllowAnonymous]
       
        public async Task<IActionResult> Logout()
        {
            // Kullanıcıyı çıkış yapmış olarak işaretleme
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home", new {Area =""});
        }
    }
}

