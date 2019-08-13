using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OBLeasing.Web.Data.Entities
{
    public class PropertyType
    {
        public int Id { get; set; }

        [Display(Name = "Tipo de propiedad")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [Column(TypeName = "varchar(50)")]
        public string Name { get; set; }

        public ICollection<Property> Properties { get; set; }

    }
}
