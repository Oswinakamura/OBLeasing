using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OBLeasing.Web.Data.Entities
{
    public class Contract
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [Display(Name = "Está Observaciones")]
        public string Remarks { get; set; }

        [Display(Name = "Precio")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal Price { get; set; }

        [Display(Name = "Fecha de inicio")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }

        [Display(Name = "Fecha de finalización")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime EndDate { get; set; }

        [Display(Name = "Está Activo?")]
        public bool IsActive { get; set; }

        public Property Property { get; set; }
        public Owner Owner { get; set; }
        public Lessee Lessee { get; set; }



    }
}
