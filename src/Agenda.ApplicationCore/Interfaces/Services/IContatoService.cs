using Agenda.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Agenda.ApplicationCore.Interfaces.Services
{
    public interface IContatoService
    {
        Contato Get(int? id);
        IEnumerable<Contato> GetAll();
        IEnumerable<Contato> Find(Expression<Func<Contato, bool>> predicate);

        void Add(Contato entity);
        void AddRange(IEnumerable<Contato> entities);

        void Remove(Contato entity);
        void RemoveRange(IEnumerable<Contato> entities);

        void Update(Contato entity);
    }
}
