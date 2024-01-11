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
    public class ClosetService : IClosetService
    {
        private readonly IUnitOfWork unitOfWork;

        public ClosetService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<List<Closet>> GetClosetsAsync()
        {
            return await unitOfWork.GetRepository<Closet>().GetAllAsyn();
        }

        public async Task AddClosetAsyn(Closet closet)
        {
            await unitOfWork.GetRepository<Closet>().AddAsyn(closet);
        }
    }
}
