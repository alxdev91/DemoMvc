using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoMvc.Models;

namespace DemoMvc.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona
        public ActionResult Index()
        {
            Persona persona = new Persona();
            persona.Name = "Alex";
            persona.Edad = 27;
            persona.Id = 1127;
            persona.Genero = "H";
            return View(persona);
        }
    }
}