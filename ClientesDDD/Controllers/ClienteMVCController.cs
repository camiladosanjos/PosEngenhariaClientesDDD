using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClientesDDD.Dominio.Entidades;
using ClientesDDD.Infra.Dados.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClientesDDD.Controllers
{
    public class ClienteMVCController : Controller
    {
        private readonly IClienteApp _clienteApp;

        public ClienteMVCController(IClienteApp clienteApp)
        {
            _clienteApp = clienteApp;
        }

        // GET: ClienteMVC
        public ActionResult Index()
        {
            return View(_clienteApp.Listar());
        }

        // GET: ClienteMVC/Details/5
        public ActionResult Details(Guid id)
        {
            return View(_clienteApp.RecuperarPorId(id));
        }

        // GET: ClienteMVC/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClienteMVC/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Cliente cliente)
        {
            try
            {
                cliente.Id = Guid.NewGuid();
                _clienteApp.Adicionar(cliente);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return View();
            }
        }

        // GET: ClienteMVC/Edit/5
        public ActionResult Edit(Guid id)
        {
            return View(_clienteApp.RecuperarPorId(id));
        }

        // POST: ClienteMVC/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Cliente cliente)
        {
            try
            {
                // TODO: Add update logic here
                _clienteApp.Atualizar(cliente);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }

        }

        // GET: ClienteMVC/Delete/5
        public ActionResult Delete(Guid id)
        {
            return View(_clienteApp.RecuperarPorId(id));
        }

        // POST: ClienteMVC/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Cliente cliente)
        {
            try
            {
                // TODO: Add delete logic here
                _clienteApp.Excluir(cliente);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}