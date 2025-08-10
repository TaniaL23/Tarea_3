using System.ComponentModel.DataAnnotations;

namespace Tarea_3.Models
{
    public class MascotaModel
    {
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public required string Nombre { get; set; }

        [Required(ErrorMessage = "El tipo es obligatorio")]
        public required string Tipo { get; set; }

        [Range(0, 30, ErrorMessage = "La edad debe estar entre 0 y 30")]
        public int Edad { get; set; }
    }
}
