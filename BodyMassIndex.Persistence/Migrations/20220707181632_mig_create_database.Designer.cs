﻿// <auto-generated />
using System;
using BodyMassIndex.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BodyMassIndex.Persistence.Migrations
{
    [DbContext(typeof(BodyMassIndexDb))]
    [Migration("20220707181632_mig_create_database")]
    partial class mig_create_database
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BodyMassIndex.Domain.Entities.Dimensions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Heigth")
                        .HasColumnType("int");

                    b.Property<int>("Weigth")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Dimensions");
                });
#pragma warning restore 612, 618
        }
    }
}
