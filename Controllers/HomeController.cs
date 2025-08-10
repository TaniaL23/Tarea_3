using Microsoft.AspNetCore.Mvc;
using Tarea_3.Models;

namespace Tarea_3.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            // Retornamos un modelo vacío para el formulario
            return View(new MascotaModel());
        }

        [HttpPost]
        public IActionResult Index(MascotaModel mascota)
        {
            if (ModelState.IsValid)
            {
                // Mensaje de confirmación si todo es válido
                ViewBag.Mensaje = $"✅ Gracias {mascota.Nombre} por registrar a tu {mascota.Tipo} de {mascota.Edad} años.";
            }
            else
            {
                ViewBag.Mensaje = null; // No mostramos mensaje si hay errores
            }

            // Retornamos el modelo para mantener los datos escritos en el formulario
            return View(mascota);
        }
    }
}
