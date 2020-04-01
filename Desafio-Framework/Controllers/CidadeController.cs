using Desafio_Framework.DbEntities;
using Desafio_Framework.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Desafio_Framework.Controllers
{
    public class CidadeController : Controller
    {
        private CRUDContext context;

        public CidadeController(CRUDContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            IEnumerable<CidadeViewModel> model = context.Set<Cidade>().ToList().Select(b => new CidadeViewModel
            {
                Id = b.Id,
                Descricao = b.Descricao,
                Estado = b.Estado
            });
            return View("Index", model);
        }


        [HttpGet]
        public IActionResult AddEditCidade(long? id)
        {
            CidadeViewModel model = new CidadeViewModel();
            if (id.HasValue)
            {
                Cidade cidade = context.Set<Cidade>().SingleOrDefault(c => c.Id == id.Value);
                if (cidade != null)
                {
                    model.Id = cidade.Id;
                    model.Descricao = cidade.Descricao;
                    model.Estado = cidade.Estado;
                }
            }
            return PartialView("~/Views/Cidade/_AddEditCidade.cshtml", model);
        }

        [HttpPost]
        public IActionResult AddEditCidade(long? id, CidadeViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    bool isNew = !id.HasValue;
                    Cidade cidade = isNew ? new Cidade
                    {
                    } : context.Set<Cidade>().SingleOrDefault(s => s.Id == id.Value);
                    
                    cidade.Descricao = model.Descricao;
                    cidade.Estado = model.Estado;

                    if (isNew)
                    {
                        context.Add(cidade);
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

        [Route("Cidade/{id:long}")]
        public IActionResult DeleteCidade(long id)
        {
            Cidade cidade = context.Set<Cidade>().SingleOrDefault(c => c.Id == id);
            string cidadeName = cidade.Estado;
            return PartialView("~/Views/Cidade/_DeleteCidade.cshtml", model: cidadeName);
        }
        [HttpPost]
        public IActionResult DeleteCidade(long id, IFormCollection form)
        {
            Cidade cidade = context.Set<Cidade>().SingleOrDefault(c => c.Id == id);
            context.Entry(cidade).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
