using System.ComponentModel.DataAnnotations;

namespace BlazorApp2.Shared.Models
{
    public class Persona
    {
        public int Id
        {
            get; set;
        }
        [Required(ErrorMessage = "El campo Nombre es requerido")]
        public string Nombre
        {
            get; set;
        }

        //public string Image
        //{
        //    get; set;
        //}

        public string Apellido
        {
            get; set;
        }
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "Debes indicar un email válido")]
        public string Email
        {
            get; set;
        }

        public string Descripcion
        {
            get; set;
        }

        public DateTime BirthDate
        {
            get; set;
        }

        public int TeamId { get; set; } = 1;
        public int RolId { get; set; } = 1;
        public bool IsReadyToWork { get; set; } = true;
    }
}
