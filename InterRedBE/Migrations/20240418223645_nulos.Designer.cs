﻿// <auto-generated />
using System;
using InterRedBE.DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace InterRedBE.Migrations
{
    [DbContext(typeof(InterRedContext))]
    [Migration("20240418223645_nulos")]
    partial class nulos
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("InterRedBE.DAL.Models.Calificacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Comentario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IdLugarTuristico")
                        .HasColumnType("int");

                    b.Property<int>("LugarTuristicoId")
                        .HasColumnType("int");

                    b.Property<string>("Puntuacion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LugarTuristicoId");

                    b.ToTable("Calificacion");
                });

            modelBuilder.Entity("InterRedBE.DAL.Models.Departamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IdCabecera")
                        .HasColumnType("int");

                    b.Property<string>("Imagen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Poblacion")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdCabecera")
                        .IsUnique()
                        .HasFilter("[IdCabecera] IS NOT NULL");

                    b.ToTable("Departamento");
                });

            modelBuilder.Entity("InterRedBE.DAL.Models.LugarTuristico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DepartamentoId")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IdDepartamento")
                        .HasColumnType("int");

                    b.Property<int?>("IdMunicipio")
                        .HasColumnType("int");

                    b.Property<string>("Imagen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MunicipioId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DepartamentoId");

                    b.HasIndex("MunicipioId");

                    b.ToTable("LugarTuristico");
                });

            modelBuilder.Entity("InterRedBE.DAL.Models.Municipio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IdDepartamento")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Poblacion")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdDepartamento");

                    b.ToTable("Municipio");
                });

            modelBuilder.Entity("InterRedBE.DAL.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Contrasena")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreUsuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("InterRedBE.DAL.Models.Visita", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("IdLugarTuristico")
                        .HasColumnType("int");

                    b.Property<int>("LugarTuristicoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LugarTuristicoId");

                    b.ToTable("Visita");
                });

            modelBuilder.Entity("InterRedBE.DAL.Models.Calificacion", b =>
                {
                    b.HasOne("InterRedBE.DAL.Models.LugarTuristico", "LugarTuristico")
                        .WithMany("Calificaciones")
                        .HasForeignKey("LugarTuristicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LugarTuristico");
                });

            modelBuilder.Entity("InterRedBE.DAL.Models.Departamento", b =>
                {
                    b.HasOne("InterRedBE.DAL.Models.Municipio", "Cabecera")
                        .WithOne()
                        .HasForeignKey("InterRedBE.DAL.Models.Departamento", "IdCabecera")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Cabecera");
                });

            modelBuilder.Entity("InterRedBE.DAL.Models.LugarTuristico", b =>
                {
                    b.HasOne("InterRedBE.DAL.Models.Departamento", "Departamento")
                        .WithMany("LugaresTuristicos")
                        .HasForeignKey("DepartamentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InterRedBE.DAL.Models.Municipio", "Municipio")
                        .WithMany("LugaresTuristicos")
                        .HasForeignKey("MunicipioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Departamento");

                    b.Navigation("Municipio");
                });

            modelBuilder.Entity("InterRedBE.DAL.Models.Municipio", b =>
                {
                    b.HasOne("InterRedBE.DAL.Models.Departamento", "Departamento")
                        .WithMany("Municipios")
                        .HasForeignKey("IdDepartamento");

                    b.Navigation("Departamento");
                });

            modelBuilder.Entity("InterRedBE.DAL.Models.Visita", b =>
                {
                    b.HasOne("InterRedBE.DAL.Models.LugarTuristico", "LugarTuristico")
                        .WithMany("Visitas")
                        .HasForeignKey("LugarTuristicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LugarTuristico");
                });

            modelBuilder.Entity("InterRedBE.DAL.Models.Departamento", b =>
                {
                    b.Navigation("LugaresTuristicos");

                    b.Navigation("Municipios");
                });

            modelBuilder.Entity("InterRedBE.DAL.Models.LugarTuristico", b =>
                {
                    b.Navigation("Calificaciones");

                    b.Navigation("Visitas");
                });

            modelBuilder.Entity("InterRedBE.DAL.Models.Municipio", b =>
                {
                    b.Navigation("LugaresTuristicos");
                });
#pragma warning restore 612, 618
        }
    }
}
