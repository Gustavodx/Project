using Microsoft.AspNetCore.Mvc;

namespace ProyectoWeb.Controllers
{
    public class VistasController : Controller
    {
        public IActionResult Main()
        {
            return View();
        }

        public IActionResult Preguntas()
        {
            return View();
        }

        public IActionResult Nosotros()
        {
            return View();
        }


    }
}
