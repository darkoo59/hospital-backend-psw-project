﻿// <auto-generated />
using System;
using IntegrationLibrary.Settings;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace IntegrationLibrary.Migrations
{
    [DbContext(typeof(IntegrationDbContext))]
    [Migration("20221112203811_blood-req-state")]
    partial class bloodreqstate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("IntegrationLibrary.Core.Model.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("AppName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<string>("Server")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AppName = "app1",
                            Email = "email1@gmail.com",
                            Password = "OLIfDWaYYunpFtiQ",
                            Server = "localhost:5555"
                        },
                        new
                        {
                            Id = 2,
                            AppName = "app2",
                            Email = "email2@gmail.com",
                            Password = "UzX1V1A0FfLerVn5",
                            Server = "localhost:6555"
                        },
                        new
                        {
                            Id = 3,
                            AppName = "app3",
                            Email = "email3@gmail.com",
                            Password = "dd13xfCA5Jz9Y9ho",
                            Server = "localhost:7555"
                        });
                });

            modelBuilder.Entity("IntegrationLibrary.Features.BloodBankNews.Model.BankNews", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Content")
                        .HasColumnType("text");

                    b.Property<int>("State")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("BankNews");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "sadrzaj vijesti 1",
                            State = 0,
                            Title = "vijest 1"
                        },
                        new
                        {
                            Id = 2,
                            Content = "sadrzaj vijesti 2",
                            State = 2,
                            Title = "vijest 2"
                        },
                        new
                        {
                            Id = 3,
                            Content = "sadrzaj vijesti 3",
                            State = 1,
                            Title = "vijest 3"
                        },
                        new
                        {
                            Id = 4,
                            Content = "sadrzaj vijesti 4",
                            State = 0,
                            Title = "vijest 4"
                        },
                        new
                        {
                            Id = 5,
                            Content = "sadrzaj vijesti 5",
                            State = 2,
                            Title = "vijest 5"
                        },
                        new
                        {
                            Id = 6,
                            Content = "sadrzaj vijesti 6",
                            State = 0,
                            Title = "vijest 6"
                        },
                        new
                        {
                            Id = 7,
                            Content = "sadrzaj vijesti 7",
                            State = 0,
                            Title = "vijest 7"
                        },
                        new
                        {
                            Id = 8,
                            Content = "sadrzaj vijesti 8",
                            State = 0,
                            Title = "vijest 8"
                        },
                        new
                        {
                            Id = 9,
                            Content = "sadrzaj vijesti 9",
                            State = 1,
                            Title = "vijest 9"
                        });
                });

            modelBuilder.Entity("IntegrationLibrary.Features.BloodRequests.Model.BloodRequest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("BloodType")
                        .HasColumnType("integer");

                    b.Property<int>("DoctorId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("FinalDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<double>("QuantityInLiters")
                        .HasColumnType("double precision");

                    b.Property<string>("ReasonForRequest")
                        .HasColumnType("text");

                    b.Property<int>("State")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("BloodRequests");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BloodType = 0,
                            DoctorId = 1,
                            FinalDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            QuantityInLiters = 1.0,
                            ReasonForRequest = "treba 1",
                            State = 0
                        },
                        new
                        {
                            Id = 2,
                            BloodType = 2,
                            DoctorId = 1,
                            FinalDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            QuantityInLiters = 4.0,
                            ReasonForRequest = "treba 2",
                            State = 0
                        },
                        new
                        {
                            Id = 3,
                            BloodType = 5,
                            DoctorId = 2,
                            FinalDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            QuantityInLiters = 9.0,
                            ReasonForRequest = "treba 3",
                            State = 0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
