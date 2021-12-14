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
    public class LeidyController : Controller
    {
        public IActionResult Index()
        {
        Leidy leidy = new Leidy();
            leidy.nombre = "Ena leidye Santos Ramirez ";
            leidy.sexo = "Femenino";
            leidy.direccion = " Colonia Francisco Gavidia.";
            leidy.ciudad = "San Miguel";
            leidy.correo = "enaleidysantosramirez0@gmail.com ";
            leidy.telefono ="7050 3696 ";
            leidy.carrera ="Técnico en ingeniería en sistemas y redes informáticas";
            leidy.edad=23;
            leidy.info= "Me considero una buena  persona y estudiante, comprensiva, dedicada y responsable. Soy dedicada a mi carrera ya que me gusta mucho el mundo de la tecnología porque podre mejorar y utilizar el pesamiento lógico para resolver problemas complejos también  comprender y desarrollar sistemas informáticos.";
            return View(leidy);
        }
    }
}