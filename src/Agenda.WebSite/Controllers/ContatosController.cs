using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Agenda.ApplicationCore.Entities;
using Agenda.InfraStructure.Data;
using Agenda.ApplicationCore.Interfaces.Services;

namespace Agenda.WebSite.Controllers
{
    public class ContatosController : Controller
    {
        private readonly IContatoService _contatoService;

        public ContatosController(IContatoService contatoService)
        {
            _contatoService = contatoService;
        }

        // GET: Contatos
        public IActionResult Index()
        {
            return View(_contatoService.GetAll());
        }

        // GET: Contatos/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contato = _contatoService.Get(id);
            if (contato == null)
            {
                return NotFound();
            }

            return View(contato);
        }

        // GET: Contatos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Contatos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("ContatoId,Nome,Telefone")] Contato contato)
        {
            if (ModelState.IsValid)
            {
                _contatoService.Add(contato);
                return RedirectToAction(nameof(Index));
            }
            return View(contato);
        }

        // GET: Contatos/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contato = _contatoService.Get(id);
            if (contato == null)
            {
                return NotFound();
            }
            return View(contato);
        }

        // POST: Contatos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("ContatoId,Nome,Telefone")] Contato contato)
        {
            if (id != contato.ContatoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _contatoService.Update(contato);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContatoExists(contato.ContatoId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(contato);
        }

        // GET: Contatos/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contato = _contatoService.Get(id);
            if (contato == null)
            {
                return NotFound();
            }

            return View(contato);
        }

        // POST: Contatos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var contato = _contatoService.Get(id);
            _contatoService.Remove(contato);
            return RedirectToAction(nameof(Index));
        }

        private bool ContatoExists(int id)
        {
            return _contatoService.Get(id) != null;
        }
    }
}
