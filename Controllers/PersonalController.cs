using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MiPrimeraAplicacionWebASP.Models;

namespace MiPrimeraAplicacionWebASP.Controllers
{
    public class PersonalController : Controller
    {
        public IActionResult Index()
        {
        Personal personal = new Personal();
        personal.nombre="Nehemias Isaí Arias Fuentes";
        personal.correo="isaifuentes2017@gmail.com";
        personal.celular="7754-1747";
        personal.direccion="Colonia Romero, El Triunfo, Usulután";
        personal.pais="El Salvador";
        return View(personal);
        }
    }
}