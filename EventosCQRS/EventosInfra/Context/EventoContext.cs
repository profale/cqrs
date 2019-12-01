using EventosDomain.Entities;
using EventosInfra.Properties;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventosInfra.Context
{
    public class EventoContext : DbContext
    {
        public DbSet<Evento> Eventos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(Resources.DbConnectionString);

        }

        public EventoContext()
        {
            Database.EnsureCreated();
        }
    }
}
