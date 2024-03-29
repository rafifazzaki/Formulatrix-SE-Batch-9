﻿// <auto-generated />
using APITutorial.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace APITutorial.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.3");

            modelBuilder.Entity("APITutorial.Model.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Electronics",
                            Description = "Electronic Items"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Clothes",
                            Description = "Clothes Items"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Grocery",
                            Description = "Grocery Items"
                        });
                });

            modelBuilder.Entity("APITutorial.Model.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryId = 1,
                            Description = "Laptop",
                            ProductName = "Laptop",
                            UnitPrice = 50000m
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 1,
                            Description = "Mobile",
                            ProductName = "Mobile",
                            UnitPrice = 20000m
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 2,
                            Description = "Shirt",
                            ProductName = "Shirt",
                            UnitPrice = 1000m
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryId = 2,
                            Description = "Pant",
                            ProductName = "Pant",
                            UnitPrice = 1500m
                        },
                        new
                        {
                            ProductId = 5,
                            CategoryId = 3,
                            Description = "Rice",
                            ProductName = "Rice",
                            UnitPrice = 50m
                        },
                        new
                        {
                            ProductId = 6,
                            CategoryId = 3,
                            Description = "Dal",
                            ProductName = "Dal",
                            UnitPrice = 100m
                        });
                });

            modelBuilder.Entity("APITutorial.Model.Product", b =>
                {
                    b.HasOne("APITutorial.Model.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("APITutorial.Model.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
