using Desafio_Framework.DbEntities;
using Desafio_Framework.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Desafio_Framework.Controllers
{
    public class PacienteController : Controller
    {
        private CRUDContext context;

        public PacienteController(CRUDContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            IEnumerable<PacienteViewModel> model = context.Set<Paciente>().ToList().Select(b => new PacienteViewModel
            {
                Id = b.Id,
                Nome = b.Nome,
                CPF = b.CPF,
                Pais = b.Pais,
                Estado = b.Estado,
                Cidade = b.Cidade
            });
            return View("Index", model);
        }


        [HttpGet]
        public IActionResult AddEditPaciente(long? id)
        {
            PacienteViewModel model = new PacienteViewModel();
            if (id.HasValue)
            {
                Paciente paciente = context.Set<Paciente>().SingleOrDefault(c => c.Id == id.Value);
                if (paciente != null)
                {
                    model.Id = paciente.Id;
                    model.Nome = paciente.Nome;
                    model.CPF = paciente.CPF;
                    model.Pais = paciente.Pais;
                    model.Estado = paciente.Estado;
                    model.Cidade = paciente.Cidade;
                }
            }
            return PartialView("~/Views/Paciente/_AddEditPaciente.cshtml", model);
        }

        [HttpPost]
        public IActionResult AddEditPaciente(long? id, PacienteViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    bool isNew = !id.HasValue;
                    Paciente paciente = isNew ? new Paciente
                    {
                    } : context.Set<Paciente>().SingleOrDefault(s => s.Id == id.Value);
                    paciente.Nome = model.Nome;
                    paciente.CPF = model.CPF;
                    paciente.Pais = model.Pais;
                    paciente.Estado = model.Estado;
                    paciente.Cidade = model.Cidade;
                    if (isNew)
                    {
                        context.Add(paciente);
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
        public IActionResult DeletePaciente(long id)
        {
            Paciente paciente = context.Set<Paciente>().SingleOrDefault(c => c.Id == id);
            string pacienteName = paciente.Nome;
            return PartialView("~/Views/Paciente/_DeletePaciente.cshtml", model: pacienteName);
        }
        [HttpPost]
        public IActionResult DeletePaciente(long id, IFormCollection form)
        {
            Paciente paciente = context.Set<Paciente>().SingleOrDefault(c => c.Id == id);
            context.Entry(paciente).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
