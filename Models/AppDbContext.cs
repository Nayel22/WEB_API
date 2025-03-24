using System;
using System.Collections.Generic;
using WEB_API.Models;
using Microsoft.EntityFrameworkCore;

namespace WEBAPI.Database
{
    public class AppContext : DbContext
    {
        public AppContext(DbContextOptions<AppContext> options) : base(options) { }

        public DbSet<Persona> Personas { get; set; }
    }
}