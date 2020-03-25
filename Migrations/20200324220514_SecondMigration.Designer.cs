﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PicnicPlanner3.Contexts;

namespace PicnicPlanner3.Migrations
{
    [DbContext(typeof(HomeContext))]
    [Migration("20200324220514_SecondMigration")]
    partial class SecondMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("PicnicPlanner3.Models.Airport", b =>
                {
                    b.Property<int>("AirportId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Ident");

                    b.Property<double>("Latitude_deg");

                    b.Property<double>("Longitude_deg");

                    b.Property<string>("Municipality");

                    b.Property<string>("Name");

                    b.Property<string>("Region");

                    b.Property<string>("Type");

                    b.HasKey("AirportId");

                    b.ToTable("Airports");
                });

            modelBuilder.Entity("PicnicPlanner3.Models.Runway", b =>
                {
                    b.Property<int>("RunwayId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AirportId");

                    b.Property<int>("He_Heading_deg");

                    b.Property<int>("Le_Heading_deg");

                    b.HasKey("RunwayId");

                    b.HasIndex("AirportId");

                    b.ToTable("Runways");
                });

            modelBuilder.Entity("PicnicPlanner3.Models.Runway", b =>
                {
                    b.HasOne("PicnicPlanner3.Models.Airport", "RunwayLocation")
                        .WithMany("Runways")
                        .HasForeignKey("AirportId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
