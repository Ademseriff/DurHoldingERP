using DurHoldingErp.Entity.DTOs;
using DurHoldingErp.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DurHoldingErp.Service.Services.Abstractions
{
    public interface IKitchenCeramicService
    {
        Task<List<KitchenCeramic>> GetKitchenCeramicAsync();

        Task AddKitchenCeramicAsyn(KitchenCeramic kitchenCeramic);

        Task UpdateAmount(UpdateDto UpdateDto);

        Task DeleteKitchenCeramicAsyn(KitchenCeramic kitchenCeramic);
    }
}
