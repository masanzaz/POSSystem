using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using POSSystem.Domain.Models;
using POSSystem.Infrastructure.Configurations;

namespace POSSystem.Infrastructure.Mappings
{
    public class PaymentMethodMapping : ConfigurationBase<PaymentMethod>
    {
        public override string TableName => "payment_method";

        public override void ConfigureEntity(EntityTypeBuilder<PaymentMethod> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(b => b.Name)
                .IsRequired(true)
                .HasColumnType("varchar(20)");

            builder.Property(b => b.Description)
                .IsRequired(false)
                .HasColumnType("varchar(200)");

            // 1 : N => PaymentMethod : orders
            builder.HasMany(c => c.orders)
                .WithOne(b => b.paymentMethod)
                .HasForeignKey(b => b.PaymentId);
        }
    }
}