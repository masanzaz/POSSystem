using EFCoreColumnOrder;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using POSSystem.Domain.Models;
using POSSystem.Domain.Models.Kernel;
using System;

namespace POSSystem.Infrastructure.Configurations
{
    public abstract class ConfigurationBase<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : EntityEf<Guid>
    {
        public virtual string SchemaName { get; } = "dbo";

        public abstract string TableName { get; }

        public abstract void ConfigureEntity(EntityTypeBuilder<TEntity> builder);

        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.ToTable(TableName, SchemaName);

            ConfigureEntity(builder);

            builder.Property(e => e.Active)
               .IsRequired()
               .HasColumnOrder(101);

            builder.Property(e => e.CreatedByUser)
                .IsRequired()
                .HasDefaultValueSql("(CURRENT_USER)")
                .HasColumnType("nvarchar(100)")
                .HasColumnOrder(102);

            builder.Property(e => e.CreatedIp)
                .IsRequired()
                .HasDefaultValueSql("(CURRENT_USER)")
                .HasColumnType("nvarchar(100)")
                .HasColumnOrder(103);

            builder.Property(e => e.CreatedDate)
                .IsRequired()
                .HasDefaultValueSql("(getUTCDate())")
                .HasColumnType("datetime")
                .HasColumnOrder(104);

            builder.Property(e => e.ModifiedByUser)
                .IsRequired()
                .HasDefaultValueSql("(CURRENT_USER)")
                .HasColumnType("nvarchar(100)")
                .HasColumnOrder(105);

            builder.Property(e => e.ModifiedIp)
                .IsRequired()
                .HasDefaultValueSql("(CURRENT_USER)")
                .HasColumnType("nvarchar(100)")
                .HasColumnOrder(106);

            builder.Property(e => e.ModifiedDate)
                .IsRequired()
                .HasDefaultValueSql("(getUTCDate())")
                .HasColumnType("datetime")
                .HasColumnOrder(107);
        }
    }
}
