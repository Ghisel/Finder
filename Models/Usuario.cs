using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace Finder.Models
{
    public class Usuario : IdentityUser
    {
        public string Nombre { get; set; }

        public string Apellido { get; set; }
    }
}