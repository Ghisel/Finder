using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Finder.Models;
using Finder.Data;

namespace Finder.Controllers
{
    public class EnAdopcionController : PublicacionesController
    {

        public EnAdopcionController(ApplicationDbContext context) : base(context)
        {
        }
        // public IActionResult Publicaciones()
        // {
        //     return View();
        // }
        // public IActionResult Detalles()
        // {
        //     return View();
        // }
        // public IActionResult Crear()
        // {
        //     return View();
        // }
        // public IActionResult Editar()
        // {
        //     return View();
        // }
        // public IActionResult Eliminar()
        // {
        //     return View();
        // }
    }
}
