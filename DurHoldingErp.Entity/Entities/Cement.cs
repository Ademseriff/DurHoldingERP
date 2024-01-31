using DurHoldingErp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DurHoldingErp.Entity.Entities
{
    public class Cement : EntityBase
    {
        public Cement()
        {
            Random rnd = new Random();
            BarcodeId = rnd.Next(1000, 9999);
        }

        public int BarcodeId { get; set; }
        public string CementName { get; set; }

        public string CementPrice { get; set; }

        public string CementAmount { get; set; }
    }
}
