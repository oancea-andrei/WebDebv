﻿// <auto-generated />
using AutoDepoDB.Database.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AutoDepo.Database.Migrations
{
    [DbContext(typeof(AutoDepoDBContext))]
    partial class AutoDepoDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AutoDepoDB.Database.Entities.CarBrand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BrandName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CarBrand");
                });

            modelBuilder.Entity("AutoDepoDB.Database.Entities.CarModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CarBrandID")
                        .HasColumnType("int");

                    b.Property<string>("Series")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CarBrandID");

                    b.ToTable("CarModel");
                });

            modelBuilder.Entity("AutoDepoDB.Database.Entities.CarModel", b =>
                {
                    b.HasOne("AutoDepoDB.Database.Entities.CarBrand", "CarBrand")
                        .WithMany("CarModel")
                        .HasForeignKey("CarBrandID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CarBrand");
                });

            modelBuilder.Entity("AutoDepoDB.Database.Entities.CarBrand", b =>
                {
                    b.Navigation("CarModel");
                });
#pragma warning restore 612, 618
        }
    }
}