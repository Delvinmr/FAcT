﻿// <auto-generated />
using System;
using FAcT.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FAcT.Migrations
{
    [DbContext(typeof(FAcTContext))]
    [Migration("20200607013333_cmpart")]
    partial class cmpart
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FAcT.Models.Articulos", b =>
                {
                    b.Property<int>("articulosID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClasifarticulosID")
                        .HasColumnType("int");

                    b.Property<int?>("ClasificaciondeArticulosClasifarticulosID")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<decimal>("Itebis")
                        .HasColumnType("decimal(18,2)")
                        .HasMaxLength(50);

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18,2)")
                        .HasMaxLength(50);

                    b.Property<int>("marcaID")
                        .HasColumnType("int");

                    b.Property<int>("statusID")
                        .HasColumnType("int");

                    b.Property<int>("ubicacionID")
                        .HasColumnType("int");

                    b.Property<int?>("unidaddemedidasunidaddemedisID")
                        .HasColumnType("int");

                    b.Property<int>("unidaddemedisID")
                        .HasColumnType("int");

                    b.HasKey("articulosID");

                    b.HasIndex("ClasificaciondeArticulosClasifarticulosID");

                    b.HasIndex("marcaID");

                    b.HasIndex("statusID");

                    b.HasIndex("ubicacionID");

                    b.HasIndex("unidaddemedidasunidaddemedisID");

                    b.ToTable("Articulos");
                });

            modelBuilder.Entity("FAcT.Models.Clasificacionclientes", b =>
                {
                    b.Property<int>("ClasfclientesID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("ClasfclientesID");

                    b.ToTable("Clasificacionclientes");
                });

            modelBuilder.Entity("FAcT.Models.ClasificaciondeArticulos", b =>
                {
                    b.Property<int>("ClasifarticulosID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("ClasifarticulosID");

                    b.ToTable("ClasificaciondeArticulos");
                });

            modelBuilder.Entity("FAcT.Models.Clasificacionsuplidores", b =>
                {
                    b.Property<int>("clasifsuplidoresID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("clasifsuplidoresID");

                    b.ToTable("Clasificacionsuplidores");
                });

            modelBuilder.Entity("FAcT.Models.Clientes", b =>
                {
                    b.Property<int>("clienteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Celular")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<int>("ClasfclientesID")
                        .HasColumnType("int");

                    b.Property<int?>("ClasificacionclientesClasfclientesID")
                        .HasColumnType("int");

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Documento")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("apellidos")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("paisID")
                        .HasColumnType("int");

                    b.Property<int>("provinciaID")
                        .HasColumnType("int");

                    b.Property<int>("tipodocumentoID")
                        .HasColumnType("int");

                    b.Property<int?>("tiposdocumentostipodocumentoID")
                        .HasColumnType("int");

                    b.HasKey("clienteID");

                    b.HasIndex("ClasificacionclientesClasfclientesID");

                    b.HasIndex("paisID");

                    b.HasIndex("provinciaID");

                    b.HasIndex("tiposdocumentostipodocumentoID");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("FAcT.Models.Empleado", b =>
                {
                    b.Property<int>("empleadoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Celular")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Documento")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("apellidos")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("empresaID")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("puestodetrabID")
                        .HasColumnType("int");

                    b.HasKey("empleadoID");

                    b.HasIndex("empresaID");

                    b.HasIndex("puestodetrabID");

                    b.ToTable("Empleado");
                });

            modelBuilder.Entity("FAcT.Models.Empresa", b =>
                {
                    b.Property<int>("empresaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("empresaID");

                    b.ToTable("Empresa");
                });

            modelBuilder.Entity("FAcT.Models.Formadeenvio", b =>
                {
                    b.Property<int>("formadeenvioID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("formadeenvioID");

                    b.ToTable("Formadeenvio");
                });

            modelBuilder.Entity("FAcT.Models.Formadepago", b =>
                {
                    b.Property<int>("formadepagoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("formadepagoID");

                    b.ToTable("Formadepago");
                });

            modelBuilder.Entity("FAcT.Models.Marca", b =>
                {
                    b.Property<int>("marcaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("marcaID");

                    b.ToTable("Marca");
                });

            modelBuilder.Entity("FAcT.Models.Moneda", b =>
                {
                    b.Property<int>("monedaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("monedaID");

                    b.ToTable("Moneda");
                });

            modelBuilder.Entity("FAcT.Models.Municipio", b =>
                {
                    b.Property<int>("municipioID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("nombre_municipio")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("provinciaID")
                        .HasColumnType("int");

                    b.HasKey("municipioID");

                    b.HasIndex("provinciaID");

                    b.ToTable("Municipio");
                });

            modelBuilder.Entity("FAcT.Models.Pais", b =>
                {
                    b.Property<int>("paisID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("nombre_pais")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("paisID");

                    b.ToTable("Pais");
                });

            modelBuilder.Entity("FAcT.Models.Provincia", b =>
                {
                    b.Property<int>("provinciaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("nombre_provincia")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("paisID")
                        .HasColumnType("int");

                    b.HasKey("provinciaID");

                    b.HasIndex("paisID");

                    b.ToTable("Provincia");
                });

            modelBuilder.Entity("FAcT.Models.Puestodetrabajo", b =>
                {
                    b.Property<int>("puestodetrabID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("puestodetrabID");

                    b.ToTable("Puestodetrabajo");
                });

            modelBuilder.Entity("FAcT.Models.Sector", b =>
                {
                    b.Property<int>("sectorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("municipioID")
                        .HasColumnType("int");

                    b.Property<string>("nombre_sector")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("sectorID");

                    b.HasIndex("municipioID");

                    b.ToTable("Sector");
                });

            modelBuilder.Entity("FAcT.Models.Status", b =>
                {
                    b.Property<int>("statusID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("statusID");

                    b.ToTable("Status");
                });

            modelBuilder.Entity("FAcT.Models.Suplidores", b =>
                {
                    b.Property<int>("SuplidoresID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Celular")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Documento")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("apellidos")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("SuplidoresID");

                    b.ToTable("Suplidores");
                });

            modelBuilder.Entity("FAcT.Models.Tasadecambio", b =>
                {
                    b.Property<int>("tasadecambioID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("tasadecambioID");

                    b.ToTable("Tasadecambio");
                });

            modelBuilder.Entity("FAcT.Models.Tiposdocumentos", b =>
                {
                    b.Property<int>("tipodocumentoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("tipodocumentoID");

                    b.ToTable("Tiposdocumentos");
                });

            modelBuilder.Entity("FAcT.Models.Ubicacion", b =>
                {
                    b.Property<int>("ubicacionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("ubicacionID");

                    b.ToTable("Ubicacion");
                });

            modelBuilder.Entity("FAcT.Models.Unidaddemedidas", b =>
                {
                    b.Property<int>("unidaddemedisID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("unidaddemedisID");

                    b.ToTable("Unidaddemedidas");
                });

            modelBuilder.Entity("FAcT.Models.Vendedores", b =>
                {
                    b.Property<int>("vendedorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Celular")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Documento")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("apellidos")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("vendedorID");

                    b.ToTable("Vendedores");
                });

            modelBuilder.Entity("FAcT.Models.Articulos", b =>
                {
                    b.HasOne("FAcT.Models.ClasificaciondeArticulos", "ClasificaciondeArticulos")
                        .WithMany()
                        .HasForeignKey("ClasificaciondeArticulosClasifarticulosID");

                    b.HasOne("FAcT.Models.Marca", "marca")
                        .WithMany()
                        .HasForeignKey("marcaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FAcT.Models.Status", "Status")
                        .WithMany()
                        .HasForeignKey("statusID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FAcT.Models.Ubicacion", "ubicacion")
                        .WithMany()
                        .HasForeignKey("ubicacionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FAcT.Models.Unidaddemedidas", "unidaddemedidas")
                        .WithMany()
                        .HasForeignKey("unidaddemedidasunidaddemedisID");
                });

            modelBuilder.Entity("FAcT.Models.Clientes", b =>
                {
                    b.HasOne("FAcT.Models.Clasificacionclientes", "Clasificacionclientes")
                        .WithMany()
                        .HasForeignKey("ClasificacionclientesClasfclientesID");

                    b.HasOne("FAcT.Models.Pais", "pais")
                        .WithMany()
                        .HasForeignKey("paisID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FAcT.Models.Provincia", "provincia")
                        .WithMany()
                        .HasForeignKey("provinciaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FAcT.Models.Tiposdocumentos", "tiposdocumentos")
                        .WithMany()
                        .HasForeignKey("tiposdocumentostipodocumentoID");
                });

            modelBuilder.Entity("FAcT.Models.Empleado", b =>
                {
                    b.HasOne("FAcT.Models.Empresa", "Empresa")
                        .WithMany()
                        .HasForeignKey("empresaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FAcT.Models.Puestodetrabajo", "Puestodetrabajo")
                        .WithMany()
                        .HasForeignKey("puestodetrabID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FAcT.Models.Municipio", b =>
                {
                    b.HasOne("FAcT.Models.Provincia", "Provincia")
                        .WithMany()
                        .HasForeignKey("provinciaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FAcT.Models.Provincia", b =>
                {
                    b.HasOne("FAcT.Models.Pais", "pais")
                        .WithMany()
                        .HasForeignKey("paisID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FAcT.Models.Sector", b =>
                {
                    b.HasOne("FAcT.Models.Municipio", "municipio")
                        .WithMany()
                        .HasForeignKey("municipioID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
