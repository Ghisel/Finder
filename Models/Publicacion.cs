using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Finder.Models
{
    public class Publicacion
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public Usuario IdUsuario { get; set; }
        [Required]
        public Estado IdEstado { get; set; }
        [Required]
        public Raza IdRaza { get; set; }
        [Required]
        public Especie IdEspecie { get; set; }
        [Required]
        public Edad  IdEdad { get; set; }
        [Required]
        public Porte IdPorte { get; set; }
        [Required]
        public Zona  IdZona { get; set; }
        public List<Publicacion> Publicaciones { get; set; }    
    }
}