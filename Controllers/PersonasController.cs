using Microsoft.AspNetCore.Mvc;
using WEB_API.Models;
using WEBAPI.Database;
namespace WEB_API.Controllers
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
        public IActionResult Index()
        {
            return View();
        }
    }
}
