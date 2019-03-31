using Agenda.ApplicationCore.Entities;
using Agenda.ApplicationCore.Interfaces.Services;
using Agenda.ApplicationCore.Interfaces.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Agenda.ApplicationCore.Services
{
    public class ContatoService : IContatoService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ContatoService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Add(Contato entity)
        {
            //TODO: Adicioinar regras de negocio aqui

            _unitOfWork.Contatos.Add(entity);
            _unitOfWork.Commit();
        }

        public void AddRange(IEnumerable<Contato> entities)
        {
            _unitOfWork.Contatos.AddRange(entities);
            _unitOfWork.Commit();
        }

        public IEnumerable<Contato> Find(Expression<Func<Contato, bool>> predicate)
        {
            return _unitOfWork.Contatos.Find(predicate);
        }

        public Contato Get(int? id)
        {
            return _unitOfWork.Contatos.Get(id);
        }

        public IEnumerable<Contato> GetAll()
        {
            return _unitOfWork.Contatos.GetAll();
        }

        public void Remove(Contato entity)
        {
            _unitOfWork.Contatos.Remove(entity);
            _unitOfWork.Commit();
        }

        public void RemoveRange(IEnumerable<Contato> entities)
        {
            _unitOfWork.Contatos.RemoveRange(entities);
        }

        public void Update(Contato entity)
        {
            _unitOfWork.Contatos.Update(entity);
            _unitOfWork.Commit();
        }
    }
}
