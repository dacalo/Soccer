using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Soccer.Web.Data.Entities
{
    public class TournamentEntity
    {
        public int Id { get; set; }

        [Display(Name = "Nombre")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Name { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Fecha de Inicio")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = false)]
        public DateTime StartDate { get; set; }

        [Display(Name = "Fecha de Inicio")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = false)]
        public DateTime StartDateLocal => StartDate.ToLocalTime();

        [DataType(DataType.DateTime)]
        [Display(Name = "Fecha de Término")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = false)]
        public DateTime EndDate { get; set; }

        [Display(Name = "Fecha de Término")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = false)]
        public DateTime EndDateLocal => EndDate.ToLocalTime();

        [Display(Name = "Está Activo?")]
        public bool IsActive { get; set; }

        [Display(Name = "Logo")]
        public string LogoPath { get; set; }

        public ICollection<GroupEntity> Groups { get; set; }
    }
}
