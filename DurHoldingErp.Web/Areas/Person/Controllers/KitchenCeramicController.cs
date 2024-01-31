using DurHoldingErp.Service.Services.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DurHoldingErp.Web.Areas.Person.Controllers
{
    [Area("Person")]
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
    }
}
