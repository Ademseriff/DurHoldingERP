using DurHoldingErp.Entity.DTOs;
using DurHoldingErp.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DurHoldingErp.Service.Services.Abstractions
{
    /// <summary>
    /// bathseramic  repository işlemleri
    /// </summary>
    public interface IBathCeramicService
    {

        Task<List<BathCeramic>> GetBathCeramicsAsync();
        Task AddBathCeramicAsyn(BathCeramic bathCeramic);

        Task UpdateAmount(UpdateDto updateDto);

        Task DeleteBathCeramicAsyn(BathCeramic bathCeramic);
    }
}
