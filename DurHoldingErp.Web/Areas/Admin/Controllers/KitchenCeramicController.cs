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
    public class KitchenCeramicController : Controller
    {
        private readonly IKitchenCeramicService kitchenCeramicService;

        public KitchenCeramicController(IKitchenCeramicService kitchenCeramicService)
        {
            this.kitchenCeramicService = kitchenCeramicService;
        }

        public async Task<IActionResult> Index()
        {
            var kitchenCeramics = await kitchenCeramicService.GetKitchenCeramicAsync();
            ViewBag.kitchenCeramics = kitchenCeramics;
            return View();
        }

        public ActionResult KitchenCeramicAdd()
        {
            
            return View();
        }
       
        [HttpPost]
        public async Task<IActionResult> CeramicAdd(KitchenCeramic kitchenCeramic)
        {
            if (ModelState.IsValid)
            {
                await kitchenCeramicService.AddKitchenCeramicAsyn(kitchenCeramic);

                return RedirectToAction("KitchenCeramicAdd", "KitchenCeramic", new { Area = "Admin" });
            }


            return RedirectToAction("KitchenCeramicAdd", "KitchenCeramic", new { Area = "Admin" });

           
        }
        [HttpGet]
        public async Task<IActionResult> KitchenCeramicUpdate()
        {


            return View();
        }

        [HttpPost]
        public async Task<IActionResult> KitchenCeramicUpdate(UpdateDto updateDto)
        {
            await kitchenCeramicService.UpdateAmount(updateDto);

            return RedirectToAction("Index", "KitchenCeramic", new { Area = "Admin" });
        }




    }
}
