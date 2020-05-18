using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using Soccer.Common.Enums;
using System.Collections.Generic;
using System.Linq;
using Soccer.Common.Helpers;

namespace Soccer.Web.Data.Entities
{
    public class UserEntity : IdentityUser
    {
        [MaxLength(20, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string RFC { get; set; }

        [Display(Name = "Nombre")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string FirstName { get; set; }

        [Display(Name = "Apellidos")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string LastName { get; set; }

        [Display(Name = "Domicilio")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres.")]
        public string Address { get; set; }

        [Display(Name = "Imagen")]
        public string PicturePath { get; set; }

        [Display(Name = "Imagen")]
        public string PictureFullPath => string.IsNullOrEmpty(PicturePath)
        ? Constants.Path.PathNoImage
        : Constants.URL_BASE + PicturePath.Substring(1);
            
        [Display(Name = "Tipo de Usuario")]
        public UserType UserType { get; set; }

        [Display(Name = "Tipo de Inicio de Sesión")]
        public LoginType LoginType { get; set; }

        [Display(Name = "Nombre Completo")]
        public string FullName => $"{FirstName} {LastName}";

        [Display(Name = "Nombre Completo con RFC")]
        public string FullNameWithRFC => $"{FirstName} {LastName} - {RFC}";

        [Display(Name = "Puntos")]
        public int Points => Predictions == null ? 0 : Predictions.Sum(p => p.Points);

        [Display(Name = "Equipo Favorito")]
        public TeamEntity Team { get; set; }

        public ICollection<PredictionEntity> Predictions { get; set; }
    }
}
