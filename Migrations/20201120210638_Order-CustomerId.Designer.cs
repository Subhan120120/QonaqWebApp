﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QonaqWebApp.Models.Context;

namespace QonaqWebApp.Migrations
{
    [DbContext(typeof(QonaqContext))]
    [Migration("20201120210638_Order-CustomerId")]
    partial class OrderCustomerId
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("QonaqWebApp.Models.Entity.AppDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("About")
                        .HasColumnType("nvarchar(190)")
                        .HasMaxLength(190);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(300)")
                        .HasMaxLength(300);

                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Facebook")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Heading")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Instagram")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubHeading")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Twitter")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("WebTitle")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.ToTable("AppDetails");
                });

            modelBuilder.Entity("QonaqWebApp.Models.Entity.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(300)")
                        .HasMaxLength(300);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("QonaqWebApp.Models.Entity.DineInTable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DineInTableGroupId")
                        .HasColumnType("int");

                    b.Property<int>("MaxGuest")
                        .HasColumnType("int");

                    b.Property<string>("TableName")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.HasKey("Id");

                    b.HasIndex("DineInTableGroupId");

                    b.ToTable("DineInTables");
                });

            modelBuilder.Entity("QonaqWebApp.Models.Entity.DineInTableGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MaxGuest")
                        .HasColumnType("int");

                    b.Property<string>("TableGroupName")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.HasKey("Id");

                    b.ToTable("DineInTableGroups");
                });

            modelBuilder.Entity("QonaqWebApp.Models.Entity.MenuItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("MenuItemDescription")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("MenuItemGroupId")
                        .HasColumnType("int");

                    b.Property<string>("MenuItemName")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("MenuItemGroupId");

                    b.ToTable("MenuItems");
                });

            modelBuilder.Entity("QonaqWebApp.Models.Entity.MenuItemGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MenuItemGroupName")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.HasKey("Id");

                    b.ToTable("MenuItemGroups");
                });

            modelBuilder.Entity("QonaqWebApp.Models.Entity.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int?>("MenuItemId")
                        .HasColumnType("int");

                    b.Property<float>("Quantity")
                        .HasColumnType("real");

                    b.Property<bool>("Sended")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("MenuItemId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("QonaqWebApp.Models.Entity.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DineInTableGroupId")
                        .HasColumnType("int");

                    b.Property<int?>("DineInTableId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.Property<int>("NumberOfGuest")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("DineInTableGroupId");

                    b.HasIndex("DineInTableId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("QonaqWebApp.Models.Entity.DineInTable", b =>
                {
                    b.HasOne("QonaqWebApp.Models.Entity.DineInTableGroup", "DineInTableGroup")
                        .WithMany("DineInTables")
                        .HasForeignKey("DineInTableGroupId");
                });

            modelBuilder.Entity("QonaqWebApp.Models.Entity.MenuItem", b =>
                {
                    b.HasOne("QonaqWebApp.Models.Entity.MenuItemGroup", "MenuItemGroup")
                        .WithMany("menuItems")
                        .HasForeignKey("MenuItemGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("QonaqWebApp.Models.Entity.Order", b =>
                {
                    b.HasOne("QonaqWebApp.Models.Entity.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId");

                    b.HasOne("QonaqWebApp.Models.Entity.MenuItem", "MenuItem")
                        .WithMany("Orders")
                        .HasForeignKey("MenuItemId");
                });

            modelBuilder.Entity("QonaqWebApp.Models.Entity.Reservation", b =>
                {
                    b.HasOne("QonaqWebApp.Models.Entity.DineInTableGroup", "DineInTableGroup")
                        .WithMany("Reservations")
                        .HasForeignKey("DineInTableGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QonaqWebApp.Models.Entity.DineInTable", "DineInTable")
                        .WithMany("Reservations")
                        .HasForeignKey("DineInTableId");
                });
#pragma warning restore 612, 618
        }
    }
}
