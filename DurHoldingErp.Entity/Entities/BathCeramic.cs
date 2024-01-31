using DurHoldingErp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DurHoldingErp.Entity.Entities
{
    public class BathCeramic : EntityBase
    {
        public BathCeramic() {
            Random rnd = new Random();
            BarcodeId = rnd.Next(1000, 9999);
        }

        public int BarcodeId { get; set; }
        public string CeramicName { get; set; }

        public string CeramicPrice { get; set; }

        public string CeramicAmount { get; set; }
    }
}
