using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VendasWebMvc.Models;

namespace VendasWebMvc.Controllers
{
    public class DepartamentosController : Controller
    {
        public IActionResult Index()
        {
            List<Departamento> listaDepartamento = new List<Departamento>();

            listaDepartamento.Add(new Departamento { Id = 1, Name = "Eletronics" });
            listaDepartamento.Add(new Departamento { Id = 2, Name = "Fashion" });

            return View(listaDepartamento);
        }
    }
}
