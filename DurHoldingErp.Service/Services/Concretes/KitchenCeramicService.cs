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
    public class KitchenCeramicService : IKitchenCeramicService
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
        public async Task DeleteKitchenCeramicAsyn(KitchenCeramic kitchenCeramic)
        {

            await unitOfWork.GetRepository<KitchenCeramic>().DeleteAsyn(kitchenCeramic);
        }

        public async Task PasifDeleteKitchenCeramicAsyn(KitchenCeramic kitchenCeramic)
        {
            kitchenCeramic.IsDeleted = true;
            await unitOfWork.GetRepository<KitchenCeramic>().UpdateAsyn(kitchenCeramic);
        }


        public async Task UpdateAmount(UpdateDto updateDto)
        {
            try
            {
                var kitchenC = await unitOfWork.GetRepository<KitchenCeramic>().GetAsyn(x => x.BarcodeId == updateDto.BarkodId);
                int addedAmount = int.Parse(kitchenC.CeramicAmount) + int.Parse(updateDto.AddClosetAmount);
                kitchenC.CeramicAmount = addedAmount.ToString();
                if (updateDto.Price != null)
                {
                    kitchenC.CeramicPrice = updateDto.Price.ToString();

                }
                await unitOfWork.GetRepository<KitchenCeramic>().UpdateAsyn(kitchenC);
            }
            catch (Exception ex)
            {

                // Hata mesajını almak için ex.Message kullanılır
                string errorMessage = ex.Message;

                // Hata mesajını loglamak, kullanıcıya göstermek veya başka bir şekilde işlemek için kullanabilirsiniz
                Console.WriteLine("Hata Mesajı: " + errorMessage);


            }
        }
    }
}
