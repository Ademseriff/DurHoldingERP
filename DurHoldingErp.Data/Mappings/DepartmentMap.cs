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
    //Bu classs verdiğimiz entitlere tabolara database tarafında zorunluluk kılmamızı sağlayan classtır 
    //ayrıca datalar oluşturmamızı birçok özellik sunuyor.
    /// <summary>
    /// departman database validation class
    /// </summary>
    public class DepartmentMap : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasData(new Department
            {
                Id = Guid.Parse("6DCE8FD3-EBCE-4669-80AF-B74B75911ED6"),
                CreateTime = DateTime.Now,
                DepartmentName = "yönetici",
                IsDeleted = false
            });
        }
    }
}
