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
    public class InvoiceService : IInvoiceService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IClosetService closetService;
        private readonly IKitchenCeramicService kitchenCeramicService;
        private readonly IBathCeramicService bathCeramicService;
        private readonly ICementService cementService;
        private readonly ISiliconService siliconService;

        public InvoiceService(IUnitOfWork unitOfWork,IClosetService closetService,IKitchenCeramicService kitchenCeramicService,IBathCeramicService bathCeramicService,ICementService cementService,ISiliconService siliconService)
        {
            this.unitOfWork = unitOfWork;
            this.closetService = closetService;
            this.kitchenCeramicService = kitchenCeramicService;
            this.bathCeramicService = bathCeramicService;
            this.cementService = cementService;
            this.siliconService = siliconService;
        }

        public async Task<List<Invoice>> GetInvoiceAsync()
        {
            return await unitOfWork.GetRepository<Invoice>().GetAllAsyn();
        }

        public async Task<Invoice> GetSingleInvoiceAsync(int InvoiceNumber)
        {
            try
            {
                return await unitOfWork.GetRepository<Invoice>().GetAsyn(x => x.InvoiceNumber == InvoiceNumber);
            }
            catch
            {
                return null;
            }

        }

        public async Task AddInvoiceAsyn(Invoice ınvoice)
        {
           

            if (ınvoice.Product.Equals("closet"))
            {
                try { 
               var Entity = await unitOfWork.GetRepository<Closet>().GetAsyn(x => x.BarcodeId == ınvoice.BarcodeId);

                if (Entity != null)
                {
                 int kalan = int.Parse(Entity.ClosetAmount) - int.Parse(ınvoice.Piece);
                    if(kalan > 0)
                    {
                        Entity.ClosetAmount = kalan.ToString();
                        await unitOfWork.GetRepository<Closet>().UpdateAsyn(Entity);
                        await unitOfWork.GetRepository<Invoice>().AddAsyn(ınvoice);
                    }
                    else
                    {

                        }
                 }
                else
                {
                    // closetEntity değeri boşsa gerekli işlemleri burada yapabilirsiniz.
                }
                }catch (Exception ex)
                {
                            Console.WriteLine($"Bir hata oluştu: {ex.Message}");

                }
            }

            else if (ınvoice.Product.Equals("KitchenCeramic"))
            {
                try
                {
                    var Entity = await unitOfWork.GetRepository<KitchenCeramic>().GetAsyn(x => x.BarcodeId == ınvoice.BarcodeId);

                    if (Entity != null)
                    {
                        int kalan = int.Parse(Entity.CeramicAmount) - int.Parse(ınvoice.Piece);
                        if (kalan > 0)
                        {
                            Entity.CeramicAmount = kalan.ToString();
                            await unitOfWork.GetRepository<KitchenCeramic>().UpdateAsyn(Entity);
                            await unitOfWork.GetRepository<Invoice>().AddAsyn(ınvoice);
                        }
                        else
                        {

                        }
                    }
                    else
                    {
                        // closetEntity değeri boşsa gerekli işlemleri burada yapabilirsiniz.
                    }
                }catch(Exception ex) { Console.WriteLine($"Bir hata oluştu: {ex.Message}"); }
            }
            else if (ınvoice.Product.Equals("BathroomCeramic"))
            {
                try
                {
                    var Entity = await unitOfWork.GetRepository<BathCeramic>().GetAsyn(x => x.BarcodeId == ınvoice.BarcodeId);

                    if (Entity != null)
                    {
                        int kalan = int.Parse(Entity.CeramicAmount) - int.Parse(ınvoice.Piece);
                        if (kalan > 0)
                        {
                            Entity.CeramicAmount = kalan.ToString();
                            await unitOfWork.GetRepository<BathCeramic>().UpdateAsyn(Entity);
                            await unitOfWork.GetRepository<Invoice>().AddAsyn(ınvoice);
                        }
                        else
                        {

                        }
                    }
                    else
                    {
                        // closetEntity değeri boşsa gerekli işlemleri burada yapabilirsiniz.
                    }
                }catch (Exception ex) { Console.WriteLine($"Bir hata oluştu: {ex.Message}"); }

            }
            else if (ınvoice.Product.Equals("Cement"))
            {
                try
                {
                    var Entity = await unitOfWork.GetRepository<Cement>().GetAsyn(x => x.BarcodeId == ınvoice.BarcodeId);

                    if (Entity != null)
                    {
                        int kalan = int.Parse(Entity.CementAmount) - int.Parse(ınvoice.Piece);
                        if (kalan > 0)
                        {
                            Entity.CementAmount = kalan.ToString();
                            await unitOfWork.GetRepository<Cement>().UpdateAsyn(Entity);
                            await unitOfWork.GetRepository<Invoice>().AddAsyn(ınvoice);
                        }
                        else
                        {

                        }
                    }
                    else
                    {
                        // closetEntity değeri boşsa gerekli işlemleri burada yapabilirsiniz.
                    }
                }catch(Exception ex) { Console.WriteLine($"Bir hata oluştu: {ex.Message}"); }

            }
            else if (ınvoice.Product.Equals("Silicon"))
            {
                try
                {
                    var Entity = await unitOfWork.GetRepository<Silicon>().GetAsyn(x => x.BarcodeId == ınvoice.BarcodeId);

                    if (Entity != null)
                    {
                        int kalan = int.Parse(Entity.SiliconAmount) - int.Parse(ınvoice.Piece);
                        if (kalan > 0)
                        {
                            Entity.SiliconAmount = kalan.ToString();
                            await unitOfWork.GetRepository<Silicon>().UpdateAsyn(Entity);
                            await unitOfWork.GetRepository<Invoice>().AddAsyn(ınvoice);
                        }
                        else
                        {

                        }
                    }
                    else
                    {
                        // closetEntity değeri boşsa gerekli işlemleri burada yapabilirsiniz.
                    }
                }catch (Exception ex) { Console.WriteLine(ex.ToString()); }


            }
            else { Console.WriteLine("Bir hata meydana geldi"); }
          
        }

       
    }
}
