﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using POSSystem.Infrastructure.Context;

namespace POSSystem.Infrastructure.Migrations
{
    [DbContext(typeof(POSDbContext))]
    partial class POSDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("POSSystem.Domain.Models.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit")
                        .HasAnnotation("ColumnOrder", 101);

                    b.Property<string>("CreatedByUser")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(100)")
                        .HasDefaultValueSql("(CURRENT_USER)")
                        .HasAnnotation("ColumnOrder", 102);

                    b.Property<DateTime?>("CreatedDate")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getUTCDate())")
                        .HasAnnotation("ColumnOrder", 104);

                    b.Property<string>("CreatedIp")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(100)")
                        .HasDefaultValueSql("(CURRENT_USER)")
                        .HasAnnotation("ColumnOrder", 103);

                    b.Property<string>("Description")
                        .HasColumnType("varchar(300)");

                    b.Property<string>("ModifiedByUser")
                        .HasColumnType("nvarchar(100)")
                        .HasAnnotation("ColumnOrder", 105);

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime")
                        .HasAnnotation("ColumnOrder", 107);

                    b.Property<string>("ModifiedIp")
                        .HasColumnType("nvarchar(100)")
                        .HasAnnotation("ColumnOrder", 106);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("categories","dbo");
                });

            modelBuilder.Entity("POSSystem.Domain.Models.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit")
                        .HasAnnotation("ColumnOrder", 101);

                    b.Property<string>("Address")
                        .HasColumnType("varchar(200)");

                    b.Property<string>("CreatedByUser")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(100)")
                        .HasDefaultValueSql("(CURRENT_USER)")
                        .HasAnnotation("ColumnOrder", 102);

                    b.Property<DateTime?>("CreatedDate")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getUTCDate())")
                        .HasAnnotation("ColumnOrder", 104);

                    b.Property<string>("CreatedIp")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(100)")
                        .HasDefaultValueSql("(CURRENT_USER)")
                        .HasAnnotation("ColumnOrder", 103);

                    b.Property<string>("Email")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Identification")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("LastName")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("ModifiedByUser")
                        .HasColumnType("nvarchar(100)")
                        .HasAnnotation("ColumnOrder", 105);

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime")
                        .HasAnnotation("ColumnOrder", 107);

                    b.Property<string>("ModifiedIp")
                        .HasColumnType("nvarchar(100)")
                        .HasAnnotation("ColumnOrder", 106);

                    b.Property<string>("Phone")
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.ToTable("customers","dbo");
                });

            modelBuilder.Entity("POSSystem.Domain.Models.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit")
                        .HasAnnotation("ColumnOrder", 101);

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<string>("CreatedByUser")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(100)")
                        .HasDefaultValueSql("(CURRENT_USER)")
                        .HasAnnotation("ColumnOrder", 102);

                    b.Property<DateTime?>("CreatedDate")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getUTCDate())")
                        .HasAnnotation("ColumnOrder", 104);

                    b.Property<string>("CreatedIp")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(100)")
                        .HasDefaultValueSql("(CURRENT_USER)")
                        .HasAnnotation("ColumnOrder", 103);

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ModifiedByUser")
                        .HasColumnType("nvarchar(100)")
                        .HasAnnotation("ColumnOrder", 105);

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime")
                        .HasAnnotation("ColumnOrder", 107);

                    b.Property<string>("ModifiedIp")
                        .HasColumnType("nvarchar(100)")
                        .HasAnnotation("ColumnOrder", 106);

                    b.Property<string>("Observation")
                        .HasColumnType("varchar(200)");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime");

                    b.Property<Guid>("PaymentId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("PaymentId");

                    b.ToTable("orders","dbo");
                });

            modelBuilder.Entity("POSSystem.Domain.Models.OrderDetail", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit")
                        .HasAnnotation("ColumnOrder", 101);

                    b.Property<string>("CreatedByUser")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(100)")
                        .HasDefaultValueSql("(CURRENT_USER)")
                        .HasAnnotation("ColumnOrder", 102);

                    b.Property<DateTime?>("CreatedDate")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getUTCDate())")
                        .HasAnnotation("ColumnOrder", 104);

                    b.Property<string>("CreatedIp")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(100)")
                        .HasDefaultValueSql("(CURRENT_USER)")
                        .HasAnnotation("ColumnOrder", 103);

                    b.Property<decimal>("Discount")
                        .HasColumnType("decimal(9,2)");

                    b.Property<string>("ModifiedByUser")
                        .HasColumnType("nvarchar(100)")
                        .HasAnnotation("ColumnOrder", 105);

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime")
                        .HasAnnotation("ColumnOrder", 107);

                    b.Property<string>("ModifiedIp")
                        .HasColumnType("nvarchar(100)")
                        .HasAnnotation("ColumnOrder", 106);

                    b.Property<Guid>("OrderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(9,2)");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(9,2)");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("orders_detail","dbo");
                });

            modelBuilder.Entity("POSSystem.Domain.Models.PaymentMethod", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit")
                        .HasAnnotation("ColumnOrder", 101);

                    b.Property<string>("CreatedByUser")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(100)")
                        .HasDefaultValueSql("(CURRENT_USER)")
                        .HasAnnotation("ColumnOrder", 102);

                    b.Property<DateTime?>("CreatedDate")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getUTCDate())")
                        .HasAnnotation("ColumnOrder", 104);

                    b.Property<string>("CreatedIp")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(100)")
                        .HasDefaultValueSql("(CURRENT_USER)")
                        .HasAnnotation("ColumnOrder", 103);

                    b.Property<string>("Description")
                        .HasColumnType("varchar(200)");

                    b.Property<string>("ModifiedByUser")
                        .HasColumnType("nvarchar(100)")
                        .HasAnnotation("ColumnOrder", 105);

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime")
                        .HasAnnotation("ColumnOrder", 107);

                    b.Property<string>("ModifiedIp")
                        .HasColumnType("nvarchar(100)")
                        .HasAnnotation("ColumnOrder", 106);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.ToTable("payment_method","dbo");
                });

            modelBuilder.Entity("POSSystem.Domain.Models.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit")
                        .HasAnnotation("ColumnOrder", 101);

                    b.Property<string>("BarCode")
                        .HasColumnType("varchar(50)");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedByUser")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(100)")
                        .HasDefaultValueSql("(CURRENT_USER)")
                        .HasAnnotation("ColumnOrder", 102);

                    b.Property<DateTime?>("CreatedDate")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getUTCDate())")
                        .HasAnnotation("ColumnOrder", 104);

                    b.Property<string>("CreatedIp")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(100)")
                        .HasDefaultValueSql("(CURRENT_USER)")
                        .HasAnnotation("ColumnOrder", 103);

                    b.Property<string>("Description")
                        .HasColumnType("varchar(300)");

                    b.Property<int>("InStock")
                        .HasColumnType("int");

                    b.Property<string>("ModifiedByUser")
                        .HasColumnType("nvarchar(100)")
                        .HasAnnotation("ColumnOrder", 105);

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime")
                        .HasAnnotation("ColumnOrder", 107);

                    b.Property<string>("ModifiedIp")
                        .HasColumnType("nvarchar(100)")
                        .HasAnnotation("ColumnOrder", 106);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(9,2)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("products","dbo");
                });

            modelBuilder.Entity("POSSystem.Domain.Models.Order", b =>
                {
                    b.HasOne("POSSystem.Domain.Models.Customer", "customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .IsRequired();

                    b.HasOne("POSSystem.Domain.Models.PaymentMethod", "paymentMethod")
                        .WithMany("orders")
                        .HasForeignKey("PaymentId")
                        .IsRequired();
                });

            modelBuilder.Entity("POSSystem.Domain.Models.OrderDetail", b =>
                {
                    b.HasOne("POSSystem.Domain.Models.Order", "order")
                        .WithMany("orderDetails")
                        .HasForeignKey("OrderId")
                        .IsRequired();

                    b.HasOne("POSSystem.Domain.Models.Product", "product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .IsRequired();
                });

            modelBuilder.Entity("POSSystem.Domain.Models.Product", b =>
                {
                    b.HasOne("POSSystem.Domain.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
