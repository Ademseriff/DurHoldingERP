using DurHoldingErp.Service.Services.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DurHoldingErp.Web.Areas.Person.Controllers
{
    [Area("Person")]
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
    }
}
