using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using POSSystem.Domain.Models;
using POSSystem.Infrastructure.Configurations;

namespace POSSystem.Infrastructure.Mappings
{
    public class OrderDetailMapping : ConfigurationBase<OrderDetail>
    {
        public override string TableName => "orders_detail";

        public override void ConfigureEntity(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(b => b.OrderId)
                .IsRequired();

            builder.Property(b => b.ProductId)
                .IsRequired();

            builder.Property(b => b.UnitPrice)
                .IsRequired(true)
                .HasColumnType("decimal(9,2)");

            builder.Property(b => b.Quantity)
                .IsRequired(true)
                .HasColumnType("int");

            builder.Property(b => b.Discount)
                .IsRequired(true)
                .HasColumnType("decimal(9,2)");

            builder.Property(b => b.Total)
                .IsRequired(true)
                .HasColumnType("decimal(9,2)");
        }
    }
}

