using DurHoldingErp.Service.Services.Abstractions;
using DurHoldingErp.Service.Services.Concretes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DurHoldingErp.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class KitchenCeramic : Controller
    {
        private readonly IKitchenCeramicService kitchenCeramicService;

        public KitchenCeramic(IKitchenCeramicService kitchenCeramicService)
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
        public ActionResult CeramicAdd()
        {

            return RedirectToAction("KitchenCeramicAdd", "KitchenCeramic", new { Area = "Admin" });
        }


    }
}
