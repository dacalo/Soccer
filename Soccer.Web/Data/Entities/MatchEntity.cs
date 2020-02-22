using System;
using System.ComponentModel.DataAnnotations;

namespace Soccer.Web.Data.Entities
{
    public class MatchEntity
    {
        public int Id { get; set; }

        [Display(Name = "Fecha del Partido")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}", ApplyFormatInEditMode = false)]
        public DateTime Date { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}", ApplyFormatInEditMode = false)]
        public DateTime DateLocal => Date.ToLocalTime();

        public TeamEntity Local { get; set; }

        [Display(Name = "Visitante")]
        public TeamEntity Visitor { get; set; }

        [Display(Name = "Goles de Local")]
        public int GoalsLocal { get; set; }

        [Display(Name = "Goles de Visitante")]
        public int GoalsVisitor { get; set; }

        [Display(Name = "Partido Terminado?")]
        public bool IsClosed { get; set; }

        public GroupEntity Group { get; set; }
    }
}
