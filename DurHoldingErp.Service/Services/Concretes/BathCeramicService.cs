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
    /// <summary>
    /// bathceramic repository işlemleri.
    /// </summary>
    public class BathCeramicService : IBathCeramicService
    {
        private readonly IUnitOfWork unitOfWork;

        public BathCeramicService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<List<BathCeramic>> GetBathCeramicsAsync()
        {
            return await unitOfWork.GetRepository<BathCeramic>().GetAllAsyn();
        }

        public async Task AddBathCeramicAsyn(BathCeramic bathCeramic)
        {
            await unitOfWork.GetRepository<BathCeramic>().AddAsyn(bathCeramic);
        }
    }
}
