using DurHoldingErp.Service.Services.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DurHoldingErp.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IEmployeeService employeeService;

        public HomeController(IEmployeeService EmployeeService)
        {
            employeeService = EmployeeService;
        }
        
        public async Task<IActionResult> Index()
        {
            var employee = await employeeService.GetEmployeesAsync(); 
            return View(employee);
        }
    }
}
