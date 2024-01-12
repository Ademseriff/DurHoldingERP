using DurHoldingErp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DurHoldingErp.Entity.Entities
{
    public class Closet :EntityBase
    {
        public Closet()
        {
            Random rnd = new Random();
            BarcodeId = rnd.Next(1000, 9999);

        }
        public int BarcodeId { get; set; } 
        public string ClosetName { get; set; }

        public string ClosetPrice { get; set; }

        public string ClosetAmount { get; set; }
    }
}
