﻿// <auto-generated />
using System;
using Assignment3WebAPI.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Assignment3WebAPI.Migrations
{
    [DbContext(typeof(FamilyDbContext))]
    partial class FamilyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0-rc.2.20475.6");

            modelBuilder.Entity("Assignment3WebAPI.Data.Adult", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<string>("EyeColor")
                        .HasColumnType("TEXT");

                    b.Property<int?>("FamilyHouseNumber")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FamilyStreetName")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("HairColor")
                        .HasColumnType("TEXT");

                    b.Property<int>("Height")
                        .HasColumnType("INTEGER");

                    b.Property<string>("JobTitle")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Sex")
                        .HasColumnType("TEXT");

                    b.Property<float>("Weight")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("FamilyStreetName", "FamilyHouseNumber");

                    b.ToTable("Adults");
                });

            modelBuilder.Entity("Assignment3WebAPI.Data.Child", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<string>("EyeColor")
                        .HasColumnType("TEXT");

                    b.Property<int?>("FamilyHouseNumber")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FamilyStreetName")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("HairColor")
                        .HasColumnType("TEXT");

                    b.Property<int>("Height")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Sex")
                        .HasColumnType("TEXT");

                    b.Property<float>("Weight")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("FamilyStreetName", "FamilyHouseNumber");

                    b.ToTable("Childs");
                });

            modelBuilder.Entity("Assignment3WebAPI.Data.ChildInterest", b =>
                {
                    b.Property<string>("InterestId")
                        .HasColumnType("TEXT");

                    b.Property<int>("ChildId")
                        .HasColumnType("INTEGER");

                    b.HasKey("InterestId", "ChildId");

                    b.HasIndex("ChildId");

                    b.ToTable("ChildInterests");
                });

            modelBuilder.Entity("Assignment3WebAPI.Data.Family", b =>
                {
                    b.Property<string>("StreetName")
                        .HasColumnType("TEXT");

                    b.Property<int>("HouseNumber")
                        .HasColumnType("INTEGER");

                    b.HasKey("StreetName", "HouseNumber");

                    b.ToTable("Families");
                });

            modelBuilder.Entity("Assignment3WebAPI.Data.Interest", b =>
                {
                    b.Property<string>("Type")
                        .HasColumnType("TEXT");

                    b.HasKey("Type");

                    b.ToTable("Interests");
                });

            modelBuilder.Entity("Assignment3WebAPI.Data.Pet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ChildId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("FamilyHouseNumber")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FamilyStreetName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Species")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ChildId");

                    b.HasIndex("FamilyStreetName", "FamilyHouseNumber");

                    b.ToTable("Pet");
                });

            modelBuilder.Entity("Assignment3WebAPI.Data.Adult", b =>
                {
                    b.HasOne("Assignment3WebAPI.Data.Family", null)
                        .WithMany("Adults")
                        .HasForeignKey("FamilyStreetName", "FamilyHouseNumber");
                });

            modelBuilder.Entity("Assignment3WebAPI.Data.Child", b =>
                {
                    b.HasOne("Assignment3WebAPI.Data.Family", null)
                        .WithMany("Children")
                        .HasForeignKey("FamilyStreetName", "FamilyHouseNumber");
                });

            modelBuilder.Entity("Assignment3WebAPI.Data.ChildInterest", b =>
                {
                    b.HasOne("Assignment3WebAPI.Data.Child", "Child")
                        .WithMany("ChildInterests")
                        .HasForeignKey("ChildId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Assignment3WebAPI.Data.Interest", "Interest")
                        .WithMany("ChildInterests")
                        .HasForeignKey("InterestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Child");

                    b.Navigation("Interest");
                });

            modelBuilder.Entity("Assignment3WebAPI.Data.Pet", b =>
                {
                    b.HasOne("Assignment3WebAPI.Data.Child", null)
                        .WithMany("Pets")
                        .HasForeignKey("ChildId");

                    b.HasOne("Assignment3WebAPI.Data.Family", null)
                        .WithMany("Pets")
                        .HasForeignKey("FamilyStreetName", "FamilyHouseNumber");
                });

            modelBuilder.Entity("Assignment3WebAPI.Data.Child", b =>
                {
                    b.Navigation("ChildInterests");

                    b.Navigation("Pets");
                });

            modelBuilder.Entity("Assignment3WebAPI.Data.Family", b =>
                {
                    b.Navigation("Adults");

                    b.Navigation("Children");

                    b.Navigation("Pets");
                });

            modelBuilder.Entity("Assignment3WebAPI.Data.Interest", b =>
                {
                    b.Navigation("ChildInterests");
                });
#pragma warning restore 612, 618
        }
    }
}
