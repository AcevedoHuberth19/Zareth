using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zareth.Models.Zareth
{
    public class TipoProducto
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Nombre")]
        public string Nombre { get; set; }
        [Required]
        [DisplayName("Descripcion")]
        public string Descripcion {  get; set; }

        public virtual ICollection<Producto> Productos { get; set; }

    }
}
