using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Web_API.Controllers;
using Web_API.Database;
using Web_API.Models;

namespace Web_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonasController : Controller
    {
        private readonly AppDbContext _context;

        public PersonasController(AppDbContext context)
        {
            _context = context;
        }
    }
}
