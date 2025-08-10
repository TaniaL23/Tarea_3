using Microsoft.AspNetCore.Mvc;
using Tarea_3.Models;

namespace Tarea_3.Controllers
{
    public class ProductosController : Controller
    {
        [HttpGet]
        public IActionResult NuevoProducto()
        {
            // Retornamos un modelo vacío para el formulario
            return View(new ProductoModel());
        }

        [HttpPost]
        public IActionResult NuevoProducto(ProductoModel producto)
        {
            if (ModelState.IsValid)
            {
                // Mensaje de confirmación si todo es válido
                ViewBag.Mensaje = $"✅ Producto '{producto.Nombre}' para {producto.TipoMascota} registrado correctamente. Precio: S/{producto.Precio}.";
            }
            else
            {
                ViewBag.Mensaje = null; // No mostramos mensaje si hay errores
            }

            // Retornamos el modelo para mantener los datos escritos en el formulario
            return View(producto);
        }
    }
}
