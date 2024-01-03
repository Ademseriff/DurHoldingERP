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
    /// müşteri database validation class
    /// </summary>
    public class EmployeeMap : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(30).HasDefaultValue("NULL");
            builder.HasData(new Employee
            {
                Id = Guid.Parse("6DCE8FD3-EBCE-4669-80AF-B74B75911ED8"),
                Name = "Adem Şerif",
                Surname = "Dur",
                Age = 24,
                CreateTime = DateTime.Now,
                DepartmentId = Guid.Parse("6DCE8FD3-EBCE-4669-80AF-B74B75911ED6")
                
            }); 
        }
    }
}
