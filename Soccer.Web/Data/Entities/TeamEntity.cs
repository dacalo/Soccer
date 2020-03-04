using Soccer.Common.Helpers;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Soccer.Web.Data.Entities
{
    public class TeamEntity
    {
        public int Id { get; set; }
        
        [Display(Name = "Nombre")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Name { get; set; }
        
        [Display(Name = "Logo")]
        public string LogoPath { get; set; }

        [Display(Name = "Logo")]
        public string LogoFullPath => string.IsNullOrEmpty(LogoPath)
            ? Constants.Path.PathNoImage
            : Constants.URL_BASE + LogoPath.Substring(1);
        //public string LogoFullPath => string.IsNullOrEmpty(LogoPath)
        //    ? "https://SoccerWeb0.azurewebsites.net//images/noimage.png"
        //    : $"https://SoccerWeb0.azurewebsites.net{LogoPath.Substring(1)}";

        public ICollection<GroupDetailEntity> GroupDetails { get; set; }
        public ICollection<UserEntity> Users { get; set; }
    }
}
