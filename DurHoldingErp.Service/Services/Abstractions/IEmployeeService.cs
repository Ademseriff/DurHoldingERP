﻿using DurHoldingErp.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DurHoldingErp.Service.Services.Abstractions
{
    public interface IEmployeeService
    {
        Task<List<Employee>> GetEmployeesAsync();

        Task<Employee> GetEmployeeAsync(string name);

        Task AddUserAsyn(Employee employee);
        Task PasifDeleteEmployeeAsyn(Employee employee);
    }
}
