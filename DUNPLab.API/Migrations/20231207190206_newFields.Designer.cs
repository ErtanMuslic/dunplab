﻿// <auto-generated />
using System;
using DUNPLab.API.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DUNPLab.API.Migrations
{
    [DbContext(typeof(DunpContext))]
    [Migration("20231207190206_newFields")]
    partial class newFields
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DUNPLab.API.Models.Email", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("From")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdFile")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Sent")
                        .HasColumnType("datetime2");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("To")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdFile");

                    b.ToTable("Emails");
                });

            modelBuilder.Entity("DUNPLab.API.Models.EmailNotification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("From")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TimeOfSending")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("EmailNotifications");
                });

            modelBuilder.Entity("DUNPLab.API.Models.File", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("JeLiObrisan")
                        .HasColumnType("bit");

                    b.Property<byte[]>("Sadrzaj")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.ToTable("File");
                });

            modelBuilder.Entity("DUNPLab.API.Models.Pacijent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adresa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BrojDokumenta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DatumIstekaDokumenta")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DatumRodjenja")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Grad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JMBG")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pol")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Pacijenti");
                });

            modelBuilder.Entity("DUNPLab.API.Models.Rezultat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdSupstance")
                        .HasColumnType("int");

                    b.Property<int>("IdUzorka")
                        .HasColumnType("int");

                    b.Property<bool?>("JeLiUGranicama")
                        .HasColumnType("bit");

                    b.Property<double?>("Vrednost")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("IdSupstance");

                    b.HasIndex("IdUzorka");

                    b.ToTable("Rezultati");
                });

            modelBuilder.Entity("DUNPLab.API.Models.Supstanca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("Cena")
                        .HasColumnType("float");

                    b.Property<double?>("DonjaGranica")
                        .HasColumnType("float");

                    b.Property<double?>("GornjaGranica")
                        .HasColumnType("float");

                    b.Property<string>("MetodTestiranja")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Oznaka")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tip")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Supstance");
                });

            modelBuilder.Entity("DUNPLab.API.Models.Testiranje", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BrojSobe")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DatumVremeRezultata")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DatumVremeTestiranja")
                        .HasColumnType("datetime2");

                    b.Property<string>("Izmenio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("IzmenioDatumVreme")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("JesuLiPotvrdjeniSviUzorci")
                        .HasColumnType("bit");

                    b.Property<string>("NacinPlacanja")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TestOdradio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("UkupnaCena")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Testiranja");
                });

            modelBuilder.Entity("DUNPLab.API.Models.Uzorak", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double?>("Cena")
                        .HasColumnType("float");

                    b.Property<int>("IdTestiranja")
                        .HasColumnType("int");

                    b.Property<string>("Izmenio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("IzmenioDatumVreme")
                        .HasColumnType("datetime2");

                    b.Property<string>("KodEpruvete")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Komentar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KonacanRezultat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kutija")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MetodTestiranja")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdTestiranja");

                    b.ToTable("Uzorci");
                });

            modelBuilder.Entity("DUNPLab.API.Models.Email", b =>
                {
                    b.HasOne("DUNPLab.API.Models.File", "File")
                        .WithMany()
                        .HasForeignKey("IdFile")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("File");
                });

            modelBuilder.Entity("DUNPLab.API.Models.Rezultat", b =>
                {
                    b.HasOne("DUNPLab.API.Models.Supstanca", "Supstanca")
                        .WithMany()
                        .HasForeignKey("IdSupstance")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DUNPLab.API.Models.Uzorak", "Uzorak")
                        .WithMany("Rezultati")
                        .HasForeignKey("IdUzorka")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Supstanca");

                    b.Navigation("Uzorak");
                });

            modelBuilder.Entity("DUNPLab.API.Models.Uzorak", b =>
                {
                    b.HasOne("DUNPLab.API.Models.Testiranje", "Testiranje")
                        .WithMany("Uzorci")
                        .HasForeignKey("IdTestiranja")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Testiranje");
                });

            modelBuilder.Entity("DUNPLab.API.Models.Testiranje", b =>
                {
                    b.Navigation("Uzorci");
                });

            modelBuilder.Entity("DUNPLab.API.Models.Uzorak", b =>
                {
                    b.Navigation("Rezultati");
                });
#pragma warning restore 612, 618
        }
    }
}