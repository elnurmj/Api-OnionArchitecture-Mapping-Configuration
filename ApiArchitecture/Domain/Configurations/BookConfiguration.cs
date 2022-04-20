using DomainLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace DomainLayer.Configurations
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.Property(m => m.Name).IsRequired().HasMaxLength(200);
            builder.Property(m => m.Page).IsRequired();
            builder.Property(m => m.AuthorName).IsRequired(false).HasMaxLength(300);
            builder.Property(m => m.CreatedDate).HasDefaultValue(DateTime.Now);
            builder.Property(m => m.SoftDelete).HasDefaultValue(false);
        }
    }
}
