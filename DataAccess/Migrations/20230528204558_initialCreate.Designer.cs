﻿// <auto-generated />
using System;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(RentACarContext))]
    [Migration("20230528204558_initialCreate")]
    partial class initialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Entities.Category", b =>
                {
                    b.Property<int>("Categoryİd")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Categoryİd"));

                    b.Property<DateTime>("CreatedBy")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SubCategory")
                        .HasColumnType("int");

                    b.HasKey("Categoryİd");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Entities.Feature", b =>
                {
                    b.Property<int>("Featureİd")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Featureİd"));

                    b.Property<int>("Cateegoryİd")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedBy")
                        .HasColumnType("datetime2");

                    b.Property<string>("EnteredValue")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Valu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Featureİd");

                    b.ToTable("Features");
                });
#pragma warning restore 612, 618
        }
    }
}
