using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using POSSystem.Domain.Models;
using POSSystem.Infrastructure.Configurations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POSSystem.Infrastructure.Mappings
{
    public class ProductMapping : ConfigurationBase<Product>
    {
        public override string TableName => "Products";

        public override void ConfigureEntity(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(b => b.Name)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.Property(b => b.Description)
                .IsRequired(false)
                .HasColumnType("varchar(300)");

            builder.Property(b => b.Price)
                .HasColumnType("decimal(9,2)")
                .IsRequired();

            builder.Property(b => b.BarCode)
                .HasColumnType("varchar(50)")
                .IsRequired(false);

            builder.Property(b => b.InStock)
                .HasColumnType("int")
                .IsRequired();

            builder.Property(b => b.CategoryId)
                .IsRequired();
        }
        /*public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(b => b.Name)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.Property(b => b.Description)
                .IsRequired(false)
                .HasColumnType("varchar(300)");

            builder.Property(b => b.Price)
                .HasColumnType("decimal(9,2)")
                .IsRequired();

            builder.Property(b => b.BarCode)
                .HasColumnType("varchar(50)")
                .IsRequired(false);

            builder.Property(b => b.InStock)
                .HasColumnType("int")
                .IsRequired();

            builder.Property(b => b.CategoryId)
                .IsRequired();

            builder.ToTable("Products");
        }
        */
    }
}