using DiarioPressao.Models;
using System.Linq;
using System.Web.Mvc;

namespace DiarioPressao.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(new DataBase().Listar().OrderByDescending(x => x.Data).ToList());
        }
        [HttpGet]
        public ActionResult Adicionar()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        [HttpPost]
        public ActionResult Adicionar(EntradaDTO entrada)
        {
            new DataBase().Inserir(entrada);
            return RedirectToAction("Index");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}