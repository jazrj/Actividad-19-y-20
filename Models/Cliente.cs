using System.ComponentModel.DataAnnotations;

namespace Floreria.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es requerido")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "El apellido es requerido")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string? Apellido { get; set; }

        [Required(ErrorMessage = "La dirección es requerida")]
        [StringLength(250, ErrorMessage = "Máximo 250 caracteres")]
        public string? Direccion { get; set; }

        [Required(ErrorMessage = "El teléfono es requerido")]
        [StringLength(10, ErrorMessage = "Máximo 10 caracteres")]
        public string? Telefono { get; set; }

        [Required(ErrorMessage = "El correo es requerido")]
        [EmailAddress(ErrorMessage = "Debe ingresar un correo válido")]
        [StringLength(50, ErrorMessage = "Máximo 50 caracteres")]
        public string? Correo { get; set; }
    }
}
