using Data;
using Data.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PressaoDiario.Models;
using System;
using System.Diagnostics;
using System.Linq;
using System.Net.Mail;

namespace PressaoDiario.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        [HttpGet]
        public ActionResult Adicionar()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        [HttpPost]
        public ActionResult Adicionar(Pressao entrada)
        {
            new DBPressaoService().Inserir(entrada);
            return RedirectToAction("Index");
        }

        public ActionResult Excluir(Guid id)
        {
            new DBPressaoService().Excluir(id);
            return RedirectToAction("Index");
        }

        public ActionResult Editar(Guid id)
        {
            var dados = new DBPressaoService().BuscaPorId(id);
            return View(dados);
        }

        [HttpPost]
        public ActionResult Editar(Pressao entradas)
        {
            new DBPressaoService().Alterar(entradas);
            return RedirectToAction("Index");
        }

        public ActionResult EnviarEmail()
        {
            return View();
        }
        [HttpPost]
        public ViewResult EnviarEmail(Data.DTOs.Email obj)
        {
            if (ModelState.IsValid)
            {
                try
                {// string nomeDestinatario, string emailDestinatario, string assunto, string texto
                    Helper.EnviarEmail("Abacaxi", obj.Para, "Relatório", obj.Titulo);

                } catch(Exception ex)
                {

                }
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Index()
        {
            var obj = new DBPressaoService().Listar().OrderBy(x => x.Periodo).OrderByDescending(x => x.Data).ToList();
            return View(obj);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
