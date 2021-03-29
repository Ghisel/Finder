using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Finder.Models
{
    public  class  Usuario
    {   
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdUsuario { get; set; }
        [Required]
        public string Nombre { get; set; }
        
        [Required]
        public string Apellido { get; set; }
        
        [Required]
        public string Email { get; set; }
        
        [Required]
        public int Telefono { get; set; }
        
        

    }
}