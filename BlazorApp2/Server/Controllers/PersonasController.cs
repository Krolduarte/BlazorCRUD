using BlazorApp2.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlazorApp2.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]



    public class PersonasController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public PersonasController(ApplicationDbContext context)
        {
            this.context = context;
        }


        // GET: api/<PersonasController>
        [HttpGet]
        public async Task<ActionResult<List<Persona>>> Get()
        {
            return await context.Personas.ToListAsync();
        }

        //// GET api/<PersonasController>/5
        [HttpGet("{id}", Name = "obtenerPersona")]
        public async Task<ActionResult<Persona>> Get(int id)
        {
            return await context.Personas.FirstOrDefaultAsync(x => x.Id == id);
        }

        // POST api/<PersonasController>
        [HttpPost]
        public async Task<ActionResult> Post(Persona persona)
        {
            context.Add(persona);
            await context.SaveChangesAsync();
            return new CreatedAtRouteResult("obtenerPersona", new { id = persona.Id }, persona);

        }

        // PUT api/<PersonasController>/5
        [HttpPut]
        public async Task<ActionResult> Put(Persona persona)
        {
            context.Entry(persona).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return NoContent();

        }

        // DELETE api/<PersonasController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var persona = new Persona { Id = id };
            context.Remove(persona);
            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}
