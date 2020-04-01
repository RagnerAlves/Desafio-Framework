using Desafio_Framework.DbEntities;
using Desafio_Framework.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Desafio_Framework.Controllers
{
    public class EstadoController : Controller
    {
        private CRUDContext context;

        public EstadoController(CRUDContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            IEnumerable<EstadoViewModel> model = context.Set<Estado>().ToList().Select(b => new EstadoViewModel
            {
                Id = b.Id,
                Descricao = b.Descricao,
                Pais = b.Pais
            });
            return View("Index", model);
        }


        [HttpGet]
        public IActionResult AddEditEstado(long? id)
        {
            EstadoViewModel model = new EstadoViewModel();
            if (id.HasValue)
            {
                Estado estado = context.Set<Estado>().SingleOrDefault(c => c.Id == id.Value);
                if (estado != null)
                {
                    model.Id = estado.Id;
                    model.Descricao = estado.Descricao;
                    model.Pais = estado.Pais;
                }
            }
            return PartialView("~/Views/Estado/_AddEditEstado.cshtml", model);
        }

        [HttpPost]
        public IActionResult AddEditEstado(long? id, EstadoViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    bool isNew = !id.HasValue;
                    Estado estado = isNew ? new Estado
                    {
                    } : context.Set<Estado>().SingleOrDefault(s => s.Id == id.Value);
                    
                    estado.Descricao = model.Descricao;
                    estado.Pais = model.Pais;

                    if (isNew)
                    {
                        context.Add(estado);
                    }
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DeleteEstado(long id)
        {
            Estado estado = context.Set<Estado>().SingleOrDefault(c => c.Id == id);
            string estadoName = estado.Pais;
            return PartialView("~/Views/Estado/_DeleteEstado.cshtml", model: estadoName);
        }
        [HttpPost]
        public IActionResult DeleteEstado(long id, IFormCollection form)
        {
            Estado estado = context.Set<Estado>().SingleOrDefault(c => c.Id == id);
            context.Entry(estado).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
