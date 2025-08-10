using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Tarea_3.Models;

namespace Tarea_3.Controllers
{
    public class MascotasController : Controller
    {
        private readonly ILogger<MascotasController> _logger;

        public MascotasController(ILogger<MascotasController> logger)
        {
            _logger = logger;
        }

        // Mostrar el formulario
        [HttpGet]
        public IActionResult Registrar()
        {
            return View();
        }

        // Procesar el formulario
        [HttpPost]
        public IActionResult Registrar(MascotaModel mascota)
        {
            if (ModelState.IsValid)
            {
                // Aquí podrías guardar la mascota en base de datos
                ViewBag.Mensaje = $"¡Gracias! La mascota {mascota.Nombre} ha sido registrada.";
                return View("Confirmacion", mascota);
            }

            return View(mascota);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
