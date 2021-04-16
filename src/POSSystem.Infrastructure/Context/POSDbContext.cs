using POSSystem.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using POSSystem.Domain.Models.Kernel;
using System;
using System.Security.Principal;
using Microsoft.EntityFrameworkCore.Migrations;
using EFCoreColumnOrder;
using POSSystem.Infrastructure.Configurations;

namespace POSSystem.Infrastructure.Context
{
    public class POSDbContext : DbContext
    {
        private readonly IIdentity _identity;
        // private readonly HttpContextBase _httpContext;

        public POSDbContext(DbContextOptions options) : base(options) { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var property in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetProperties()
                    .Where(p => p.ClrType == typeof(string))))
                property.SetColumnType("varchar(150)");

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DbContextOptions).Assembly);

            foreach (var relationship in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetForeignKeys())) relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;

            modelBuilder.ApplyAllConfigurations();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.ReplaceService<IMigrationsAnnotationProvider, CustomAnnotationProvider>();
            optionsBuilder.ReplaceService<IMigrationsSqlGenerator, CustomSqlServerMigrationsSqlGenerator>();
        }
        public void CheckForAuditables()
        {
            var a = ChangeTracker.Entries();
            var modifiedEntries = ChangeTracker.Entries()
                .Where(x => x.Entity is IAuditable
                            && (x.State == EntityState.Added
                            || x.State == EntityState.Modified
                            || x.State == EntityState.Deleted));

            // bool esRequest = (HttpContext.Current != null);
            //string ip = (_httpContext != null) ?
            ///    (_httpContext.Request.UserHostAddress) :
            //   "Ejecudado desde servicio local";
            string ip = "test";
            string identityName = "test";
            //string identityName = _identity?.Name ?? "Servicio Local";

            DateTime now = DateTime.Now;

            foreach (var entry in modifiedEntries)
            {
                IAuditable entity = (IAuditable)entry.Entity;
                if (entity != null)
                {
                    switch (entry.State)
                    {
                        case (EntityState.Added):
                            entity.CreatedByUser = identityName;
                            entity.CreatedDate = now;
                            entity.CreatedIp = ip;
                            entity.Active = true;
                            break;
                        case (EntityState.Modified):
                            entity.ModifiedDate = now;
                            entity.ModifiedByUser = identityName;
                            entity.ModifiedIp = ip;
                            entry.Property(nameof(entity.CreatedByUser)).IsModified = false;
                            entry.Property(nameof(entity.CreatedDate)).IsModified = false;
                            entry.Property(nameof(entity.CreatedIp)).IsModified = false;
                            break;
                        case (EntityState.Deleted):
                            entity.ModifiedDate = now;
                            entity.ModifiedByUser = identityName;
                            entity.ModifiedIp = ip;
                            entity.Active = false;
                            entry.Property(nameof(entity.CreatedByUser)).IsModified = false;
                            entry.Property(nameof(entity.CreatedDate)).IsModified = false;
                            entry.Property(nameof(entity.CreatedIp)).IsModified = false;
                            entry.State = EntityState.Modified;
                            break;
                    }
                }
            }

        }

        #region Entities
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        #endregion

    }
}
