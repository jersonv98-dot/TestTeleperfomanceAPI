using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using TestAPITP.DataAccess.Model;

namespace TestAPITP.DataAccess
{
    public partial class TestTPContext : DbContext
    {
        private readonly IConfiguration _IConfiguration;

        public TestTPContext()
        {
            
        }

        public TestTPContext(DbContextOptions<TestTPContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Compañia> Compañias { get; set; }
        public virtual DbSet<CompañiaPermitida> CompañiasPermitidas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-F06VBCO;Database=TestTP;Trusted_Connection=True;");

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<CompañiaPermitida>(entity =>
            {
                entity.ToTable("CompañiasPermitidas");

                entity.Property(e => e.Documento)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("documento");
            });

            modelBuilder.Entity<Compañia>(entity =>
            {

                entity.Property(e => e.TipoDocumento)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tipodocumento");

                entity.Property(e => e.Documento)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("documento");

                entity.Property(e => e.NombreCompañia)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombrecompañia");
                
                entity.Property(e => e.PrimerNombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("primernombre");
                entity.Property(e => e.SegundoNombre)
                   .IsRequired()
                   .HasMaxLength(50)
                   .IsUnicode(false)
                   .HasColumnName("segundonombre");
                entity.Property(e => e.PrimerApellido)
                   .IsRequired()
                   .HasMaxLength(50)
                   .IsUnicode(false)
                   .HasColumnName("primerapellido");
                entity.Property(e => e.SegundoApellido)
                  .IsRequired()
                  .HasMaxLength(50)
                  .IsUnicode(false)
                  .HasColumnName("segundoapellido");
                entity.Property(e => e.Email)
                 .IsRequired()
                 .HasMaxLength(50)
                 .IsUnicode(false)
                 .HasColumnName("email");
                entity.Property(e => e.EnviarMensajesEmail)
                 .IsRequired()
                 .HasColumnType("int")
                 .IsUnicode(false)
                 .HasColumnName("enviarmensajesemail");
                entity.Property(e => e.EnviarMensajesCel)
                 .IsRequired()
                 .HasColumnType("int")
                 .IsUnicode(false)
                 .HasColumnName("enviarmensajescel");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
