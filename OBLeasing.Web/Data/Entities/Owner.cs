using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OBLeasing.Web.Data.Entities
{
    public class Owner
    {
        public int Id { get; set; }

        [Display(Name = "Documento")]
        [MaxLength(20, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [Column(TypeName = "varchar(20)")]
        public string Document { get; set; }

        [Display(Name = "Nombre")]
        [MaxLength(30, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [Column(TypeName = "varchar(30)")]
        public string FirstName { get; set; }

        [Display(Name = "Apellido")]
        [MaxLength(30, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [Column(TypeName = "varchar(30)")]
        public string LastName { get; set; }

        [Display(Name = "Fijo")]
        [MaxLength(10, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres.")]
        [Column(TypeName = "varchar(10)")]
        public string FixedPhone { get; set; }

        [Display(Name = "Celular")]
        [MaxLength(10, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres.")]
        [Column(TypeName = "varchar(15)")]
        public string CellPhone { get; set; }

        [Display(Name = "Direccion")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Column(TypeName = "varchar(50)")]
        public string Address { get; set; }

        [Display(Name = "Nombre Completo")]
        public string FullName => $"{FirstName} {LastName}";
        public string FullNameWithDocument => $"{FirstName} {LastName} - {Document}";

        public ICollection<Property> Properties { get; set; }

        public ICollection<Contract> Contracts { get; set; }


    }
}
