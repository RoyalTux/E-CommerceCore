﻿// <auto-generated />
using System;
using ECommerceCore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ECommerceCore.Migrations
{
    [DbContext(typeof(ECommerceDbContext))]
    [Migration("20191129115809_ChangedSeedData")]
    partial class ChangedSeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ECommerceCore.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int?>("ParentId");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            Id = 201,
                            Name = "Trance"
                        },
                        new
                        {
                            Id = 202,
                            Name = "PsychoTrance",
                            ParentId = 201
                        });
                });

            modelBuilder.Entity("ECommerceCore.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Album")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("Artist")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<int?>("CategoryId");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<double>("Price");

                    b.Property<int>("Quantity");

                    b.Property<DateTime>("ReleaseDate");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            Id = 101,
                            Album = "Summer Vibes",
                            Artist = "Electric Samurai",
                            CategoryId = 201,
                            Description = "Chill music",
                            Genre = "Trance",
                            Price = 5.0,
                            Quantity = 12,
                            ReleaseDate = new DateTime(2019, 11, 29, 13, 58, 9, 2, DateTimeKind.Local).AddTicks(9027),
                            Title = "Electric Samurai —  Mix Jan 2019"
                        });
                });

            modelBuilder.Entity("ECommerceCore.Models.Category", b =>
                {
                    b.HasOne("ECommerceCore.Models.Category", "ParentCategory")
                        .WithMany("SubCategories")
                        .HasForeignKey("ParentId");
                });

            modelBuilder.Entity("ECommerceCore.Models.Product", b =>
                {
                    b.HasOne("ECommerceCore.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId");
                });
#pragma warning restore 612, 618
        }
    }
}