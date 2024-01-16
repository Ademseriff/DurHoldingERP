using DurHoldingErp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DurHoldingErp.Entity.DTOs
{
    public class AddInvoiceDto :EntityBase
    {
        public AddInvoiceDto()
        {
            Random rnd = new Random();
            InvoiceNumber = rnd.Next(1000, 9999);
            SellerInformation = "DUR HOLDING";
        }

        public int InvoiceNumber { get; set; }

        public string SellerInformation { get; set; }

        public string ReceiverInformations { get; set; }

        public string Product { get; set; }

        public int BarcodeId { get; set; }

        public string Amount { get; set; }

        public string Piece { get; set; }




    }
}
