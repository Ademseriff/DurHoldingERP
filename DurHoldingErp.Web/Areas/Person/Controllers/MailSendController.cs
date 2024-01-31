using DurHoldingErp.Entity.DTOs;
using DurHoldingErp.Service.Services.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DurHoldingErp.Web.Areas.Person.Controllers
{
    [Area("Person")]
    [Authorize]
    public class MailSendController : Controller
    {
        private readonly IMailService mailService;

        public MailSendController(IMailService mailService)
        {
            this.mailService = mailService;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(MailDto mailDto)
        {
            mailService.SendMail(mailDto);
            return View();
        }
    }
}
