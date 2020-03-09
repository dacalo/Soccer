using System.ComponentModel.DataAnnotations;

namespace Soccer.Web.Models
{
    public class AddUserViewModel : EditUserViewModel
    {
        [Display(Name = "Correo")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres.")]
        [EmailAddress]
        public string Username { get; set; }

        [Display(Name = "Contraseña")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "El campo {0} debe contener entre {2} y {1} caracateres.")]
        public string Password { get; set; }

        [Display(Name = "Confirmar contraseña")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "El campo {0} debe contener entre {2} y {1} caracateres.")]
        [Compare("Password")]
        public string PasswordConfirm { get; set; }
    }
}
