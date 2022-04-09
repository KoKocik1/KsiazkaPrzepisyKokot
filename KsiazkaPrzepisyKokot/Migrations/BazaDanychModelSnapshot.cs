﻿// <auto-generated />
using System;
using KsiazkaPrzepisyKokot.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KsiazkaPrzepisyKokot.Migrations
{
    [DbContext(typeof(BazaDanych))]
    partial class BazaDanychModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.15");

            modelBuilder.Entity("KsiazkaPrzepisyKokot.Models.Log", b =>
                {
                    b.Property<int>("idLog")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("haslo")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<string>("imie")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<string>("login")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<string>("nazwisko")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.HasKey("idLog");

                    b.ToTable("Log");
                });

            modelBuilder.Entity("KsiazkaPrzepisyKokot.Models.Przepisy", b =>
                {
                    b.Property<int>("idPrzepisu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Przepis")
                        .IsRequired()
                        .HasMaxLength(5000)
                        .HasColumnType("TEXT");

                    b.Property<TimeSpan>("czas")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("data")
                        .HasColumnType("TEXT");

                    b.Property<int>("liczbaPorcji")
                        .HasColumnType("INTEGER");

                    b.Property<string>("nazwaDania")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("idPrzepisu");

                    b.ToTable("Przepisy");
                });

            modelBuilder.Entity("KsiazkaPrzepisyKokot.Models.SkladnikiPrzepisu", b =>
                {
                    b.Property<int>("idSkladnika")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("idPrzepisu")
                        .HasColumnType("INTEGER");

                    b.Property<int>("idWszystkieSkladniki")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ilosc")
                        .HasColumnType("INTEGER");

                    b.Property<string>("jaka_miara")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("idSkladnika");

                    b.HasIndex("idPrzepisu");

                    b.HasIndex("idWszystkieSkladniki");

                    b.ToTable("SkladnikiPrzepisu");
                });

            modelBuilder.Entity("KsiazkaPrzepisyKokot.Models.Ulubione", b =>
                {
                    b.Property<int>("idUlubione")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("idPrzepis")
                        .HasColumnType("INTEGER");

                    b.HasKey("idUlubione");

                    b.HasIndex("idPrzepis");

                    b.ToTable("Ulubione");
                });

            modelBuilder.Entity("KsiazkaPrzepisyKokot.Models.WszystkieSkladniki", b =>
                {
                    b.Property<int>("idWszystkieSkladniki")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double?>("gram_kcal")
                        .HasColumnType("REAL");

                    b.Property<double?>("lyzeczka_kcal")
                        .HasColumnType("REAL");

                    b.Property<double?>("lyzka_kcal")
                        .HasColumnType("REAL");

                    b.Property<string>("skladnik")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<double?>("szklanka_kcal")
                        .HasColumnType("REAL");

                    b.HasKey("idWszystkieSkladniki");

                    b.ToTable("WszystkieSkladniki");
                });

            modelBuilder.Entity("KsiazkaPrzepisyKokot.Models.Ciasta", b =>
                {
                    b.HasBaseType("KsiazkaPrzepisyKokot.Models.Przepisy");

                    b.Property<bool>("ciasto_francuskie")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("drozdzowe")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("na_cieplo")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("na_zimno")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("z_owocami")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("z_owsianka")
                        .HasColumnType("INTEGER");

                    b.ToTable("Ciasta");
                });

            modelBuilder.Entity("KsiazkaPrzepisyKokot.Models.Drinki", b =>
                {
                    b.HasBaseType("KsiazkaPrzepisyKokot.Models.Przepisy");

                    b.Property<bool>("bezalkoholowy")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("rum")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("whisky")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("wodka")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("yager")
                        .HasColumnType("INTEGER");

                    b.ToTable("Drinki");
                });

            modelBuilder.Entity("KsiazkaPrzepisyKokot.Models.Fit", b =>
                {
                    b.HasBaseType("KsiazkaPrzepisyKokot.Models.Przepisy");

                    b.Property<bool>("z_jogurtem")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("z_kasza")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("z_owocami")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("z_owsianka")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("z_ryzem")
                        .HasColumnType("INTEGER");

                    b.ToTable("Fit");
                });

            modelBuilder.Entity("KsiazkaPrzepisyKokot.Models.Kolacje", b =>
                {
                    b.HasBaseType("KsiazkaPrzepisyKokot.Models.Przepisy");

                    b.Property<bool>("fit")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("na_slodko")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("na_slono")
                        .HasColumnType("INTEGER");

                    b.ToTable("Kolacje");
                });

            modelBuilder.Entity("KsiazkaPrzepisyKokot.Models.Obiady", b =>
                {
                    b.HasBaseType("KsiazkaPrzepisyKokot.Models.Przepisy");

                    b.Property<bool>("z_kartoflami")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("z_kurczakiem")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("z_makaronem")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("z_mielonym")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("z_ryzem")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("z_wieprzowina")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("z_wolowina")
                        .HasColumnType("INTEGER");

                    b.ToTable("Obiady");
                });

            modelBuilder.Entity("KsiazkaPrzepisyKokot.Models.Salatki", b =>
                {
                    b.HasBaseType("KsiazkaPrzepisyKokot.Models.Przepisy");

                    b.Property<bool>("na_cieplo")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("na_zimno")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("z_kurczakiem")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("z_makaronem")
                        .HasColumnType("INTEGER");

                    b.ToTable("Salatki");
                });

            modelBuilder.Entity("KsiazkaPrzepisyKokot.Models.Slone_przekaski", b =>
                {
                    b.HasBaseType("KsiazkaPrzepisyKokot.Models.Przepisy");

                    b.Property<bool>("na_cieplo")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("na_zimno")
                        .HasColumnType("INTEGER");

                    b.ToTable("Slone_przekaski");
                });

            modelBuilder.Entity("KsiazkaPrzepisyKokot.Models.Sniadania", b =>
                {
                    b.HasBaseType("KsiazkaPrzepisyKokot.Models.Przepisy");

                    b.Property<bool>("bez_miesa")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("fit")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("na_slodko")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("na_slono")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("z_jajkiem")
                        .HasColumnType("INTEGER");

                    b.ToTable("Sniadania");
                });

            modelBuilder.Entity("KsiazkaPrzepisyKokot.Models.Sosy", b =>
                {
                    b.HasBaseType("KsiazkaPrzepisyKokot.Models.Przepisy");

                    b.Property<bool>("slodkie")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("slone")
                        .HasColumnType("INTEGER");

                    b.ToTable("Sosy");
                });

            modelBuilder.Entity("KsiazkaPrzepisyKokot.Models.SkladnikiPrzepisu", b =>
                {
                    b.HasOne("KsiazkaPrzepisyKokot.Models.Przepisy", "przepis")
                        .WithMany()
                        .HasForeignKey("idPrzepisu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KsiazkaPrzepisyKokot.Models.WszystkieSkladniki", "wszystkieSkladniki")
                        .WithMany()
                        .HasForeignKey("idWszystkieSkladniki")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("przepis");

                    b.Navigation("wszystkieSkladniki");
                });

            modelBuilder.Entity("KsiazkaPrzepisyKokot.Models.Ulubione", b =>
                {
                    b.HasOne("KsiazkaPrzepisyKokot.Models.Przepisy", "przepis")
                        .WithMany()
                        .HasForeignKey("idPrzepis")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("przepis");
                });

            modelBuilder.Entity("KsiazkaPrzepisyKokot.Models.Ciasta", b =>
                {
                    b.HasOne("KsiazkaPrzepisyKokot.Models.Przepisy", null)
                        .WithOne()
                        .HasForeignKey("KsiazkaPrzepisyKokot.Models.Ciasta", "idPrzepisu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KsiazkaPrzepisyKokot.Models.Drinki", b =>
                {
                    b.HasOne("KsiazkaPrzepisyKokot.Models.Przepisy", null)
                        .WithOne()
                        .HasForeignKey("KsiazkaPrzepisyKokot.Models.Drinki", "idPrzepisu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KsiazkaPrzepisyKokot.Models.Fit", b =>
                {
                    b.HasOne("KsiazkaPrzepisyKokot.Models.Przepisy", null)
                        .WithOne()
                        .HasForeignKey("KsiazkaPrzepisyKokot.Models.Fit", "idPrzepisu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KsiazkaPrzepisyKokot.Models.Kolacje", b =>
                {
                    b.HasOne("KsiazkaPrzepisyKokot.Models.Przepisy", null)
                        .WithOne()
                        .HasForeignKey("KsiazkaPrzepisyKokot.Models.Kolacje", "idPrzepisu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KsiazkaPrzepisyKokot.Models.Obiady", b =>
                {
                    b.HasOne("KsiazkaPrzepisyKokot.Models.Przepisy", null)
                        .WithOne()
                        .HasForeignKey("KsiazkaPrzepisyKokot.Models.Obiady", "idPrzepisu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KsiazkaPrzepisyKokot.Models.Salatki", b =>
                {
                    b.HasOne("KsiazkaPrzepisyKokot.Models.Przepisy", null)
                        .WithOne()
                        .HasForeignKey("KsiazkaPrzepisyKokot.Models.Salatki", "idPrzepisu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KsiazkaPrzepisyKokot.Models.Slone_przekaski", b =>
                {
                    b.HasOne("KsiazkaPrzepisyKokot.Models.Przepisy", null)
                        .WithOne()
                        .HasForeignKey("KsiazkaPrzepisyKokot.Models.Slone_przekaski", "idPrzepisu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KsiazkaPrzepisyKokot.Models.Sniadania", b =>
                {
                    b.HasOne("KsiazkaPrzepisyKokot.Models.Przepisy", null)
                        .WithOne()
                        .HasForeignKey("KsiazkaPrzepisyKokot.Models.Sniadania", "idPrzepisu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KsiazkaPrzepisyKokot.Models.Sosy", b =>
                {
                    b.HasOne("KsiazkaPrzepisyKokot.Models.Przepisy", null)
                        .WithOne()
                        .HasForeignKey("KsiazkaPrzepisyKokot.Models.Sosy", "idPrzepisu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
