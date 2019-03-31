using Agenda.ApplicationCore.Entities;
using Agenda.InfraStructure.EntitiesConfiguration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Agenda.InfraStructure.Data
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        { }

        public DbSet<Contato> Contatos { get; set; }

        //fluente API
        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Configurações de Tabelas
            builder.ApplyConfiguration(new ContatoMap());
        }
    }
}
