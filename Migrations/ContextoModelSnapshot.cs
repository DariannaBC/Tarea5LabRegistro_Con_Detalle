﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tarea5LabRegistro_Con_Detalle.DAL;

namespace Tarea5LabRegistro_Con_Detalle.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.10");

            modelBuilder.Entity("Tarea5LabRegistro_Con_Detalle.Entidades.Permisos", b =>
                {
                    b.Property<int>("PermisosId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DescripcionPermisos")
                        .HasColumnType("TEXT");

                    b.HasKey("PermisosId");

                    b.ToTable("Permisos");

                    b.HasData(
                        new
                        {
                            PermisosId = 1,
                            DescripcionPermisos = "Descuento"
                        },
                        new
                        {
                            PermisosId = 2,
                            DescripcionPermisos = "Vende"
                        },
                        new
                        {
                            PermisosId = 3,
                            DescripcionPermisos = "Compra"
                        });
                });

            modelBuilder.Entity("Tarea5LabRegistro_Con_Detalle.Entidades.Roles", b =>
                {
                    b.Property<int>("RolID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DescripcionRol")
                        .HasColumnType("TEXT");

                    b.Property<bool>("EsActivo")
                        .HasColumnType("INTEGER");

                    b.HasKey("RolID");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Tarea5LabRegistro_Con_Detalle.Entidades.RolesDetalle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("EsAsignado")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PermisosId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RolID")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("RolID");

                    b.ToTable("RolesDetalle");
                });

            modelBuilder.Entity("Tarea5LabRegistro_Con_Detalle.Entidades.Usuarios", b =>
                {
                    b.Property<int>("UsuarioID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Activo")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Alias")
                        .HasColumnType("TEXT");

                    b.Property<string>("Clave")
                        .HasColumnType("TEXT");

                    b.Property<string>("DescripcionRol")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaIngreso")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombres")
                        .HasColumnType("TEXT");

                    b.HasKey("UsuarioID");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Tarea5LabRegistro_Con_Detalle.Entidades.Permisos", b =>
                {
                    b.HasOne("Tarea5LabRegistro_Con_Detalle.Entidades.Permisos", "permiso")
                        .WithMany()
                        .HasForeignKey("PermisosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("permiso");
                });

            modelBuilder.Entity("Tarea5LabRegistro_Con_Detalle.Entidades.RolesDetalle", b =>
                {
                    b.HasOne("Tarea5LabRegistro_Con_Detalle.Entidades.Roles", null)
                        .WithMany("Detalle")
                        .HasForeignKey("RolID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Tarea5LabRegistro_Con_Detalle.Entidades.Roles", b =>
                {
                    b.Navigation("Detalle");
                });
#pragma warning restore 612, 618
        }
    }
}
