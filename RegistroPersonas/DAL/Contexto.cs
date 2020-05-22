using Microsoft.EntityFrameworkCore;
using RegistroPersonas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroPersonas.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Personas> personas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data source = DATA\RegistroPersonas.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Personas>().HasData(new Personas
            {
                PersonaId = 1,
                Nombre = "Nombre",
                Telefono = "8092831232",
                Cedula = "0000000000000",
                Direccion = "Duarte, RD",
                Nacimiento = DateTime.Now
            });
        }
        
    }

}
