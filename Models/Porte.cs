using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Finder.Models
{
    public class Porte
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPorte { get; set; }
        [Required]
        public string Nombre { get; set; }
        
        
    }
}