﻿// <auto-generated />
using System;
using ArbitrageFinder.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ArbitrageFinder.Infrastructure.Migrations
{
    [DbContext(typeof(ArbitrageFinderDBContext))]
    [Migration("20221211210939_InitialSetup")]
    partial class InitialSetup
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ArbitrageFinder.Domain.AggregateModels.Bet.Bet", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("GameId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("ModificationDate")
                        .IsConcurrencyToken()
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<Guid>("UUId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("UUId")
                        .IsUnique();

                    b.ToTable("Bet", (string)null);
                });

            modelBuilder.Entity("ArbitrageFinder.Domain.AggregateModels.Bet.Combination", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long?>("BetId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("ModificationDate")
                        .IsConcurrencyToken()
                        .HasColumnType("datetime(6)");

                    b.Property<decimal>("ProfitMargin")
                        .HasColumnType("decimal(18,5)");

                    b.Property<Guid>("UUId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("BetId");

                    b.HasIndex("UUId")
                        .IsUnique();

                    b.ToTable("Combination", (string)null);
                });

            modelBuilder.Entity("ArbitrageFinder.Domain.AggregateModels.Bookmaker.Bookmaker", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("BaseUrl")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Comments")
                        .HasMaxLength(320)
                        .HasColumnType("varchar(320)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<DateTime>("ModificationDate")
                        .IsConcurrencyToken()
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<Guid>("UUId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("UUId")
                        .IsUnique();

                    b.ToTable("Bookmaker", (string)null);
                });

            modelBuilder.Entity("ArbitrageFinder.Domain.AggregateModels.Bookmaker.Team", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long?>("BookmakerId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("ModificationDate")
                        .IsConcurrencyToken()
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<Guid>("UUId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("BookmakerId");

                    b.HasIndex("UUId")
                        .IsUnique();

                    b.ToTable("Team", (string)null);
                });

            modelBuilder.Entity("ArbitrageFinder.Domain.AggregateModels.Game.Game", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("ModificationDate")
                        .IsConcurrencyToken()
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("TeamAId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("TeamBId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("UUId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("UUId")
                        .IsUnique();

                    b.ToTable("Game", (string)null);
                });

            modelBuilder.Entity("ArbitrageFinder.Domain.AggregateModels.Game.Odd", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<Guid>("BookmakerId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<long?>("GameId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("ModificationDate")
                        .IsConcurrencyToken()
                        .HasColumnType("datetime(6)");

                    b.Property<decimal>("RealOdd")
                        .HasColumnType("decimal(18,5)");

                    b.Property<Guid?>("TeamId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<Guid>("UUId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.HasIndex("UUId")
                        .IsUnique();

                    b.ToTable("Odd", (string)null);
                });

            modelBuilder.Entity("ArbitrageFinder.Domain.AggregateModels.Bet.Combination", b =>
                {
                    b.HasOne("ArbitrageFinder.Domain.AggregateModels.Bet.Bet", null)
                        .WithMany("Combinations")
                        .HasForeignKey("BetId");

                    b.OwnsOne("ArbitrageFinder.Domain.AggregateModels.Bet.Odd", "V1Odd", b1 =>
                        {
                            b1.Property<long>("CombinationId")
                                .HasColumnType("bigint");

                            b1.Property<Guid>("BookmakerId")
                                .HasColumnType("char(36)");

                            b1.Property<Guid>("OddId")
                                .HasColumnType("char(36)");

                            b1.HasKey("CombinationId");

                            b1.ToTable("Combination");

                            b1.WithOwner()
                                .HasForeignKey("CombinationId");
                        });

                    b.OwnsOne("ArbitrageFinder.Domain.AggregateModels.Bet.Odd", "V2Odd", b1 =>
                        {
                            b1.Property<long>("CombinationId")
                                .HasColumnType("bigint");

                            b1.Property<Guid>("BookmakerId")
                                .HasColumnType("char(36)");

                            b1.Property<Guid>("OddId")
                                .HasColumnType("char(36)");

                            b1.HasKey("CombinationId");

                            b1.ToTable("Combination");

                            b1.WithOwner()
                                .HasForeignKey("CombinationId");
                        });

                    b.OwnsOne("ArbitrageFinder.Domain.AggregateModels.Bet.Odd", "XOdd", b1 =>
                        {
                            b1.Property<long>("CombinationId")
                                .HasColumnType("bigint");

                            b1.Property<Guid>("BookmakerId")
                                .HasColumnType("char(36)");

                            b1.Property<Guid>("OddId")
                                .HasColumnType("char(36)");

                            b1.HasKey("CombinationId");

                            b1.ToTable("Combination");

                            b1.WithOwner()
                                .HasForeignKey("CombinationId");
                        });

                    b.Navigation("V1Odd");

                    b.Navigation("V2Odd");

                    b.Navigation("XOdd");
                });

            modelBuilder.Entity("ArbitrageFinder.Domain.AggregateModels.Bookmaker.Team", b =>
                {
                    b.HasOne("ArbitrageFinder.Domain.AggregateModels.Bookmaker.Bookmaker", null)
                        .WithMany("Teams")
                        .HasForeignKey("BookmakerId");
                });

            modelBuilder.Entity("ArbitrageFinder.Domain.AggregateModels.Game.Odd", b =>
                {
                    b.HasOne("ArbitrageFinder.Domain.AggregateModels.Game.Game", null)
                        .WithMany("Odds")
                        .HasForeignKey("GameId");
                });

            modelBuilder.Entity("ArbitrageFinder.Domain.AggregateModels.Bet.Bet", b =>
                {
                    b.Navigation("Combinations");
                });

            modelBuilder.Entity("ArbitrageFinder.Domain.AggregateModels.Bookmaker.Bookmaker", b =>
                {
                    b.Navigation("Teams");
                });

            modelBuilder.Entity("ArbitrageFinder.Domain.AggregateModels.Game.Game", b =>
                {
                    b.Navigation("Odds");
                });
#pragma warning restore 612, 618
        }
    }
}
