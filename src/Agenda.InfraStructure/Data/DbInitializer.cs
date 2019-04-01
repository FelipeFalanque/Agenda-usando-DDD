using Agenda.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Agenda.InfraStructure.Data
{
    public static class DbInitializer
    {
        public static void Initialize(Contexto context)
        {
            if (context.Contatos.Any())
            {
                return;
            }

            var contatos = new Contato[]
            {
                new Contato()
                {
                    Nome = "Cesar Oliveira Falanque",
                    Telefone = "19999996633",
                },
                new Contato()
                {
                    Nome = "Felipe Oliveira Falanque",
                    Telefone = "19999996644",
                },
                new Contato()
                {
                    Nome = "Felipe Falanque",
                    Telefone = "19999556644",
                },
                new Contato()
                {
                    Nome = "Oliveira Falanque",
                    Telefone = "19997796644",
                }
            };

            context.Contatos.AddRange(contatos);

            context.SaveChanges();
        }
    }
}
