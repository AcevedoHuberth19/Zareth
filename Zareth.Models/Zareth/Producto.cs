using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO.Packaging;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace Zareth.Models.Zareth
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Codigo { get; set; }
        [Required]
        [DisplayName("Nombre del Producto")]
        public string Nombre { get; set; }
        [Required]
        [DisplayName("Cantidad del Producto")]
        public int Cantidad { get; set; }
        [Required]
        [DisplayName("Estado del Producto")]
        public String Estado { get; set; }
        [DisplayName("Descripcion del Produccto")]       
        public string Descripcion { get; set; }

        public int LaboratorioId {  get; set; }
        public int TipoProductoId {  get; set; }
        public int EstanteId {  get; set; }

        public virtual Laboratorio Laboratorio { get; set; }
        public virtual TipoProducto TipoProducto { get; set; }
        public virtual Estante Estante { get; set; }


        public virtual ICollection<Compra> Compras { get; set; }
        public virtual ICollection<Venta> Ventas { get; set; }

    }
}
