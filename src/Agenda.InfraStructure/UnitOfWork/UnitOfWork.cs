using Agenda.ApplicationCore.Interfaces.Repositories;
using Agenda.ApplicationCore.Interfaces.UnitOfWork;
using Agenda.InfraStructure.Data;
using Agenda.InfraStructure.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Agenda.InfraStructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly Contexto _context;

        public UnitOfWork(Contexto context)
        {
            _context = context;

            // Inicia os repositorys
            Contatos = new ContatoRepository(_context);
        }

        // Add os repositorys
        public IContatoRepository Contatos { get; private set; }

        public int Commit()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
