using System.Collections.Generic;
using System.Linq;
using Finder.Data;
using Finder.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Finder.Controllers
{
    public class EspeciesController : Controller
    { 
        private readonly ApplicationDbContext Context;
        public EspeciesController(ApplicationDbContext context)
        {
            Context = context;
        }
        
        public List<Especie> GetAll()
        {
            return Context.Especies.ToList();
        }
    }
}