using Soccer.Web.Data.Entities;
using System.ComponentModel.DataAnnotations;

namespace Soccer.Web.Models
{
    public class CloseMatchViewModel
    {
        public int MatchId { get; set; }

        public int GroupId { get; set; }

        public int LocalId { get; set; }

        public int VisitorId { get; set; }

        [Display(Name = "Goles Local")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public int? GoalsLocal { get; set; }

        [Display(Name = "Goles Visitante")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public int? GoalsVisitor { get; set; }

        public GroupEntity Group { get; set; }

        public TeamEntity Local { get; set; }

        public TeamEntity Visitor { get; set; }
    }
}
