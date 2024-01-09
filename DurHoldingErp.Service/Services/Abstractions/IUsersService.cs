using DurHoldingErp.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DurHoldingErp.Service.Services.Abstractions
{
    public interface IUsersService
    {
        Task<List<Users>> GetUsersAsync();

        Task<Users> GetUserAsync(string Email);

        Task AddUserAsyn(Users user);
    }
}
