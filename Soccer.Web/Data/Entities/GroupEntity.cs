using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Soccer.Web.Data.Entities
{
    public class GroupEntity
    {
        public int Id { get; set; }

        [Display(Name = "Nombre")]
        [MaxLength(30, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Name { get; set; }

        public TournamentEntity Tournament { get; set; }
        public ICollection<GroupDetailEntity> GroupDetails { get; set; }
        public ICollection<MatchEntity> Matches { get; set; }
    }
}
