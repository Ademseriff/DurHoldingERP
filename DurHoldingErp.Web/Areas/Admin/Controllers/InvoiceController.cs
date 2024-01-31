using DurHoldingErp.Entity.DTOs;
using DurHoldingErp.Entity.Entities;
using DurHoldingErp.Service.Services.Abstractions;
using DurHoldingErp.Service.Services.Concretes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using System.IO;
using System.Security.AccessControl;

namespace DurHoldingErp.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class InvoiceController : Controller
    {
        private readonly IInvoiceService ınvoiceService;
        private readonly IMailService mailService;
        private static Invoice storedInvoice;
        public delegate Task sendGmail(MailDto mailDto);
        public event sendGmail SendEvent;



        public InvoiceController(IInvoiceService ınvoiceService, IMailService mailService)
        {
            this.ınvoiceService = ınvoiceService;
            this.mailService = mailService;
            SendEvent += async (MailDto dto) => await mailService.SendMail(dto);
        }

        public async Task<IActionResult> Index()
        {
            var ınvoice = await ınvoiceService.GetInvoiceAsync();
            ViewBag.ınvoice = ınvoice;
            return View();

           
        }

        [HttpPost]
        public async Task<IActionResult> PasifDeleteInvoice(Invoice ınvoice)
        {

            await ınvoiceService.PasifDeleteInvoiceAsyn(ınvoice);

            return RedirectToAction("Index", "Invoice", new { Area = "Admin" });


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

           
            if (ınvoice.EMail != null && ModelState.IsValid)
            {
                MailDto mailDto = new();
                mailDto.Sender = "ademserifd@gmail.com";
                mailDto.Reciver = ınvoice.EMail;
                mailDto.Subject = "Fatura Bilgileri";
                mailDto.Body = $"Satan Firma : Dur Holding \n " +
                    $"Satılan kişi : {ınvoice.ReceiverInformations} \n " +
                    $"Fatura No : {ınvoice.InvoiceNumber.ToString()} \n" +
                    $"Satılan Ürün: {ınvoice.Product} \n " +
                    $"Satılan Adet : {ınvoice.Piece} \n " +
                    $"Satılan Ürün Barcode ID : {ınvoice.BarcodeId} \n " +
                    $"BİZİ TERCİH ETTİĞİNİZ İÇİN TEŞEKKÜR EDERİZ \n" +
                    $"THANK YOU FOR CHOOSING US";


                await SendEvent(mailDto);
                return View();
            }

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

                storedInvoice = x;
                
                return RedirectToAction("WritePrintPDF", "Invoice", new { Area = "Admin"});
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
