using DurHoldingErp.Data.UnitOfWorks;
using DurHoldingErp.Entity.Entities;
using DurHoldingErp.Service.Services.Abstractions;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DurHoldingErp.Service.Services.Concretes
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IUnitOfWork unitOfWork;

        public EmployeeService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<List<Employee>> GetEmployeesAsync()
        {
            return await unitOfWork.GetRepository<Employee>().GetAllAsyn();
        }

        public async Task<Employee> GetEmployeeAsync(string name)
        {
            try
            {
                return await unitOfWork.GetRepository<Employee>().GetAsyn(x => x.Name == name);
            }
            catch
            {
                return null;
            }
           
        }
    }
}

