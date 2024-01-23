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
    public class SiliconService : ISiliconService
    {
        private readonly IUnitOfWork unitOfWork;
        public SiliconService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }


        public async Task<List<Silicon>> GetSiliconsAsync()
        {
            return await unitOfWork.GetRepository<Silicon>().GetAllAsyn();
        }

        public async Task AddSiliconAsyn(Silicon silicon)
        {
            await unitOfWork.GetRepository<Silicon>().AddAsyn(silicon);
        }
        public async Task DeleteSiliconAsyn(Silicon silicon)
        {

            await unitOfWork.GetRepository<Silicon>().DeleteAsyn(silicon);
        }
        public async Task PasifDeleteSiliconAsyn(Silicon silicon)
        {
            silicon.IsDeleted = true;
            await unitOfWork.GetRepository<Silicon>().UpdateAsyn(silicon);
        }
        public async Task UpdateAmount(UpdateDto updateDto)
        {
            
            try
            {
                var silicon = await unitOfWork.GetRepository<Silicon>().GetAsyn(x => x.BarcodeId == updateDto.BarkodId);
                int addedAmount = int.Parse(silicon.SiliconAmount) + int.Parse(updateDto.AddClosetAmount);
                silicon.SiliconAmount = addedAmount.ToString();
                if (updateDto.Price != null)
                {
                    silicon.SiliconPrice = updateDto.Price.ToString();

                }
                await unitOfWork.GetRepository<Silicon>().UpdateAsyn(silicon);
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
