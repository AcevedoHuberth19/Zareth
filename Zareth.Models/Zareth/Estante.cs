using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zareth.Models.Zareth
{
    public class Estante
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Codigo { get; set; }
        
        
    }
}
