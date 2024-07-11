﻿// <auto-generated />
using System;
using AnasProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AnasProject.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20240530110601_addeddate")]
    partial class addeddate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AnasProject.Driver", b =>
                {
                    b.Property<long>("DriverId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("DriverId"));

                    b.Property<string>("DriverName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DriverId");

                    b.ToTable("Drivers");
                });

            modelBuilder.Entity("AnasProject.Geofence", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("AddedDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(21)
                        .HasColumnType("nvarchar(21)");

                    b.Property<string>("FillColor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("FillOpacity")
                        .HasColumnType("float");

                    b.Property<string>("GeofenceType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("StrockColor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("StrockOpacity")
                        .HasColumnType("float");

                    b.Property<double>("StrockWeight")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Geofences");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Geofence");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("AnasProject.RouteHistory", b =>
                {
                    b.Property<long>("RouteHistoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("RouteHistoryId"));

                    b.Property<long>("Epoch")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<double>("Latitude")
                        .HasColumnType("float");

                    b.Property<double>("Longitude")
                        .HasColumnType("float");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<int>("VehicleDirection")
                        .HasColumnType("int");

                    b.Property<long>("VehicleId")
                        .HasColumnType("bigint");

                    b.Property<string>("VehicleSpeed")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RouteHistoryId");

                    b.HasIndex("VehicleId");

                    b.ToTable("RouteHistories");
                });

            modelBuilder.Entity("AnasProject.Vehicle", b =>
                {
                    b.Property<long>("VehicleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("VehicleId"));

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<long>("VehicleNumber")
                        .HasColumnType("bigint");

                    b.Property<string>("VehicleType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VehicleId");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("AnasProject.VehiclesInformation", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long?>("DriverId")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<long>("PurchaseDate")
                        .HasColumnType("bigint");

                    b.Property<long?>("VehicleId")
                        .HasColumnType("bigint");

                    b.Property<string>("VehicleMake")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VehicleModel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DriverId");

                    b.HasIndex("VehicleId");

                    b.ToTable("VehiclesInformations");
                });

            modelBuilder.Entity("AnasProject.CircleGeofence", b =>
                {
                    b.HasBaseType("AnasProject.Geofence");

                    b.Property<long?>("GeofenceId")
                        .HasColumnType("bigint");

                    b.Property<double>("Latitude")
                        .HasColumnType("float");

                    b.Property<double>("Longitude")
                        .HasColumnType("float");

                    b.Property<long>("Radius")
                        .HasColumnType("bigint");

                    b.HasIndex("GeofenceId");

                    b.HasDiscriminator().HasValue("CircleGeofence");
                });

            modelBuilder.Entity("AnasProject.PolygonGeofence", b =>
                {
                    b.HasBaseType("AnasProject.Geofence");

                    b.Property<long?>("GeofenceId")
                        .HasColumnType("bigint");

                    b.Property<double>("Latitude")
                        .HasColumnType("float");

                    b.Property<double>("Longitude")
                        .HasColumnType("float");

                    b.HasIndex("GeofenceId");

                    b.ToTable("Geofences", t =>
                        {
                            t.Property("GeofenceId")
                                .HasColumnName("PolygonGeofence_GeofenceId");

                            t.Property("Latitude")
                                .HasColumnName("PolygonGeofence_Latitude");

                            t.Property("Longitude")
                                .HasColumnName("PolygonGeofence_Longitude");
                        });

                    b.HasDiscriminator().HasValue("PolygonGeofence");
                });

            modelBuilder.Entity("AnasProject.RectangleGeofence", b =>
                {
                    b.HasBaseType("AnasProject.Geofence");

                    b.Property<double>("East")
                        .HasColumnType("float");

                    b.Property<long?>("GeofenceId")
                        .HasColumnType("bigint");

                    b.Property<double>("North")
                        .HasColumnType("float");

                    b.Property<double>("South")
                        .HasColumnType("float");

                    b.Property<double>("West")
                        .HasColumnType("float");

                    b.HasIndex("GeofenceId");

                    b.ToTable("Geofences", t =>
                        {
                            t.Property("GeofenceId")
                                .HasColumnName("RectangleGeofence_GeofenceId");
                        });

                    b.HasDiscriminator().HasValue("RectangleGeofence");
                });

            modelBuilder.Entity("AnasProject.RouteHistory", b =>
                {
                    b.HasOne("AnasProject.Vehicle", "Vehicle")
                        .WithMany("RouteHistories")
                        .HasForeignKey("VehicleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Vehicle");
                });

            modelBuilder.Entity("AnasProject.VehiclesInformation", b =>
                {
                    b.HasOne("AnasProject.Driver", "Driver")
                        .WithMany("VehiclesInformations")
                        .HasForeignKey("DriverId");

                    b.HasOne("AnasProject.Vehicle", "Vehicle")
                        .WithMany("VehiclesInformations")
                        .HasForeignKey("VehicleId");

                    b.Navigation("Driver");

                    b.Navigation("Vehicle");
                });

            modelBuilder.Entity("AnasProject.CircleGeofence", b =>
                {
                    b.HasOne("AnasProject.Geofence", null)
                        .WithMany("CircleGeofences")
                        .HasForeignKey("GeofenceId");
                });

            modelBuilder.Entity("AnasProject.PolygonGeofence", b =>
                {
                    b.HasOne("AnasProject.Geofence", null)
                        .WithMany("PolygonGeofences")
                        .HasForeignKey("GeofenceId");
                });

            modelBuilder.Entity("AnasProject.RectangleGeofence", b =>
                {
                    b.HasOne("AnasProject.Geofence", null)
                        .WithMany("RectangleGeofences")
                        .HasForeignKey("GeofenceId");
                });

            modelBuilder.Entity("AnasProject.Driver", b =>
                {
                    b.Navigation("VehiclesInformations");
                });

            modelBuilder.Entity("AnasProject.Geofence", b =>
                {
                    b.Navigation("CircleGeofences");

                    b.Navigation("PolygonGeofences");

                    b.Navigation("RectangleGeofences");
                });

            modelBuilder.Entity("AnasProject.Vehicle", b =>
                {
                    b.Navigation("RouteHistories");

                    b.Navigation("VehiclesInformations");
                });
#pragma warning restore 612, 618
        }
    }
}
