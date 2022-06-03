﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SeyrekTur.Data.Concrete;

namespace SeyrekTur.Data.Migrations
{
    [DbContext(typeof(TurContext))]
    partial class TurContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.16");

            modelBuilder.Entity("SeyrekTur.Entity.Admin", b =>
                {
                    b.Property<int>("AdminID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AdminPassword")
                        .HasColumnType("TEXT");

                    b.Property<string>("AdminUserName")
                        .HasColumnType("TEXT");

                    b.HasKey("AdminID");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("SeyrekTur.Entity.City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CityName")
                        .HasColumnType("TEXT");

                    b.HasKey("CityId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("SeyrekTur.Entity.Route", b =>
                {
                    b.Property<int>("RouteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Finish")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("TEXT");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<string>("Route1")
                        .HasColumnType("TEXT");

                    b.Property<string>("Route2")
                        .HasColumnType("TEXT");

                    b.Property<string>("Route3")
                        .HasColumnType("TEXT");

                    b.Property<string>("Start")
                        .HasColumnType("TEXT");

                    b.Property<string>("Time")
                        .HasColumnType("TEXT");

                    b.Property<string>("date")
                        .HasColumnType("TEXT");

                    b.HasKey("RouteId");

                    b.ToTable("Routes");
                });

            modelBuilder.Entity("SeyrekTur.Entity.Ticket", b =>
                {
                    b.Property<int>("TicketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("From")
                        .HasColumnType("TEXT");

                    b.Property<string>("Mail")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<int>("RouteId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SeatNo")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Surname")
                        .HasColumnType("TEXT");

                    b.Property<string>("To")
                        .HasColumnType("TEXT");

                    b.HasKey("TicketId");

                    b.HasIndex("RouteId");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("SeyrekTur.Entity.Ticket", b =>
                {
                    b.HasOne("SeyrekTur.Entity.Route", "Route")
                        .WithMany("Tickets")
                        .HasForeignKey("RouteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Route");
                });

            modelBuilder.Entity("SeyrekTur.Entity.Route", b =>
                {
                    b.Navigation("Tickets");
                });
#pragma warning restore 612, 618
        }
    }
}
