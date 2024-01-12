using DurHoldingErp.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DurHoldingErp.Data.Mappings
{
    public class KitchenCeramicMap : IEntityTypeConfiguration<KitchenCeramic>
    {
        public void Configure(EntityTypeBuilder<KitchenCeramic> builder)
        {
            builder.HasData(new KitchenCeramic
            {
                CeramicName ="xx02",
                CeramicPrice ="3200",
                CeramicAmount="400"
               
            });
        }
    }
}
