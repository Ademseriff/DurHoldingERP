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
        public async Task DeleteBathCeramicAsyn(BathCeramic bathCeramic)
        {

            await unitOfWork.GetRepository<BathCeramic>().DeleteAsyn(bathCeramic);
        }
        public async Task UpdateAmount(UpdateDto updateDto)
        {
            try
            {
                var BathC = await unitOfWork.GetRepository<BathCeramic>().GetAsyn(x => x.BarcodeId == updateDto.BarkodId);
                int addedAmount = int.Parse(BathC.CeramicAmount) + int.Parse(updateDto.AddClosetAmount);
                BathC.CeramicAmount = addedAmount.ToString();
                if (updateDto.Price != null)
                {
                    BathC.CeramicPrice = updateDto.Price.ToString();

                }
                await unitOfWork.GetRepository<BathCeramic>().UpdateAsyn(BathC);
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
