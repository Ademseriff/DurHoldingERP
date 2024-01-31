using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DurHoldingErp.Web.Areas.Person.Controllers
{
    public class HomeController : Controller
    {
        public static string icerik;
        [Area("Person")]
        [Authorize]
        public async Task<IActionResult> Index()
        {
           
            return View();
        }
    }
}
