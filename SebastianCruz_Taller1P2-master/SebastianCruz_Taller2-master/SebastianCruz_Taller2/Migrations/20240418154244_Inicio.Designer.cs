﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace SebastianCruz_Taller2.Migrations
{
    [DbContext(typeof(SebastianCruz_DbContext))]
    [Migration("20240418154244_Inicio")]
    partial class Inicio
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SebastianCruz_Taller2.Models.Burger", b =>
                {
                    b.Property<int>("BurgerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BurgerID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("WithCheese")
                        .HasColumnType("bit");

                    b.HasKey("BurgerID");

                    b.ToTable("Burger");
                });

            modelBuilder.Entity("SebastianCruz_Taller2.Models.Promo", b =>
                {
                    b.Property<int>("PromoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PromoID"));

                    b.Property<int?>("BurgerID")
                        .HasColumnType("int");

                    b.Property<int>("BurguerID")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaPromo")
                        .HasColumnType("datetime2");

                    b.HasKey("PromoID");

                    b.HasIndex("BurgerID");

                    b.ToTable("Promo");
                });

            modelBuilder.Entity("SebastianCruz_Taller2.Models.Promo", b =>
                {
                    b.HasOne("SebastianCruz_Taller2.Models.Burger", "Burger")
                        .WithMany("Promo")
                        .HasForeignKey("BurgerID");

                    b.Navigation("Burger");
                });

            modelBuilder.Entity("SebastianCruz_Taller2.Models.Burger", b =>
                {
                    b.Navigation("Promo");
                });
#pragma warning restore 612, 618
        }
    }
}
