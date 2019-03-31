using Agenda.ApplicationCore.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Agenda.ApplicationCore.Interfaces.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        // Add Aqui as IEntityRepository Entity { get; }

        IContatoRepository Contatos { get; }

        int Commit();
    }
}
