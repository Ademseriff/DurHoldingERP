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
    public class KitchenCeramicService:IKitchenCeramicService
    {
        private readonly IUnitOfWork unitOfWork;

        public KitchenCeramicService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<List<KitchenCeramic>> GetKitchenCeramicAsync()
        {
            return await unitOfWork.GetRepository<KitchenCeramic>().GetAllAsyn();
        }

        public async Task AddKitchenCeramicAsyn(KitchenCeramic kitchenCeramic)
        {
            await unitOfWork.GetRepository<KitchenCeramic>().AddAsyn(kitchenCeramic);
        }
    }
}
