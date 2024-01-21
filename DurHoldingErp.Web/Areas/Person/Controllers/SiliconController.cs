using DurHoldingErp.Service.Services.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DurHoldingErp.Web.Areas.Person.Controllers
{
    [Area("Person")]
    [Authorize]
    public class SiliconController : Controller
    {
        private readonly ISiliconService siliconService;

        public SiliconController(ISiliconService siliconService)
        {
            this.siliconService = siliconService;
        }
        public async Task<IActionResult> Index()
        {

            var silicons = await siliconService.GetSiliconsAsync();
            ViewBag.silicons = silicons;
            return View();

        }
    }
}
