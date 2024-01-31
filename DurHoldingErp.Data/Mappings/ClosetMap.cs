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
    public class ClosetMap : IEntityTypeConfiguration<Closet>
    {
        public void Configure(EntityTypeBuilder<Closet> builder)
        {
            builder.HasData(new Closet
            {
                ClosetName = "Babel Rezervuarsız",
                ClosetPrice = "6120",
                ClosetAmount ="2000"
            }, new Closet
            {
                ClosetName = "Babel Rezervuar",
                ClosetPrice = "6400",
                ClosetAmount = "1500"
            });
        }
    }
}
