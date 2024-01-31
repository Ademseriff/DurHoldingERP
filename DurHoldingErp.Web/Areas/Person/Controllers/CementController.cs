
using DurHoldingErp.Service.Services.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DurHoldingErp.Web.Areas.Person.Controllers
{
    [Area("Person")]
    [Authorize]
    public class CementController : Controller
    {
        private readonly ICementService cementService;

        public CementController(ICementService cementService)
        {
            this.cementService = cementService;
        }

        public async Task<IActionResult> Index()
        {
            var cements = await cementService.GetCementsAsync();
            ViewBag.Cements = cements;
            return View();

        }
    }
}
