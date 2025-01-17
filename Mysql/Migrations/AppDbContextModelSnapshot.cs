﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mysql.Context;

#nullable disable

namespace Mysql.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Mysql.Models.Qa", b =>
                {
                    b.Property<int>("QaId")
                        .HasColumnType("int(11)")
                        .HasColumnOrder(1);

                    b.Property<int>("Active")
                        .HasColumnType("int")
                        .HasColumnOrder(9);

                    b.Property<string>("Answ")
                        .HasColumnType("nvarchar(1000)")
                        .HasColumnOrder(3);

                    b.Property<string>("Hyper")
                        .HasColumnType("nvarchar(1000)")
                        .HasColumnOrder(4);

                    b.Property<int?>("Number")
                        .HasColumnType("int")
                        .HasColumnOrder(5);

                    b.Property<string>("Org")
                        .HasColumnType("nvarchar(300)")
                        .HasColumnOrder(10);

                    b.Property<string>("Quest")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)")
                        .HasColumnOrder(2);

                    b.Property<int?>("Status")
                        .HasColumnType("int")
                        .HasColumnOrder(7);

                    b.Property<string>("StatusMessage")
                        .HasColumnType("text")
                        .HasColumnOrder(8);

                    b.Property<string>("Tel")
                        .HasColumnType("nvarchar(100)")
                        .HasColumnOrder(11);

                    b.Property<string>("UserMessage")
                        .HasColumnType("text")
                        .HasColumnOrder(6);

                    b.HasKey("QaId");

                    b.ToTable("Qas");
                });
#pragma warning restore 612, 618
        }
    }
}
