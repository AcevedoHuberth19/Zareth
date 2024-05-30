using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zareth.Models.Zareth
{
    public class Venta
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Codigo { get; set; }
        [Required]
        [DisplayName("Fecha de Venta")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/mm/yyyy}")]
        public DateTime Fecha { get; set; }
        [Required]
        [DisplayName("Total Venta")]
        public double TotalVenta { get; set; }

        public int ProductoId { get; set;}

        public virtual Producto Producto { get; set; }
    }
}
