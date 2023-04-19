using System.ComponentModel.DataAnnotations;

namespace BlazorApp2.Shared.Models
{
    public class ContactoDTO
    {
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Name
        {
            get; set;
        }

        public string Surname
        {
            get; set;
        }
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "Debes indicar un email válido")]
        public string Email
        {
            get; set;
        }
        [Required(ErrorMessage = "El mensaje es obligatorio")]
        public string Message
        {
            get; set;
        }
    }
}
