using DurHoldingErp.Service.Services.Abstractions;
using DurHoldingErp.Service.Services.Concretes;
using Microsoft.AspNetCore.Mvc;

namespace DurHoldingErp.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class Closet : Controller
    {
        private readonly IClosetService closetService;

        public Closet(IClosetService closetService)
        {
            this.closetService = closetService;
        }

        public async Task<IActionResult> Index()
        {
            var closets = await closetService.GetClosetsAsync();
            ViewBag.Closets = closets;
            return View();
           
        }
        [HttpGet]
        public  ActionResult ClosetAdd()
        {
            
            return View();

        }
        [HttpPost]
        public async Task<IActionResult> ClosetAdd(Closet closet)
        {
            
            return View();

        }


    }
}
