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
    public class CementService : ICementService
    {
        private readonly IUnitOfWork unitOfWork;
        public CementService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<List<Cement>> GetCementsAsync()
        {
            return await unitOfWork.GetRepository<Cement>().GetAllAsyn();
        }

        public async Task AddCementAsyn(Cement cement)
        {
            await unitOfWork.GetRepository<Cement>().AddAsyn(cement);
        }

        public async Task UpdateAmount(UpdateDto updateDto)
        {
            try
            {
                var x = await unitOfWork.GetRepository<Cement>().GetAsyn(x => x.BarcodeId == updateDto.BarkodId);
                int addedAmount = int.Parse(x.CementAmount) + int.Parse(updateDto.AddClosetAmount);
                x.CementAmount = addedAmount.ToString();
                if (updateDto.Price != null)
                {
                    x.CementPrice = updateDto.Price.ToString();

                }
                await unitOfWork.GetRepository<Cement>().UpdateAsyn(x);
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
