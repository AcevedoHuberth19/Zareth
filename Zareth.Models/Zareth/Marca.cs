using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zareth.Models.Zareth
{
    public class Marca
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Codigo { get; set; }
        [Required]
        [DisplayName("Nombre de la Marca")]
        public string Nombre { get; set; }

        public virtual ICollection<Laboratorio> Laboratorios { get; set; }
    }
}
