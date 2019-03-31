using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Agenda.ApplicationCore.Services;
using Agenda.InfraStructure.Data;
using Agenda.InfraStructure.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace Agenda.WebSite.Controllers
{
    public class ContatosServicesController : Controller
    {
        // Tentativa com service
        private readonly ContatoService _contatoService;
        public ContatosServicesController(ContatoService contatoService) { _contatoService = contatoService; }
        public IActionResult Index() { return View(_contatoService.GetAll()); }

        // Tentativa com UnitOfWork
        //private readonly UnitOfWork _unitOfWork;
        //public ContatosServicesController(UnitOfWork unitOfWork) { _unitOfWork = unitOfWork; }
        //public IActionResult Index() { return View(_unitOfWork.Contatos.GetAll()); }

        // Tentatica com Contexto
        //private readonly Contexto _contexto;
        //public ContatosServicesController(Contexto contexto) { _contexto = contexto; }
        //public IActionResult Index() { return View(_contexto.Contatos); }
    }
}