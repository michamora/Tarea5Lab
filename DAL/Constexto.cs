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
          public Contexto(){}
        
        public Contexto(DbContextOptions<Contexto> options) : base(options){}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}