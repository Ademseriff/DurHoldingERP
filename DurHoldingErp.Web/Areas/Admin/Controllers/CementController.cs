using DurHoldingErp.Entity.DTOs;
using DurHoldingErp.Entity.Entities;
using DurHoldingErp.Service.Services.Abstractions;
using DurHoldingErp.Service.Services.Concretes;
using Microsoft.AspNetCore.Mvc;

namespace DurHoldingErp.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
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

        [HttpGet]
        public ActionResult CementAdd()
        {

            return View();

        }
        //[HttpPost]
        //public  IActionResult ClosetAdd(Closet closet)
        //{



        //}
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
