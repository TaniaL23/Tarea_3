using Microsoft.AspNetCore.Mvc;
using Tarea_3.Models;

namespace Tarea_3.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(MascotaModel mascota)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Mensaje = $"Gracias {mascota.Nombre} por registrar a tu {mascota.Tipo} de {mascota.Edad} años.";
            }
            return View(mascota);
        }
    }
}
