using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ConsultaVeterinario.Models;

namespace ConsultaVeterinario.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Dados entrada)
        {
            if (entrada.Email.Equals("teste@teste.com") && entrada.Password.Equals("teste"))
            {
                return RedirectToAction("Usuario");
            } else if (entrada.Email.Equals("admin@admin.com") && entrada.Password.Equals("admin"))
            {
                return RedirectToAction("Administrador");
            } else 
            { 
            return View();
            }
        }

        public ActionResult Consulta(Guid id)
        {
            var dados = new DBService().BuscaPorId(id);
            return View(dados);
        }
        [HttpPost]
        public ActionResult Consulta(Dados entradas)
        {
            new DBService().Alterar(entradas);
            return RedirectToAction("Usuario");
        }

        [HttpGet]
        public ActionResult Cadastro()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Cadastro(Dados entrada)
        {
            new DBService().Cadastrar(entrada);
            return RedirectToAction("Index");
        }

        public ActionResult Administrador()
        {
            var obj = new DBService().Listar().OrderBy(x => x.DataHora).ToList();
            return View(obj);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
