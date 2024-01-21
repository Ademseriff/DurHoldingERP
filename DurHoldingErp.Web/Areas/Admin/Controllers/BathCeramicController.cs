using DurHoldingErp.Entity.DTOs;
using DurHoldingErp.Entity.Entities;
using DurHoldingErp.Service.Services.Abstractions;
using DurHoldingErp.Service.Services.Concretes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DurHoldingErp.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class BathCeramicController : Controller
    {
        private readonly IBathCeramicService bathCeramicService;

        public BathCeramicController(IBathCeramicService bathCeramicService)
        {

            this.bathCeramicService = bathCeramicService;
        }

        public async Task<IActionResult> Index()
        {
            var bath = await bathCeramicService.GetBathCeramicsAsync();
            ViewBag.bath = bath;
            return View();
        }
        [HttpGet]
        public IActionResult BathCeramicAdd()
        {
           
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> BathCeramicAdd(BathCeramic bathCeramic)
        {
            if (ModelState.IsValid)
            {
                await bathCeramicService.AddBathCeramicAsyn(bathCeramic);
                return RedirectToAction("BathCeramicAdd", "BathCeramic", new { Area = "Admin" });

            }

            return RedirectToAction("BathCeramicAdd", "BathCeramic", new { Area = "Admin" });
        }


        [HttpGet]
        public ActionResult BathCeramicUpdate()
        {

            return View();

        }


        [HttpPost]
        public async Task<ActionResult> BathCeramicUpdate(UpdateDto closetUpdateDto)
        {

            await bathCeramicService.UpdateAmount(closetUpdateDto);

            return RedirectToAction("Index", "BathCeramic", new { Area = "Admin" });
        }
    }
}
