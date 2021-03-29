using System;
using System.Collections.Generic;
using System.Text;
using Finder.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Finder.Data
{
    public class ApplicationDbContext : IdentityDbContext<Usuario>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Edad> Edades { get; set; }
        public DbSet<Especie> Especies { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Porte> Portes { get; set; }
        public DbSet<Publicacion> Publicaciones { get; set; }
        public DbSet<Raza> Razas { get; set; }
        public DbSet<Zona> Zonas { get; set; }
        
        
        
        
        
        
        
        
        
        
        
    }
}
