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

        [HttpGet]
        public IActionResult SiliconAdd()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SiliconAdd(Silicon silicon)
        {
            if (ModelState.IsValid)
            {
                await siliconService.AddSiliconAsyn(silicon);
                return RedirectToAction("SiliconAdd", "Silicon", new { Area = "Admin" });

            }

            return RedirectToAction("SiliconAdd", "Silicon", new { Area = "Admin" });
        }

        [HttpGet]
        public ActionResult SiliconUpdate()
        {

            return View();

        }


        [HttpPost]
        public async Task<ActionResult> SiliconUpdate(UpdateDto closetUpdateDto)
        {

            await siliconService.UpdateAmount(closetUpdateDto);

            return RedirectToAction("SiliconUpdate", "Silicon", new { Area = "Admin" });
        }
    }
}
