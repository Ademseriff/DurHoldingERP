using DurHoldingErp.Data.UnitOfWorks;
using DurHoldingErp.Entity.DTOs;
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
        private Closet _closet;
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
        public async Task<Closet> GetClosetAsyn(Closet closet)
        {
           
            return await unitOfWork.GetRepository<Closet>().GetAsyn(x => x.Id == closet.Id); ;
        }
        public async Task DeleteClosetAsyn(Closet closet)
        {
           
            await unitOfWork.GetRepository<Closet>().DeleteAsyn(closet);
        }
        public async Task PasifDeleteClosetAsyn(Closet closet)
        {
            closet.IsDeleted = true;
            await unitOfWork.GetRepository<Closet>().UpdateAsyn(closet);
        }

        public async Task UpdateAmount(UpdateDto closetUpdateDto)
        {
            try
            {
              var closet=  await unitOfWork.GetRepository<Closet>().GetAsyn(x => x.BarcodeId == closetUpdateDto.BarkodId);
              int addedAmount = int.Parse(closet.ClosetAmount) + int.Parse(closetUpdateDto.AddClosetAmount);
              closet.ClosetAmount =  addedAmount.ToString();
              if(closetUpdateDto.Price != null)
                {
                 closet.ClosetPrice = closetUpdateDto.Price.ToString();

                }
              await unitOfWork.GetRepository<Closet>().UpdateAsyn(closet);
            }catch (Exception ex) {

                // Hata mesajını almak için ex.Message kullanılır
                string errorMessage = ex.Message;

                // Hata mesajını loglamak, kullanıcıya göstermek veya başka bir şekilde işlemek için kullanabilirsiniz
                Console.WriteLine("Hata Mesajı: " + errorMessage);


            }
        }
    }
}
