﻿using DurHoldingErp.Entity.DTOs;
using DurHoldingErp.Entity.Entities;
using DurHoldingErp.Service.Services.Abstractions;
using DurHoldingErp.Service.Services.Concretes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DurHoldingErp.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class ClosetController : Controller
    {
        private readonly IClosetService closetService;

        public ClosetController(IClosetService closetService)
        {
            this.closetService = closetService;
        }

        public async Task<IActionResult> Index()
        {
            var closets = await closetService.GetClosetsAsync();
            ViewBag.Closets = closets;
           
           
            return View();
           
        }
        [HttpPost]
        public async Task<IActionResult> DeleteCloset(Closet closet)
        {
           
            await closetService.DeleteClosetAsyn(closet);
    
            return RedirectToAction("Index", "Closet", new { Area = "Admin" });


        }
        [HttpPost]
        public async Task<IActionResult> PasifDeleteCloset(Closet closet)
        {

            await closetService.PasifDeleteClosetAsyn(closet);

            return RedirectToAction("Index", "Closet", new { Area = "Admin" });


        }
        [HttpGet]
        public  ActionResult ClosetAdd()
        {
            
            return View();

        }
       
        [HttpPost]
        public async Task<IActionResult> ClosetAdd(Closet closet)
        {
            if (ModelState.IsValid)
            {
                await closetService.AddClosetAsyn(closet);

                return RedirectToAction("ClosetAdd", "Closet", new { Area = "Admin" });
            }


            return RedirectToAction("ClosetAdd", "Closet", new { Area = "Admin" });
        }


        [HttpGet]
        public ActionResult ClosetUpdate()
        {

            return View();

        }


        [HttpPost]
        public async Task<ActionResult> ClosetUpdate(UpdateDto closetUpdateDto)
        {

            await closetService.UpdateAmount(closetUpdateDto);

            return RedirectToAction("Index", "Closet", new { Area = "Admin" });
        }


    }
}
