﻿// <auto-generated />
using System;
using EFRepositoryMVC.Data.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFRepositoryMVC.Migrations
{
    [DbContext(typeof(DbContextCodeFirst))]
    partial class DbContextCodeFirstModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.27")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EFRepositoryMVC.Models.EntitiesPrenda.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Categorias", (string)null);
                });

            modelBuilder.Entity("EFRepositoryMVC.Models.EntitiesPrenda.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ColorInRGB")
                        .IsRequired()
                        .HasMaxLength(16)
                        .IsUnicode(true)
                        .HasColumnType("nchar(16)")
                        .IsFixedLength();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Colores", (string)null);
                });

            modelBuilder.Entity("EFRepositoryMVC.Models.EntitiesPrenda.Imagen", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("PrendaId")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.HasKey("Id");

                    b.HasIndex("PrendaId");

                    b.ToTable("Images", (string)null);
                });

            modelBuilder.Entity("EFRepositoryMVC.Models.EntitiesPrenda.Marca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Marcas", (string)null);
                });

            modelBuilder.Entity("EFRepositoryMVC.Models.EntitiesPrenda.Prenda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Available")
                        .HasColumnType("bit");

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(3000)
                        .HasColumnType("nvarchar(3000)");

                    b.Property<DateTime>("FechaActualizacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<int>("MarcaId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("MarcaId");

                    b.ToTable("Prendas", (string)null);
                });

            modelBuilder.Entity("EFRepositoryMVC.Models.EntitiesPrenda.PrendaTamanioColorStock", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ColorId")
                        .HasColumnType("int");

                    b.Property<int>("PrendaId")
                        .HasColumnType("int");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<int>("TamanioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ColorId");

                    b.HasIndex("PrendaId");

                    b.HasIndex("TamanioId");

                    b.ToTable("PrendaTamanioColorStocks", (string)null);
                });

            modelBuilder.Entity("EFRepositoryMVC.Models.EntitiesPrenda.Tamanio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Tamanios", (string)null);
                });

            modelBuilder.Entity("EFRepositoryMVC.Models.EntitiesPrenda.Imagen", b =>
                {
                    b.HasOne("EFRepositoryMVC.Models.EntitiesPrenda.Prenda", "Prenda")
                        .WithMany("Imagenes")
                        .HasForeignKey("PrendaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Prenda");
                });

            modelBuilder.Entity("EFRepositoryMVC.Models.EntitiesPrenda.Prenda", b =>
                {
                    b.HasOne("EFRepositoryMVC.Models.EntitiesPrenda.Categoria", "Categoria")
                        .WithMany("Prendas")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFRepositoryMVC.Models.EntitiesPrenda.Marca", "Marca")
                        .WithMany("Prendas")
                        .HasForeignKey("MarcaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");

                    b.Navigation("Marca");
                });

            modelBuilder.Entity("EFRepositoryMVC.Models.EntitiesPrenda.PrendaTamanioColorStock", b =>
                {
                    b.HasOne("EFRepositoryMVC.Models.EntitiesPrenda.Color", "Color")
                        .WithMany("PrendaTamanioColorStocks")
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFRepositoryMVC.Models.EntitiesPrenda.Prenda", "Prenda")
                        .WithMany("PrendaTamanioColorStocks")
                        .HasForeignKey("PrendaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFRepositoryMVC.Models.EntitiesPrenda.Tamanio", "Tamanio")
                        .WithMany("PrendaTamanioColorStocks")
                        .HasForeignKey("TamanioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Color");

                    b.Navigation("Prenda");

                    b.Navigation("Tamanio");
                });

            modelBuilder.Entity("EFRepositoryMVC.Models.EntitiesPrenda.Categoria", b =>
                {
                    b.Navigation("Prendas");
                });

            modelBuilder.Entity("EFRepositoryMVC.Models.EntitiesPrenda.Color", b =>
                {
                    b.Navigation("PrendaTamanioColorStocks");
                });

            modelBuilder.Entity("EFRepositoryMVC.Models.EntitiesPrenda.Marca", b =>
                {
                    b.Navigation("Prendas");
                });

            modelBuilder.Entity("EFRepositoryMVC.Models.EntitiesPrenda.Prenda", b =>
                {
                    b.Navigation("Imagenes");

                    b.Navigation("PrendaTamanioColorStocks");
                });

            modelBuilder.Entity("EFRepositoryMVC.Models.EntitiesPrenda.Tamanio", b =>
                {
                    b.Navigation("PrendaTamanioColorStocks");
                });
#pragma warning restore 612, 618
        }
    }
}
