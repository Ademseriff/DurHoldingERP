using DurHoldingErp.Service.Services.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DurHoldingErp.Web.Areas.Person.Controllers
{
    [Area("Person")]
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
    }
}
