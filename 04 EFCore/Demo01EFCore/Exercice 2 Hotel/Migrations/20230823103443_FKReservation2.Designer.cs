﻿// <auto-generated />
using Exercice02Hotel.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Exercice_1_EFCore.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230823103443_FKReservation2")]
    partial class FKReservation2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Exercice02Hotel.Models.Chambre", b =>
                {
                    b.Property<int>("ChambreNumero")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ChambreNumero"), 1L, 1);

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<int>("NombreLits")
                        .HasColumnType("int");

                    b.Property<int>("Statut")
                        .HasColumnType("int");

                    b.Property<decimal>("Tarif")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ChambreNumero");

                    b.HasIndex("ClientId");

                    b.ToTable("Chambres");

                    b.HasData(
                        new
                        {
                            ChambreNumero = 1,
                            ClientId = 0,
                            NombreLits = 2,
                            Statut = 0,
                            Tarif = 100.50m
                        },
                        new
                        {
                            ChambreNumero = 2,
                            ClientId = 0,
                            NombreLits = 4,
                            Statut = 2,
                            Tarif = 400.50m
                        });
                });

            modelBuilder.Entity("Exercice02Hotel.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroTelephone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nom = "Dupont",
                            NumeroTelephone = "0607080910",
                            Prenom = "Pierre"
                        },
                        new
                        {
                            Id = 2,
                            Nom = "Abadi",
                            NumeroTelephone = "0607080911",
                            Prenom = "Ihab"
                        });
                });

            modelBuilder.Entity("Exercice02Hotel.Models.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<int>("Statut")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("Exercice02Hotel.Models.ReservationChambre", b =>
                {
                    b.Property<int>("ChambreNumero")
                        .HasColumnType("int");

                    b.Property<int>("ReservationId")
                        .HasColumnType("int");

                    b.HasKey("ChambreNumero", "ReservationId");

                    b.HasIndex("ReservationId");

                    b.ToTable("ReservationChambres");
                });

            modelBuilder.Entity("Exercice02Hotel.Models.Chambre", b =>
                {
                    b.HasOne("Exercice02Hotel.Models.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("Exercice02Hotel.Models.Reservation", b =>
                {
                    b.HasOne("Exercice02Hotel.Models.Client", "Client")
                        .WithMany("Reservations")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("Exercice02Hotel.Models.ReservationChambre", b =>
                {
                    b.HasOne("Exercice02Hotel.Models.Chambre", "Chambre")
                        .WithMany("ReservationChambres")
                        .HasForeignKey("ChambreNumero")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Exercice02Hotel.Models.Reservation", "Reservation")
                        .WithMany("ReservationChambres")
                        .HasForeignKey("ReservationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Chambre");

                    b.Navigation("Reservation");
                });

            modelBuilder.Entity("Exercice02Hotel.Models.Chambre", b =>
                {
                    b.Navigation("ReservationChambres");
                });

            modelBuilder.Entity("Exercice02Hotel.Models.Client", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("Exercice02Hotel.Models.Reservation", b =>
                {
                    b.Navigation("ReservationChambres");
                });
#pragma warning restore 612, 618
        }
    }
}