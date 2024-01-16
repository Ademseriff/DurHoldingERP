using DurHoldingErp.Entity.DTOs;
using DurHoldingErp.Entity.Entities;
using DurHoldingErp.Service.Services.Abstractions;
using DurHoldingErp.Service.Services.Concretes;
using Microsoft.AspNetCore.Mvc;

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

        public IActionResult Index()
        {
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
    }
}
