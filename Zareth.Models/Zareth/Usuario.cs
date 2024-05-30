using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zareth.Models.Zareth
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Codigo { get; set; }
        [Required]
        [DisplayName]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "La contraseña es obligatoria.")]
        [DisplayName("Contraseña")]
        [DataType(DataType.Password)]
        public string Contraseña { get; set; }
    }
}
