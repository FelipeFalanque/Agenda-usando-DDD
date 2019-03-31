using Agenda.ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Agenda.InfraStructure.EntitiesConfiguration
{
    public class ContatoMap : IEntityTypeConfiguration<Contato>
    {
        public void Configure(EntityTypeBuilder<Contato> contato)
        {
            #region Configuração tabela Contatos

            // Nome da Tabela no BD
            contato.ToTable("Contatos");
            // chave primaria contato
            contato.HasKey(c => c.ContatoId);
            // Limite Campo Nome
            contato.Property(c => c.Nome).HasMaxLength(250).IsRequired(true);
            // Limite Campo Telefone
            contato.Property(c => c.Telefone).HasMaxLength(20);

            #endregion
        }
    }
}
