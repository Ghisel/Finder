using System.Linq;
using Finder.Data;
using Finder.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Finder.Controllers
{
    public class PublicacionesController : Controller
    {
        private readonly ApplicationDbContext Context;
        public PublicacionesController(ApplicationDbContext context)
        {
            Context = context;
        }
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
            ViewBag.EspecieId = new SelectList(Context.Especies, "IdEspecie", "Nombre");
            return View(new Publicacion());
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
