using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DurHoldingErp.Web.Areas.Person.Controllers
{
    public class HomeController : Controller
    {
        [Area("Person")]
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
    }
}
