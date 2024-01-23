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
    public class UsersService : IUsersService
    {
        private readonly IUnitOfWork unitOfWork;

        public UsersService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<List<Users>> GetUsersAsync()
        {
            return await unitOfWork.GetRepository<Users>().GetAllAsyn();
        }

        public async Task<Users> GetUserAsync(string Name)
        {
            try
            {
                return await unitOfWork.GetRepository<Users>().GetAsyn(x => x.Name == Name);
            }
            catch
            {
                return null;
            }

        }

        public async Task AddUserAsyn(Users user)
        {
            await unitOfWork.GetRepository<Users>().AddAsyn(user);
        }

        public async Task DeleteUsercAsyn(Users user)
        {

            await unitOfWork.GetRepository<Users>().DeleteAsyn(user);
        }

    }
}
