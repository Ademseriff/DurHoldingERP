using DurHoldingErp.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DurHoldingErp.Service.Services.Abstractions
{
    public interface IInvoiceService
    {
        Task<List<Invoice>> GetInvoiceAsync();
        Task AddInvoiceAsyn(Invoice ınvoice);
        Task<Invoice> GetSingleInvoiceAsync(int InvoiceNumber);
    }
}
