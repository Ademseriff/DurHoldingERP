using DurHoldingErp.Entity.DTOs;
using DurHoldingErp.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DurHoldingErp.Service.Services.Abstractions
{
    public interface ICementService
    {
        Task<List<Cement>> GetCementsAsync();
        Task AddCementAsyn(Cement cement);

        Task UpdateAmount(UpdateDto updateDto);
        Task DeleteCementAsyn(Cement cement);
        Task PasifDeleteCementAsyn(Cement cement);
    }
}
