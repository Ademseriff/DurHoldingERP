using DurHoldingErp.Entity.Entities;
using DurHoldingErp.Service.Services.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DurHoldingErp.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IUsersService usersService;
        private readonly IEmployeeService employeeService;

        public HomeController(IUsersService UsersService,IEmployeeService employeeService)
        {
            usersService = UsersService;
            this.employeeService = employeeService;
        }
        
        public async Task<IActionResult> Index()
        {
            var users = await usersService.GetUsersAsync();
            ViewBag.Users = users;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AdminAdd(Users user)
        {
           await usersService.AddUserAsyn(user);
           return RedirectToAction("Index", "Home", new { Area = "Admin" });
        }

        [HttpGet]
        public async Task<IActionResult> employee()
        {
            var employee = await employeeService.GetEmployeesAsync();
            ViewBag.Employees = employee;
            return View();
        }

        //buraya bak.
        [HttpPost]
        public async Task<IActionResult> employee(Employee employee)
        {
            string x = employee.DepartmentId.ToString();
            employee.DepartmentId=Guid.Parse(x);
            var a = employee;
            
            await employeeService.AddUserAsyn(employee);
            return RedirectToAction("Index", "Home", new { Area = "Admin" });
        }


    }
}
