using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea5LabRegistro_Con_Detalle.Entidades;

namespace Tarea5LabRegistro_Con_Detalle.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Permisos> Permisos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = DATA/datosUsuarios.Db");
        } 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Permisos>().HasData(
                new Permisos() { PermisosId = 1, DescripcionPermisos = "Descuentos" },
                new Permisos() { PermisosId = 2, DescripcionPermisos = "Vender" },
                new Permisos() { PermisosId = 3, DescripcionPermisos = "Comprar" }
            );
        }
    }
}
