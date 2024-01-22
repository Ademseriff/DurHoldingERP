using DurHoldingErp.Entity.DTOs;
using DurHoldingErp.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DurHoldingErp.Service.Services.Abstractions
{
    public interface ISiliconService
    {
        Task<List<Silicon>> GetSiliconsAsync();

        Task AddSiliconAsyn(Silicon silicon);

        Task UpdateAmount(UpdateDto updateDto);

        Task DeleteSiliconAsyn(Silicon silicon);
    }
}
