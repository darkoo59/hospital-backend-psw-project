﻿// <auto-generated />
using System;
using HospitalLibrary.Settings;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace HospitalLibrary.Migrations
{
    [DbContext(typeof(HospitalDbContext))]
    [Migration("20221021184858_VacationMigration")]
    partial class VacationMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("HospitalLibrary.Core.Model.Appointment", b =>
                {
                    b.Property<int>("AppointmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("DoctorId")
                        .HasColumnType("integer");

                    b.Property<int?>("PatientId")
                        .HasColumnType("integer");

                    b.HasKey("AppointmentId");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PatientId");

                    b.ToTable("Appointments");

                    b.HasData(
                        new
                        {
                            AppointmentId = 1,
                            DateTime = new DateTime(2022, 10, 21, 20, 48, 57, 188, DateTimeKind.Local).AddTicks(3344),
                            DoctorId = 1,
                            PatientId = 1
                        });
                });

            modelBuilder.Entity("HospitalLibrary.Core.Model.Doctor", b =>
                {
                    b.Property<int>("DoctorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("RoomId")
                        .HasColumnType("integer");

                    b.Property<int>("SpecializationId")
                        .HasColumnType("integer");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("DoctorId");

                    b.HasIndex("RoomId");

                    b.HasIndex("SpecializationId");

                    b.ToTable("Doctors");

                    b.HasData(
                        new
                        {
                            DoctorId = 1,
                            Name = "Ognjen",
                            RoomId = 1,
                            SpecializationId = 3,
                            Surname = "Nikolic"
                        });
                });

            modelBuilder.Entity("HospitalLibrary.Core.Model.Patient", b =>
                {
                    b.Property<int>("PatientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("PatientId");

                    b.ToTable("Patients");

                    b.HasData(
                        new
                        {
                            PatientId = 1,
                            Name = "Pera",
                            Surname = "Peric"
                        },
                        new
                        {
                            PatientId = 2,
                            Name = "Marko",
                            Surname = "Markovic"
                        },
                        new
                        {
                            PatientId = 3,
                            Name = "Aleksa",
                            Surname = "Aleksic"
                        });
                });

            modelBuilder.Entity("HospitalLibrary.Core.Model.Room", b =>
                {
                    b.Property<int>("RoomId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("Floor")
                        .HasColumnType("integer");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("RoomId");

                    b.ToTable("Rooms");

                    b.HasData(
                        new
                        {
                            RoomId = 1,
                            Floor = 1,
                            Number = "101A"
                        },
                        new
                        {
                            RoomId = 2,
                            Floor = 2,
                            Number = "204"
                        },
                        new
                        {
                            RoomId = 3,
                            Floor = 3,
                            Number = "305B"
                        });
                });

            modelBuilder.Entity("HospitalLibrary.Core.Model.Specialization", b =>
                {
                    b.Property<int>("SpecializationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("SpecializationId");

                    b.ToTable("Specializations");

                    b.HasData(
                        new
                        {
                            SpecializationId = 1,
                            Name = "Anesthesiology"
                        },
                        new
                        {
                            SpecializationId = 2,
                            Name = "Dermatology"
                        },
                        new
                        {
                            SpecializationId = 3,
                            Name = "Family medicine"
                        });
                });

            modelBuilder.Entity("HospitalLibrary.Core.Model.Vacation", b =>
                {
                    b.Property<int>("VacationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("DoctorId")
                        .IsRequired()
                        .HasColumnType("integer");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("VacationId");

                    b.HasIndex("DoctorId");

                    b.ToTable("Vacations");

                    b.HasData(
                        new
                        {
                            VacationId = 1,
                            DoctorId = 1,
                            EndDate = new DateTime(2022, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StartDate = new DateTime(2022, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("HospitalLibrary.Core.Model.WorkTime", b =>
                {
                    b.Property<int>("WorkTimeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("DoctorId")
                        .IsRequired()
                        .HasColumnType("integer");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<TimeSpan>("EndTime")
                        .HasColumnType("interval");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<TimeSpan>("StartTime")
                        .HasColumnType("interval");

                    b.HasKey("WorkTimeId");

                    b.HasIndex("DoctorId");

                    b.ToTable("WorkTimes");

                    b.HasData(
                        new
                        {
                            WorkTimeId = 1,
                            DoctorId = 1,
                            EndDate = new DateTime(2022, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EndTime = new TimeSpan(0, 16, 0, 0, 0),
                            StartDate = new DateTime(2022, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StartTime = new TimeSpan(0, 8, 0, 0, 0)
                        });
                });

            modelBuilder.Entity("HospitalLibrary.Core.Model.Appointment", b =>
                {
                    b.HasOne("HospitalLibrary.Core.Model.Doctor", "Doctor")
                        .WithMany()
                        .HasForeignKey("DoctorId");

                    b.HasOne("HospitalLibrary.Core.Model.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientId");

                    b.Navigation("Doctor");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("HospitalLibrary.Core.Model.Doctor", b =>
                {
                    b.HasOne("HospitalLibrary.Core.Model.Room", "Room")
                        .WithMany()
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HospitalLibrary.Core.Model.Specialization", "Specialization")
                        .WithMany()
                        .HasForeignKey("SpecializationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Room");

                    b.Navigation("Specialization");
                });

            modelBuilder.Entity("HospitalLibrary.Core.Model.Vacation", b =>
                {
                    b.HasOne("HospitalLibrary.Core.Model.Doctor", "Doctor")
                        .WithMany()
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");
                });

            modelBuilder.Entity("HospitalLibrary.Core.Model.WorkTime", b =>
                {
                    b.HasOne("HospitalLibrary.Core.Model.Doctor", "Doctor")
                        .WithMany()
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");
                });
#pragma warning restore 612, 618
        }
    }
}
