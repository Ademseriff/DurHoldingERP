﻿using DurHoldingErp.Data.UnitOfWorks;
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

        public async Task<Employee> GetEmployeeAsync(string Email)
        {
            try
            {
                return await unitOfWork.GetRepository<Employee>().GetAsyn(x => x.Email == Email);
            }
            catch
            {
                return null;
            }
           
        }
        public async Task PasifDeleteEmployeeAsyn(Employee employee)
        {
            employee.IsDeleted = true;
            await unitOfWork.GetRepository<Employee>().UpdateAsyn(employee);
        }

        public async Task AddUserAsyn(Employee employee)
        {
            await unitOfWork.GetRepository<Employee>().AddAsyn(employee);
        }

    }
}

