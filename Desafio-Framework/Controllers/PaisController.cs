using Desafio_Framework.DbEntities;
using Desafio_Framework.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Desafio_Framework.Controllers
{
    public class PaisController : Controller
    {
        private CRUDContext context;

        public PaisController(CRUDContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            IEnumerable<PaisViewModel> model = context.Set<Pais>().ToList().Select(b => new PaisViewModel
            {
                Id = b.Id,
                Descricao = b.Descricao                
            });
            return View("Index", model);
        }


        [HttpGet]
        public IActionResult AddEditPais(long? id)
        {
            PaisViewModel model = new PaisViewModel();
            if (id.HasValue)
            {
                Pais pais = context.Set<Pais>().SingleOrDefault(c => c.Id == id.Value);
                if (pais != null)
                {
                    model.Id = pais.Id;
                    model.Descricao = pais.Descricao;                    
                }
            }
            return PartialView("~/Views/Pais/_AddEditPais.cshtml", model);
        }

        [HttpPost]
        public IActionResult AddEditPais(long? id, PaisViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    bool isNew = !id.HasValue;
                    Pais pais = isNew ? new Pais
                    {
                    } : context.Set<Pais>().SingleOrDefault(s => s.Id == id.Value);
                    
                    pais.Descricao = model.Descricao;                    

                    if (isNew)
                    {
                        context.Add(pais);
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
        public IActionResult DeletePais(long id)
        {
            Pais pais = context.Set<Pais>().SingleOrDefault(c => c.Id == id);
            string paisName = pais.Descricao;
            return PartialView("~/Views/Pais/_DeletePais.cshtml", model: paisName);
        }
        [HttpPost]
        public IActionResult DeletePais(long id, IFormCollection form)
        {
            Pais pais = context.Set<Pais>().SingleOrDefault(c => c.Id == id);
            context.Entry(pais).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
