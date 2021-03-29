using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Finder.Controllers
{
    public class PublicacionesController : Controller
    {
        
        public IActionResult Publicaciones()
        {
            return View();
        }
        public IActionResult Detalles()
        {
            return View();
        }
        [Authorize]
        public IActionResult Crear()
        {
            return View();
        }
        [Authorize]
        public IActionResult Editar()
        {
            return View();
        }

        public IActionResult GetEliminar()
        {
            return View();
        }

        public IActionResult Buscar()
        {
            return View();
        }
        
    }
}
