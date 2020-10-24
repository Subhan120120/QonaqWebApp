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
    [Migration("20201020082827_edited-reservation-table")]
    partial class editedreservationtable
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
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CarouselSubTitle1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CarouselSubTitle2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CarouselSubTitle3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CarouselSubTitle4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CarouselTitle1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CarouselTitle2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CarouselTitle3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CarouselTitle4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Facebook")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Instagram")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Twitter")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WebTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AppDetails");
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

                    b.Property<string>("MenuItemText")
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

                    b.Property<string>("MenuItemGroupText")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.HasKey("Id");

                    b.ToTable("MenuItemGroups");
                });

            modelBuilder.Entity("QonaqWebApp.Models.Entity.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Hall")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfGuest")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ReservationTableId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ReservationTableId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("QonaqWebApp.Models.Entity.ReservationTable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MaxGuest")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ReservationTables");
                });

            modelBuilder.Entity("QonaqWebApp.Models.Entity.MenuItem", b =>
                {
                    b.HasOne("QonaqWebApp.Models.Entity.MenuItemGroup", "MenuItemGroup")
                        .WithMany("menuItems")
                        .HasForeignKey("MenuItemGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("QonaqWebApp.Models.Entity.Reservation", b =>
                {
                    b.HasOne("QonaqWebApp.Models.Entity.ReservationTable", "ReservationTable")
                        .WithMany("Reservations")
                        .HasForeignKey("ReservationTableId");
                });
#pragma warning restore 612, 618
        }
    }
}
