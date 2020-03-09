using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Soccer.Web.Models
{
    public class EditUserViewModel
    {
        public int Id { get; set; }

        [Display(Name = "RFC")]
        [MaxLength(20, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string RFC { get; set; }

        [Display(Name = "Nombre")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string FirstName { get; set; }

        [Display(Name = "Apellidos")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string LastName { get; set; }

        [Display(Name = "Dirección")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres.")]
        public string Address { get; set; }

        [Display(Name = "Teléfono")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres.")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Imagen")]
        public IFormFile PictureFile { get; set; }

        [Display(Name = "Imagen")]
        public string PicturePath { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [Display(Name = "Equipo favorito")]
        [Range(1, int.MaxValue, ErrorMessage = "Debe seleccionar un equipo.")]
        public int TeamId { get; set; }

        public IEnumerable<SelectListItem> Teams { get; set; }
    }
}
