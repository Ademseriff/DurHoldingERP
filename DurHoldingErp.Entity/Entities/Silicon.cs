using DurHoldingErp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DurHoldingErp.Entity.Entities
{
    public class Silicon : EntityBase
    {
        public Silicon()
        {
            Random rnd = new Random();
            BarcodeId = rnd.Next(1000, 9999);
        }

        public int BarcodeId { get; set; }
        public string SiliconName { get; set; }

        public string SiliconPrice { get; set; }

        public string SiliconAmount { get; set; }
    }
}
