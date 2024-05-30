using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
a
namespace Zareth.Models.Zareth
{
    public class Compra
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Codigo { get; set; }
        [Required]
        [DisplayName("Fecha de Compra")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true,DataFormatString ="{0:dd/mm/yyyy}")]
        public DateTime FechaDeCompra { get; set; }
        [Required]
        [DisplayName("Total de Compra")]
        public double totalCompra { get; set; }
        [DisplayName("Observacion")]
        public string observacionCompra { get; set; }

        public int ProveedorId {  get; set; }
        public int ProductoId { get; set; }

        public virtual Proveedor Proveedor { get; set; }
        public virtual Producto Producto { get; set; }
        


    }
}
