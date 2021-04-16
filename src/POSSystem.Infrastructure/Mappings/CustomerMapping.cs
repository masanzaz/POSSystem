using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using POSSystem.Domain.Models;
using POSSystem.Infrastructure.Configurations;

namespace POSSystem.Infrastructure.Mappings
{
    public class CustomerMapping : ConfigurationBase<Customer>
    {
        public override string TableName => "customers";

        public override void ConfigureEntity(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(b => b.Identification)
                .IsRequired(true)
                .HasColumnType("varchar(20)");

            builder.Property(b => b.FirstName)
                .IsRequired(true)
                .HasColumnType("varchar(100)");

            builder.Property(b => b.LastName)
                .IsRequired(false)
                .HasColumnType("varchar(100)");

            builder.Property(b => b.Address)
                .IsRequired(false)
                .HasColumnType("varchar(200)");

            builder.Property(b => b.Phone)
                .IsRequired(false)
                .HasColumnType("varchar(20)");

            builder.Property(b => b.Email)
                .IsRequired(false)
                .HasColumnType("varchar(50)");
        }
    }
}