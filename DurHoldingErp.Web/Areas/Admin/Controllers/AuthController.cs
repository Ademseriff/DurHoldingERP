using DurHoldingErp.Entity.DTOs;
using DurHoldingErp.Entity.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace DurHoldingErp.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AuthController : Controller
    {
        private readonly SignInManager<AppUser> signInManager;
        private readonly UserManager<AppUser> userManagerr;
        public AuthController(UserManager<AppUser> userManager,SignInManager<AppUser> signInManager)
        {
            this.signInManager = signInManager;
            this.userManagerr = userManager;
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
                var user = await userManagerr.FindByEmailAsync(userLoginDto.Email); 

                if (user != null)
                {
                    var result = await signInManager.PasswordSignInAsync(user,userLoginDto.Password,false,false);
                    if (result.Succeeded)
                    {
                        RedirectToAction("Index","Home",new {Area = "Admin"});
                    }
                    else
                    {
                        ModelState.AddModelError("","Kullanıcı adı veya şifre yanlış..");
                        return View();
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Kullanıcı adı veya şifre yanlış..");
                    return View();
                }

            }
           
            return View();
        }
    }
}
