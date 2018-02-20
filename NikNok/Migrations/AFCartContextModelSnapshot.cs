﻿// <auto-generated />
using NikNok.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace NikNok.Migrations
{
    [DbContext(typeof(NikNokContext))]
    partial class NikNokContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NikNok.Models.Categories", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("NikNok.Models.Products", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Availability");

                    b.Property<int?>("CategoryId");

                    b.Property<string>("Code");

                    b.Property<string>("Description");

                    b.Property<string>("ImageUrl");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<decimal>("Price");

                    b.Property<decimal>("Rating");

                    b.Property<int?>("SubCategoryId");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("SubCategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("NikNok.Models.SubCategories", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CategoryId");

                    b.Property<string>("Name")
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("SubCategories");
                });

            modelBuilder.Entity("NikNok.Models.Products", b =>
                {
                    b.HasOne("NikNok.Models.Categories", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("FK_Products_Categories");

                    b.HasOne("NikNok.Models.SubCategories", "SubCategory")
                        .WithMany("Products")
                        .HasForeignKey("SubCategoryId")
                        .HasConstraintName("FK_Products_SubCategories");
                });

            modelBuilder.Entity("NikNok.Models.SubCategories", b =>
                {
                    b.HasOne("NikNok.Models.Categories", "Category")
                        .WithMany("SubCategories")
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("FK_SubCategories_Categories");
                });
#pragma warning restore 612, 618
        }
    }
}
