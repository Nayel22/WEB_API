using System;
using System.Collections.Generic;
using WEB_API.Models;
using Microsoft.EntityFrameworkCore;

namespace WEBAPI.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Persona> Personas { get; set; }
    }
}