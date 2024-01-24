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
        [HttpPost]
        public async Task<IActionResult> DeleteCement(Cement cement)
        {

            await cementService.DeleteCementAsyn(cement);

            return RedirectToAction("Index", "Cement", new { Area = "Admin" });


        }
        [HttpPost]
        public async Task<IActionResult> PsifDeleteCement(Cement cement)
        {

            await cementService.PasifDeleteCementAsyn(cement);

            return RedirectToAction("Index", "Cement", new { Area = "Admin" });


        }

        [HttpGet]
        public ActionResult CementAdd()
        {

            return View();

        }
     
        [HttpPost]
        public async Task<IActionResult> CementAdd(Cement cement)
        {
            if (ModelState.IsValid)
            {
                await cementService.AddCementAsyn(cement);

                return RedirectToAction("CementAdd", "Cement", new { Area = "Admin" });
            }


            return RedirectToAction("CementAdd", "Cement", new { Area = "Admin" });
        }


        [HttpGet]
        public async Task<IActionResult> CementUpdate()
        {


            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CementUpdate(UpdateDto updateDto)
        {
            await cementService.UpdateAmount(updateDto);

            return RedirectToAction("CementUpdate", "Cement", new { Area = "Admin" });
        }



    }
}
