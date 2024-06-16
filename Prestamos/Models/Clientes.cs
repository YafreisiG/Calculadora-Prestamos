using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Prestamos.Models
{
    public class Clientes
    {
        [Key]
        public int Id { get; set; }

        [Required (ErrorMessage ="El campo {0} es requerido")]
        [StringLength (70)]
        public string Nombre { get; set; }
       
        [Required (ErrorMessage = "El campo {0} es requerido")]
        [StringLength (100)]

        public string Apellidos { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(100)]

        public string Dirección { get; set; }

        public virtual ICollection <Prestamo>Prestamos { get; set; }

    }
}