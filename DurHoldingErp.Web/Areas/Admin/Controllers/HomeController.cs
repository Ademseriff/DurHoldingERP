using DurHoldingErp.Entity.Entities;
using DurHoldingErp.Service.Services.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DurHoldingErp.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IUsersService usersService;

        public HomeController(IUsersService UsersService)
        {
            usersService = UsersService;
        }
        
        public async Task<IActionResult> Index()
        {
            var users = await usersService.GetUsersAsync();
            ViewBag.Users = users;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AdminAdd(Users user)
        {
           await usersService.AddUserAsyn(user);
           return RedirectToAction("Index", "Home", new { Area = "Admin" });
        }
    }
}
