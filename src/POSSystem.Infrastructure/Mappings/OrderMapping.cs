using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using POSSystem.Domain.Models;
using POSSystem.Infrastructure.Configurations;

namespace POSSystem.Infrastructure.Mappings
{
    public class OrderMapping : ConfigurationBase<Order>
    {
        public override string TableName => "orders";

        public override void ConfigureEntity(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(b => b.CustomerId)
                .IsRequired();

            builder.Property(b => b.Codigo)
                .IsRequired(true)
                .HasColumnType("varchar(10)");

            builder.Property(b => b.PaymentId)
                .IsRequired();

            builder.Property(b => b.OrderDate)
                .IsRequired()
                .HasColumnType("datetime");

            builder.Property(b => b.Observation)
                .IsRequired(false)
                .HasColumnType("varchar(200)");

            // 1 : N => order : orderDetails
            builder.HasMany(c => c.orderDetails)
                .WithOne(b => b.order)
                .HasForeignKey(b => b.OrderId);
        }
    }
}