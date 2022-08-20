﻿// <auto-generated />
using System;
using ApiDB.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ApiDB.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20220819150545_InitMigration")]
    partial class InitMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ApiDB.Booking", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.Property<string>("Date")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("TimeFrom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TimeTo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "SubjectId");

                    b.HasIndex("SubjectId");

                    b.ToTable("Booking");
                });

            modelBuilder.Entity("ApiDB.School21", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CampusName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("School21");
                });

            modelBuilder.Entity("ApiDB.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Block")
                        .HasColumnType("bit");

                    b.Property<int>("Campus")
                        .HasColumnType("int");

                    b.Property<string>("Info")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("Level")
                        .HasColumnType("int");

                    b.Property<string>("MinTime")
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("NameSubject")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("NumberRoom")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<int>("securType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Campus");

                    b.ToTable("Subject");
                });

            modelBuilder.Entity("ApiDB.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Block")
                        .HasColumnType("bit");

                    b.Property<int>("Campus")
                        .HasColumnType("int");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<string>("UserLogin")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UserName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("telegramId")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("Campus");

                    b.ToTable("User");
                });

            modelBuilder.Entity("ApiDB.Booking", b =>
                {
                    b.HasOne("ApiDB.Subject", "Subject")
                        .WithMany("bookings")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("ApiDB.User", "User")
                        .WithMany("bookings")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Subject");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ApiDB.Subject", b =>
                {
                    b.HasOne("ApiDB.School21", "School21")
                        .WithMany("Subjects")
                        .HasForeignKey("Campus")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("School21");
                });

            modelBuilder.Entity("ApiDB.User", b =>
                {
                    b.HasOne("ApiDB.School21", "School21")
                        .WithMany("Users")
                        .HasForeignKey("Campus")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("School21");
                });

            modelBuilder.Entity("ApiDB.School21", b =>
                {
                    b.Navigation("Subjects");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("ApiDB.Subject", b =>
                {
                    b.Navigation("bookings");
                });

            modelBuilder.Entity("ApiDB.User", b =>
                {
                    b.Navigation("bookings");
                });
#pragma warning restore 612, 618
        }
    }
}