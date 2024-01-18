using DurHoldingErp.Entity.DTOs;
using DurHoldingErp.Entity.Entities;
using DurHoldingErp.Service.Services.Abstractions;
using DurHoldingErp.Service.Services.Concretes;
using Microsoft.AspNetCore.Mvc;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace DurHoldingErp.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class InvoiceController : Controller
    {
        private readonly IInvoiceService ınvoiceService;

        public InvoiceController(IInvoiceService ınvoiceService)
        {
            this.ınvoiceService = ınvoiceService;
        }

        public async Task<IActionResult> Index()
        {
            var ınvoice = await ınvoiceService.GetInvoiceAsync();
            ViewBag.ınvoice = ınvoice;
            return View();

           
        }

        [HttpGet]
        public ActionResult InvoiceAdd()
        {

            return View();

        }

        [HttpPost]
        public async Task<ActionResult> InvoiceAdd(Invoice ınvoice)
        {
            
           await ınvoiceService.AddInvoiceAsyn(ınvoice);
            return View();

        }

        [HttpGet]
        public  ActionResult InvoiceWrite()
        {
           
            return View();

        }
        [HttpGet]
        public ActionResult PrintPDF()
        {
           


            return RedirectToAction("InvoiceAdd", "Invoice", new { Area = "Admin" });
        }

        [HttpPost]
        public async Task<ActionResult> PrintPDF(Invoice ınvoice)
        {

            var x = await ınvoiceService.GetSingleInvoiceAsync(ınvoice.InvoiceNumber);
            if (x == null)
            {
                return RedirectToAction("InvoiceAdd", "Invoice", new { Area = "Admin" });
            }
            else
            {
               
                ViewBag.x = x;
                return RedirectToAction("WritePrintPDF", "Invoice", new { Area = "Admin" });
            }

        }

        [HttpGet]
        public ActionResult WritePrintPDF(Invoice ınvoice)
        {
            

            return View(ınvoice);
        }

    }
}
