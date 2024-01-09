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
            }, new Department
            {
                Id = Guid.Parse("1C30332A-D7CC-4C29-ABF9-B02BC87536EB"),
                CreateTime = DateTime.Now,
                DepartmentName = "It",
                IsDeleted = false
            }, new Department
            {
                Id = Guid.Parse("14B482FC-8374-40EF-9BAD-53F369B30771"),
                CreateTime = DateTime.Now,
                DepartmentName = "Ik",
                IsDeleted = false
            }, new Department
            {
                Id = Guid.Parse("9B930DCD-FD15-43CE-BE93-91C2B314A97F"),
                CreateTime = DateTime.Now,
                DepartmentName = "Security",
                IsDeleted = false
            }, new Department
            {
                Id = Guid.Parse("B2ECB1DD-6C51-4BD6-862D-61DF780DE333"),
                CreateTime = DateTime.Now,
                DepartmentName = "Driver",
                IsDeleted = false
            }, new Department
            {
                Id = Guid.Parse("173BF7C5-9F43-4F2A-AFBD-F2A6E15B4D41"),
                CreateTime = DateTime.Now,
                DepartmentName = "Worker",
                IsDeleted = false
            }, new Department
            {
                Id = Guid.Parse("65DCC325-B971-4979-AD4C-52FE91509D5A"),
                CreateTime = DateTime.Now,
                DepartmentName = "CEO or Deputy ceo",
                IsDeleted = false
            });
        }
    }
}
