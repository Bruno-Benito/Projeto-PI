using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portifolio.Domain.Models;

namespace Portifolio.Data.Configuration
{
    public class UserEntityConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");
            builder.Property(u => u.Id)
            .ValueGeneratedOnAdd();
            builder.Property(u => u.Name)
            .HasMaxLength(30)
            .IsRequired()
            .IsUnicode(false);
             builder.Property(u => u.Passworld)
                .HasMaxLength(15)
                .IsRequired();
        }
    }
}