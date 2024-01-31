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
    public class UsersMap : IEntityTypeConfiguration<Users>
    {
        public void Configure(EntityTypeBuilder<Users> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(50);
            builder.Property(x => x.Email).HasMaxLength(100);
            builder.Property(x => x.Password).HasMaxLength(100);

            builder.HasData(new Users
            {
                Id = Guid.Parse("242DD5EF-F646-4BBE-9274-6FBB6A26331B"),
                Name = "Adem",
                Email ="ademserifd@gmail.com",
                Password = "123456",
                Role ="SüperAdmin"
            }, new Users
            {
                Id = Guid.Parse("242DD5EF-F646-4BBE-9274-6FBB6A26981B"),
                Name = "Kerem",
                Email = "ademserifd@gmail.com",
                Password = "123456",
                Role = "Admin"
            });

        }
    }
}
