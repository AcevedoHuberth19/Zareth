using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zareth.Models.Zareth
{
    public class Laboratorio
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Codigo { get; set; }
        [Required]
        [DisplayName("Nombre del Laboratorio")]
        public string Nombre { get; set; }
        [Required]
        [DisplayName("Direccion del Laboratorio")]
        public string Direccion {  get; set; }
        [Required]
        [DisplayName("Telefono Laboratorio")]
        public string Telefono { get; set; }

        public int MarcaId { get; set; }

        public virtual Marca Marca { get; set; }

        public virtual ICollection<Producto> Productos { get; set; }
    }
}
