using DurHoldingErp.Entity.DTOs;
using DurHoldingErp.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DurHoldingErp.Service.Services.Abstractions
{
    public interface IClosetService
    {
        Task<List<Closet>> GetClosetsAsync();
        Task AddClosetAsyn(Closet closet);

        Task UpdateAmount(UpdateDto closetUpdateDto);

        Task DeleteClosetAsyn(Closet closet);
        Task<Closet> GetClosetAsyn(Closet closet);


    }
}
