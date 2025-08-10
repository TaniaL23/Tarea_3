using System.ComponentModel.DataAnnotations;

namespace Tarea_3.Models
{
    public class ProductoModel
    {
        [Required(ErrorMessage = "El nombre del producto es obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El tipo de mascota es obligatorio")]
        public string TipoMascota { get; set; } // Perro, Gato, etc.

        [Range(0.01, 10000, ErrorMessage = "El precio debe ser mayor a 0")]
        public decimal Precio { get; set; }

        public string Descripcion { get; set; }
    }
}
