using Agenda.Entidades;
using Agenda.Logica;
using Agenda.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Agenda.Controllers
{
    public class PersonasController : Controller
    {
        private LogicaPersonas _logicaPersonas;

        public PersonasController()
        {
            _logicaPersonas = new LogicaPersonas();
        }

        public ActionResult Detalles(int id)
        {
            var entidadPersona = _logicaPersonas.ObtienePersona(id);
            var viewModelPersona = new PersonaViewModel
            {
                Id = entidadPersona.Id,
                Numero = entidadPersona.Numero,
                Nombre = entidadPersona.Nombre
            };
            return View(viewModelPersona);
        }

        public ActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Crear(CrearPersonaViewModel persona)
        {
            var entidadPersona = new Persona
            {
                Nombre = persona.Nombre,
                Numero = persona.Numero
            };
            _logicaPersonas.InsertaPersona(entidadPersona);
            return RedirectToAction("Detalles", new { id = entidadPersona.Id });
        }
    }
}