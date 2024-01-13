using DurHoldingErp.Entity.Entities;
using DurHoldingErp.Service.Services.Abstractions;
using DurHoldingErp.Service.Services.Concretes;
using Microsoft.AspNetCore.Mvc;

namespace DurHoldingErp.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ClosetController : Controller
    {
        private readonly IClosetService closetService;

        public ClosetController(IClosetService closetService)
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
        //[HttpPost]
        //public  IActionResult ClosetAdd(Closet closet)
        //{

       

        //}
        [HttpPost]
        public async Task<IActionResult> ClosetAdd(Closet closet)
        {
            if (ModelState.IsValid)
            {
                await closetService.AddClosetAsyn(closet);

                return RedirectToAction("ClosetAdd", "Closet", new { Area = "Admin" });
            }


            return RedirectToAction("ClosetAdd", "Closet", new { Area = "Admin" });
        }


    }
}
