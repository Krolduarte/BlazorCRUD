using System.ComponentModel.DataAnnotations;

namespace BlazorApp2.Shared.Models
{
    public class Persona
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo Nombre es requerido")]
        public string Nombre { get; set; }
    }
}
