using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using POSSystem.Domain.Models;
using POSSystem.Infrastructure.Configurations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POSSystem.Infrastructure.Mappings
{
    public class CategoryMapping : ConfigurationBase<Category>
    {
        public override string TableName => "categories";

        public override void ConfigureEntity(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Name)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.Property(c => c.Description)
                .IsRequired(false)
                .HasColumnType("varchar(300)");

            // 1 : N => Category : Products
            builder.HasMany(c => c.Products)
                .WithOne(b => b.Category)
                .HasForeignKey(b => b.CategoryId);
        }
    }
}