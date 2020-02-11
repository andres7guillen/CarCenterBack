﻿// <auto-generated />
using System;
using CarCenterData.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CarCenterData.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200211164852_ApiSefuridad_Y_Modelado_BaseDeDatos")]
    partial class ApiSefuridad_Y_Modelado_BaseDeDatos
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CarCenterCore.Entidades.Seguridad.ApplicationUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("CarCenterCore.Entidades.Seguridad.UserRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("CarCenterData.Entidades.Negocio.Cliente", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Celular")
                        .HasMaxLength(10);

                    b.Property<string>("Direccion")
                        .HasMaxLength(200);

                    b.Property<string>("Documento")
                        .HasMaxLength(20);

                    b.Property<string>("Email")
                        .HasMaxLength(100);

                    b.Property<double>("PresupuestoMaximo");

                    b.Property<string>("PrimerApellido")
                        .HasMaxLength(30);

                    b.Property<string>("PrimerNombre")
                        .HasMaxLength(30);

                    b.Property<string>("SegundoApellido")
                        .HasMaxLength(30);

                    b.Property<string>("SegundoNombre")
                        .HasMaxLength(30);

                    b.Property<string>("TipoDocumento")
                        .HasMaxLength(2);

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("CarCenterData.Entidades.Negocio.Foto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("MantenimientoId");

                    b.Property<string>("Ruta")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("MantenimientoId");

                    b.ToTable("Fotos");
                });

            modelBuilder.Entity("CarCenterData.Entidades.Negocio.Mantenimiento", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Estado");

                    b.Property<DateTime>("Fecha");

                    b.Property<Guid>("MecanicoId");

                    b.Property<Guid>("VehiculoId");

                    b.HasKey("Id");

                    b.HasIndex("MecanicoId");

                    b.HasIndex("VehiculoId");

                    b.ToTable("Mantenimientos");
                });

            modelBuilder.Entity("CarCenterData.Entidades.Negocio.Marca", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("NombreMarca")
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.ToTable("Marcas");
                });

            modelBuilder.Entity("CarCenterData.Entidades.Negocio.Mecanico", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Celular")
                        .HasMaxLength(10);

                    b.Property<string>("Direccion")
                        .HasMaxLength(200);

                    b.Property<string>("Documento")
                        .HasMaxLength(20);

                    b.Property<string>("Email")
                        .HasMaxLength(100);

                    b.Property<string>("PrimerApellido")
                        .HasMaxLength(30);

                    b.Property<string>("PrimerNombre")
                        .HasMaxLength(30);

                    b.Property<string>("SegundoApellido")
                        .HasMaxLength(30);

                    b.Property<string>("SegundoNombre")
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.ToTable("Mecanicos");
                });

            modelBuilder.Entity("CarCenterData.Entidades.Negocio.Repuesto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nombre")
                        .HasMaxLength(100);

                    b.Property<double>("PrecioUnitario");

                    b.Property<string>("Proveedor")
                        .HasMaxLength(300);

                    b.Property<int>("UnidadesInventario");

                    b.HasKey("Id");

                    b.ToTable("Repuestos");
                });

            modelBuilder.Entity("CarCenterData.Entidades.Negocio.RepuestosMantenimientos", b =>
                {
                    b.Property<Guid>("RepuestoId");

                    b.Property<Guid>("MantenimientoId");

                    b.HasKey("RepuestoId", "MantenimientoId");

                    b.HasIndex("MantenimientoId");

                    b.ToTable("RepuestosMantenimientos");
                });

            modelBuilder.Entity("CarCenterData.Entidades.Negocio.Servicio", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nombre")
                        .HasMaxLength(100);

                    b.Property<double>("Precio");

                    b.HasKey("Id");

                    b.ToTable("Servicios");
                });

            modelBuilder.Entity("CarCenterData.Entidades.Negocio.ServiciosMantenimientos", b =>
                {
                    b.Property<Guid>("ServicioId");

                    b.Property<Guid>("MantenimientoId");

                    b.HasKey("ServicioId", "MantenimientoId");

                    b.HasIndex("MantenimientoId");

                    b.ToTable("ServiciosMantenimientos");
                });

            modelBuilder.Entity("CarCenterData.Entidades.Negocio.Vehiculo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("ClienteId");

                    b.Property<string>("Color")
                        .HasMaxLength(30);

                    b.Property<Guid>("MarcaId");

                    b.Property<string>("Placa")
                        .HasMaxLength(6);

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("MarcaId");

                    b.ToTable("Vehiculos");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<Guid>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<Guid>("UserId");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId");

                    b.Property<Guid>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("CarCenterData.Entidades.Negocio.Foto", b =>
                {
                    b.HasOne("CarCenterData.Entidades.Negocio.Mantenimiento", "Mantenimiento")
                        .WithMany("Fotos")
                        .HasForeignKey("MantenimientoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CarCenterData.Entidades.Negocio.Mantenimiento", b =>
                {
                    b.HasOne("CarCenterData.Entidades.Negocio.Mecanico", "Mecanico")
                        .WithMany("Mantenimientos")
                        .HasForeignKey("MecanicoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CarCenterData.Entidades.Negocio.Vehiculo", "Vehiculo")
                        .WithMany("Mantenimientos")
                        .HasForeignKey("VehiculoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CarCenterData.Entidades.Negocio.RepuestosMantenimientos", b =>
                {
                    b.HasOne("CarCenterData.Entidades.Negocio.Mantenimiento", "Mantenimiento")
                        .WithMany()
                        .HasForeignKey("MantenimientoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CarCenterData.Entidades.Negocio.Repuesto", "Repuesto")
                        .WithMany()
                        .HasForeignKey("RepuestoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CarCenterData.Entidades.Negocio.ServiciosMantenimientos", b =>
                {
                    b.HasOne("CarCenterData.Entidades.Negocio.Mantenimiento", "Mantenimiento")
                        .WithMany()
                        .HasForeignKey("MantenimientoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CarCenterData.Entidades.Negocio.Servicio", "Servicio")
                        .WithMany()
                        .HasForeignKey("ServicioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CarCenterData.Entidades.Negocio.Vehiculo", b =>
                {
                    b.HasOne("CarCenterData.Entidades.Negocio.Cliente", "Cliente")
                        .WithMany("Vehiculos")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CarCenterData.Entidades.Negocio.Marca", "Marca")
                        .WithMany("Vehiculos")
                        .HasForeignKey("MarcaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("CarCenterCore.Entidades.Seguridad.UserRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("CarCenterCore.Entidades.Seguridad.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("CarCenterCore.Entidades.Seguridad.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("CarCenterCore.Entidades.Seguridad.UserRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CarCenterCore.Entidades.Seguridad.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("CarCenterCore.Entidades.Seguridad.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
