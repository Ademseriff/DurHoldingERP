using DurHoldingErp.Service.Services.Abstractions;
using DurHoldingErp.Service.Services.Concretes;
using Microsoft.AspNetCore.Mvc;

namespace DurHoldingErp.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class Closet : Controller
    {
        private readonly IClosetService closetService;

        public Closet(IClosetService closetService)
        {
            this.closetService = closetService;
        }

        public async Task<IActionResult> Index()
        {
            var closets = await closetService.GetClosetsAsync();
            ViewBag.Closets = closets;
            return View();
           
        }
        [HttpGet]
        public  ActionResult ClosetAdd()
        {
            
            return View();

        }
        //[HttpPost]
        //public  IActionResult ClosetAdd(Closet closet)
        //{

       

        //}
        [HttpPost]
        public IActionResult ClosetAdd(Closet closet)
        {
            if (ModelState.IsValid)
            {
                // Closet nesnesi başarıyla alındı. İstenen işlemleri gerçekleştirebilirsiniz.
                // Örneğin, veritabanına ekleme işlemi yapabilirsiniz.

                // Başarılı bir işlem sonrasında bir sayfaya yönlendirme yapabilirsiniz.
                return RedirectToAction("SuccessAction");
            }

            // ModelState.IsValid false ise, model bağlama sırasında bir hata olmuştur. Bu durumu inceleyebilirsiniz.
            return View();
        }


    }
}
