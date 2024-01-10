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

        [HttpGet]
        public async Task<IActionResult> employeeAdd()
        {
           
            return View();
        }


        //buraya bak.
        [HttpPost]
        public async Task<IActionResult> employeeAdd(Employee employee)
        {
            string departmanid = employee.DepartmentId.ToString();
            employee.DepartmentId=Guid.Parse(departmanid);
            
            
            await employeeService.AddUserAsyn(employee);
            return RedirectToAction("employeeAdd", "Home", new { Area = "Admin" });
        }


    }
}
