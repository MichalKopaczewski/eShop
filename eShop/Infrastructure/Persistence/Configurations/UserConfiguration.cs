using eShop.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShop.Infrastructure.Persistence.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(item => item.Id);
            builder.Property(a => a.Id).ValueGeneratedOnAdd();
            builder.HasIndex(a => a.Id).IsUnique();

            builder.HasKey(item => item.UserName);
            builder.HasIndex(a => a.UserName).IsUnique();

        }
    }
}
