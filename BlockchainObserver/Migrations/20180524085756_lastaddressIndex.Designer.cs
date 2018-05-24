﻿// <auto-generated />
using BlockchainObserver.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace BlockchainObserver.Migrations
{
    [DbContext(typeof(DBEntities))]
    [Migration("20180524085756_lastaddressIndex")]
    partial class lastaddressIndex
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011");

            modelBuilder.Entity("BlockchainObserver.Database.Entities.AddressCache", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Currency")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.HasKey("Id");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("BlockchainObserver.Database.Entities.BlockCache", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Currency")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<string>("LastSeenBlock")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("BlockCaches");
                });

            modelBuilder.Entity("BlockchainObserver.Database.Entities.LastAddressIndex", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Currency")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<int>("Index");

                    b.HasKey("Id");

                    b.ToTable("LastAddressIndex");
                });

            modelBuilder.Entity("BlockchainObserver.Database.Entities.TransactionCache", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Currency")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<string>("TransactionId")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("Currency");

                    b.ToTable("Transactions");
                });
#pragma warning restore 612, 618
        }
    }
}