using Finder.Data;
using Microsoft.AspNetCore.Mvc;

namespace Finder.Controllers
{
    public class PerdidosController : PublicacionesController
    {
        public PerdidosController(ApplicationDbContext context) : base(context)
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
