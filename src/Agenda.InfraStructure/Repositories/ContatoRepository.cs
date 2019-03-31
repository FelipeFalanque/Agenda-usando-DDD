using Agenda.ApplicationCore.Entities;
using Agenda.ApplicationCore.Interfaces.Repositories;
using Agenda.InfraStructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Agenda.InfraStructure.Repositories
{
    public class ContatoRepository : EFRepository<Contato>, IContatoRepository
    {
        public ContatoRepository(Contexto context) : base(context)
        { }

        public Contexto InfraContext
        {
            get { return _contexto as Contexto; }
        }
    }
}
