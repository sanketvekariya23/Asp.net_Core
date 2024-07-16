﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sanket_web.Data;

#nullable disable

namespace Sanket_web.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240713063917_AddToSeed")]
    partial class AddToSeed
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Sanket_web.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AddToCart")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AddToCart = 3,
                            Name = "ramayana"
                        },
                        new
                        {
                            Id = 2,
                            AddToCart = 3,
                            Name = "Mahabharata"
                        },
                        new
                        {
                            Id = 3,
                            AddToCart = 3,
                            Name = "BhagavatGita"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
