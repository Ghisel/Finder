

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Finder.Models
{
    public class Zona
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdZona { get; set; }
        [Required]
        public string Nombre { get; set; }
        
        
    }
    
}