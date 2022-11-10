﻿// <auto-generated />
using BDContactos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BDContactos.Migrations
{
    [DbContext(typeof(ContactosContext))]
    partial class ContactosContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BDContactos.Contacto", b =>
                {
                    b.Property<int>("ContactoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ContactoId"));

                    b.Property<int>("PersonaId")
                        .HasColumnType("int");

                    b.Property<string>("tipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("valor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ContactoId");

                    b.HasIndex("PersonaId");

                    b.ToTable("Contacto", (string)null);
                });

            modelBuilder.Entity("BDContactos.Persona", b =>
                {
                    b.Property<int>("PersonaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonaId"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersonaId");

                    b.ToTable("Persona", (string)null);
                });

            modelBuilder.Entity("BDContactos.Contacto", b =>
                {
                    b.HasOne("BDContactos.Persona", "Persona")
                        .WithMany("Contactos")
                        .HasForeignKey("PersonaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Persona");
                });

            modelBuilder.Entity("BDContactos.Persona", b =>
                {
                    b.Navigation("Contactos");
                });
#pragma warning restore 612, 618
        }
    }
}