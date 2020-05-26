using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC_25_05_20.Models;

namespace MVC_25_05_20.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MinhaPagina()
        {
            return View();
        }

        public IActionResult ListarProduto()
        {
            List<produto> listaProduto = new List<produto>();
            
            produto smartphone = new produto();
            smartphone.CodigoProduto = 1;
            smartphone.NomeProduto = "IPhone";
            listaProduto.Add(smartphone);

            produto tv = new produto();
            tv.CodigoProduto = 2;
            tv.NomeProduto = "LG Bk";
            listaProduto.Add(tv);

            produto carro = new produto(){
                CodigoProduto = 3,
                NomeProduto = "Ferrari"
            };
            listaProduto.Add(carro);

            return View(listaProduto);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
