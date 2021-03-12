using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Tarea7_App.Models
{
    public partial class Tarea6Context : DbContext
    {
        public Tarea6Context()
        {
        }

        public Tarea6Context(DbContextOptions<Tarea6Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Vacunados> Vacunados { get; set; }
        public virtual DbSet<Vacunas> Vacunas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlite("Data Source= Data\\Tarea6.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vacunados>(entity =>
            {
                entity.HasKey(e => e.Cedula);

                entity.Property(e => e.Apellido).IsRequired();

                entity.Property(e => e.FechaNacimiento)
                    .IsRequired()
                    .HasColumnName("Fecha_Nacimiento");

                entity.Property(e => e.FechaPdosis).HasColumnName("Fecha_PDosis");

                entity.Property(e => e.FechaSdosis).HasColumnName("Fecha_SDosis");

                entity.Property(e => e.MarcaVacuna).HasColumnName("Marca_Vacuna");

                entity.Property(e => e.Nombre).IsRequired();

                entity.Property(e => e.Provincia).IsRequired();

                entity.Property(e => e.SignoZodiacal)
                    .IsRequired()
                    .HasColumnName("Signo_Zodiacal");
            });

            modelBuilder.Entity<Vacunas>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Marca).IsRequired();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
