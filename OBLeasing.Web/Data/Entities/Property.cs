using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OBLeasing.Web.Data.Entities
{
    public class Property
    {
            public int Id { get; set; }

            [Display(Name = "Barrio")]
            [MaxLength(50, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres.")]
            [Required(ErrorMessage = "El campo {0} es obligatorio.")]
            [Column(TypeName = "varchar(30)")]
        public string Neighborhood { get; set; }

            [Display(Name = "Direccion")]
            [MaxLength(50, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres.")]
            [Required(ErrorMessage = "El campo {0} es obligatorio.")]
            [Column(TypeName = "varchar(30)")]  
        public string Address { get; set; }

            [Display(Name = "Precio")]
            [Required(ErrorMessage = "El campo {0} es obligatorio.")]
            [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
            public decimal Price { get; set; }

            [Display(Name = "Metros cuadrados")]
            [Required(ErrorMessage = "El campo {0} es obligatorio..")]
            public int SquareMeters { get; set; }

            [Display(Name = "Habitaciones")]
            [Required(ErrorMessage = "El campo {0} es obligatorio..")]
            public int Rooms { get; set; }

            [Display(Name = "Estrato")]
            [Required(ErrorMessage = "El campo {0} es obligatorio.")]
            public int Stratum { get; set; }

            [Display(Name = "Parqueadero?")]
            public bool HasParkingLot { get; set; }

            [Display(Name = "Está disponible?")]
            public bool IsAvailable { get; set; }

            [Display(Name = "Está Observaciones")] 
            public string Remarks { get; set; }

            public PropertyType PropertyType { get; set; }

            public Owner Owner { get; set; }
            public ICollection<PropertyImage> PropertyImages { get; set; }
            public ICollection<Contract> Contracts { get; set; }
    }


    }

