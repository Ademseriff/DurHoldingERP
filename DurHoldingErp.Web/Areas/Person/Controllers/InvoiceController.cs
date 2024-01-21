using DurHoldingErp.Entity.Entities;
using DurHoldingErp.Service.Services.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DurHoldingErp.Web.Areas.Person.Controllers
{
    [Area("Person")]
    [Authorize]
    public class InvoiceController : Controller
    {
        private readonly IInvoiceService ınvoiceService;
   
        private static Invoice storedInvoice;

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
        public ActionResult InvoiceWrite()
        {

            return View();

        }

        [HttpPost]
        public async Task<ActionResult> PrintPDF(Invoice ınvoice)
        {

            var x = await ınvoiceService.GetSingleInvoiceAsync(ınvoice.InvoiceNumber);
            if (x == null)
            {
                return RedirectToAction("InvoiceAdd", "Invoice", new { Area = "Person" });
            }
            else
            {

                storedInvoice = x;

                return RedirectToAction("WritePrintPDF", "Invoice", new { Area = "Person" });
            }

        }

        [HttpGet]
        public ActionResult WritePrintPDF()
        {

            Invoice x = storedInvoice;


            return View(x);
        }

    }
}
