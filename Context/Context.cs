using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Entities;

namespace Context
{

    public partial class Context : DbContext
    {
        public Context()
            : base("name=Context")
        {
        }

        public virtual DbSet<Lugares> Lugares { get; set; }
        public virtual DbSet<Parqueaderos> Parqueaderos { get; set; }
        public virtual DbSet<Reservas> Reservas { get; set; }
        public virtual DbSet<Sedes> Sedes { get; set; }
        public virtual DbSet<TipoDocumentos> TipoDocumentos { get; set; }
        public virtual DbSet<TipoUsuarios> TipoUsuarios { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Lugares>()
                .Property(e => e.lugID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Lugares>()
                .Property(e => e.parkID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Lugares>()
                .Property(e => e.lug_nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Lugares>()
                .Property(e => e.lug_estado)
                .IsUnicode(false);

            modelBuilder.Entity<Parqueaderos>()
                .Property(e => e.parkID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Parqueaderos>()
                .Property(e => e.sedID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Parqueaderos>()
                .Property(e => e.park_nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Parqueaderos>()
                .Property(e => e.park_estado)
                .IsUnicode(false);

            modelBuilder.Entity<Reservas>()
                .Property(e => e.resID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Reservas>()
                .Property(e => e.lugID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Reservas>()
                .Property(e => e.usuID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Reservas>()
                .Property(e => e.res_estado)
                .IsUnicode(false);

            modelBuilder.Entity<Sedes>()
                .Property(e => e.sedID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Sedes>()
                .Property(e => e.sed_nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Sedes>()
                .Property(e => e.sed_direccion)
                .IsUnicode(false);

            modelBuilder.Entity<Sedes>()
                .Property(e => e.sed_latitud)
                .IsUnicode(false);

            modelBuilder.Entity<Sedes>()
                .Property(e => e.sed_longitud)
                .IsUnicode(false);

            modelBuilder.Entity<Sedes>()
                .Property(e => e.sed_estado)
                .IsUnicode(false);

            modelBuilder.Entity<TipoDocumentos>()
                .Property(e => e.tipDocID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TipoDocumentos>()
                .Property(e => e.tipDoc_nombre)
                .IsUnicode(false);

            modelBuilder.Entity<TipoDocumentos>()
                .Property(e => e.tipDoc_estado)
                .IsUnicode(false);

            modelBuilder.Entity<TipoUsuarios>()
                .Property(e => e.tipoUsuID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TipoUsuarios>()
                .Property(e => e.tipoUsu_nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios>()
                .Property(e => e.usuID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Usuarios>()
                .Property(e => e.tipoUsuID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Usuarios>()
                .Property(e => e.tipDocID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Usuarios>()
                .Property(e => e.usu_nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios>()
                .Property(e => e.usu_num_doc)
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios>()
                .Property(e => e.usu_estado)
                .IsUnicode(false);
        }
    }
}
