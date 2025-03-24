using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Persona>>> GetPersonas()
        {
            return await _context.Personas.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Persona>> GetPersona(int id)
        {
            var persona = await _context.Personas.FindAsync(id);

            if (persona == null)
            {
                return NotFound();
            }

            return persona;
        }

        [HttpPost]
        public async Task<ActionResult<Persona>> CreatePersona(Persona persona)
        {
            persona.FechaAdiccion = DateTime.Now;
            _context.Personas.Add(persona);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetPersona), new { id = persona.Id }, persona);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePersona(int id, Persona persona)
        {
            if (id != persona.Id)
            {
                return BadRequest();
            }

            var personaExistente = await _context.Personas.FindAsync(id);

            if (personaExistente == null)
            {
                return NotFound();
            }

            // Update existing properties
            personaExistente.Nombres = persona.Nombres;
            personaExistente.Apellidos = persona.Apellidos;
            personaExistente.Email = persona.Email;
            personaExistente.FechaNacimiento = persona.FechaNacimiento;
            personaExistente.Telefono = persona.Telefono;

            // Update audit fields
            personaExistente.ModificadoPor = persona.ModificadoPor;
            personaExistente.FechaModificacion = DateTime.Now;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PersonaExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePersona(int id)
        {
            var persona = await _context.Personas.FindAsync(id);
            if (persona == null)
            {
                return NotFound();
            }

            _context.Personas.Remove(persona);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PersonaExists(int id)
        {
            return _context.Personas.Any(e => e.Id == id);
        }








        public IActionResult Index()
        {
            return View();
        }
    }
}
