using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zareth.Models.Zareth
{
    [Table("Proveedor", Schema = "Zareth")]
    public class Proveedor
    {
        public Proveedor()
        {
            this.Compras = new HashSet<Compra>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public int Codigo { get; set; }

        [Required]
        [DisplayName("Nombre del Proveedor")]
        public string Nombre { get; set; }

        [Required]
        [DisplayName("RUC")]
        public int Ruc { get; set; }

        [Required]
        [DisplayName("Teléfono")]
        public string Telefono { get; set; }

        [Required]
        [DisplayName("Dirección")]
        public string Direccion { get; set; }

        public virtual ICollection<Compra> Compras { get; set; }
    }
}