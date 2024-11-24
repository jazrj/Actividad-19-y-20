using System.ComponentModel.DataAnnotations;

namespace Floreria.Models
{
    public class Producto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es requerido")]
        [StringLength(250, ErrorMessage = "Máximo 250 caracteres")]
        public string? NombreProducto { get; set; }

        [Required(ErrorMessage = "El tipo de producto es requerido")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string? TipoProducto { get; set; }

        [Required(ErrorMessage = "La descripción es requerida")]
        [StringLength(1000, ErrorMessage = "Máximo 1000 caracteres")]
        public string? Descripcion { get; set; }

        [Required(ErrorMessage = "El precio es requerido")]
        [Range(0.01, 1000000, ErrorMessage = "El precio debe ser entre 0.01 y 1,000,000")]
        public double? Precio { get; set; }
    }
}
