using Microsoft.EntityFrameworkCore;
using Tarea5Lab.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea5Lab.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Productos> Productos {get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            optionsBuilder.UseSqlite(@"Data Source = Productos.db");
        }
    }
}