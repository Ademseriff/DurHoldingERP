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
    public class UserMap : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            // Primary key
            builder .HasKey(u => u.Id);

            // Indexes for "normalized" username and email, to allow efficient lookups
            builder.HasIndex(u => u.NormalizedUserName).HasName("UserNameIndex").IsUnique();
            builder.HasIndex(u => u.NormalizedEmail).HasName("EmailIndex");

            // Maps to the AspNetUsers table
            builder.ToTable("AspNetUsers");

            // A concurrency token for use with the optimistic concurrency checking
            builder.Property(u => u.ConcurrencyStamp).IsConcurrencyToken();

            // Limit the size of columns to use efficient database types
            builder.Property(u => u.UserName).HasMaxLength(256);
            builder.Property(u => u.NormalizedUserName).HasMaxLength(256);
            builder.Property(u => u.Email).HasMaxLength(256);
            builder.Property(u => u.NormalizedEmail).HasMaxLength(256);

            var user = new AppUser
            {
                Id ="31313132131231",
                Email = "ademserifd@gmail.com",
                PhoneNumberConfirmed = true,
                PhoneNumber = "05392956006",
                PasswordHash = "123456",
                UserName= "ademserif",
                EmailConfirmed = true,
                
               
            };
            var user2 = new AppUser
            {
                Id = "31313132131238",
                Email = "ademserifd@gmail.com",
                PhoneNumberConfirmed = true,
                PhoneNumber = "05392956006",
                PasswordHash = "123456",
                UserName = "ademserif",
                EmailConfirmed = true,


            };
            var user3 = new AppUser
            {
                Id = "31313132131290",
                Email = "ademserif@gmail.com",
                PhoneNumberConfirmed = true,
                PhoneNumber = "05392956006",
                PasswordHash = "123456",
                UserName = "ademserif",
                EmailConfirmed = true,


            };
            builder.HasData(user,user2,user3);
        }
    }
}
