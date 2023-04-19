using BlazorApp2.Shared.Models;

namespace BlazorApp2.Server.Repositories
{
    public class PersonaRepository : IPersonaRepository
    {
        private readonly ApplicationDbContext _context;

        public PersonaRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Persona> ActualizarPersona(int id, Persona persona)
        {

            var personaDesdeDb = await _context.Personas.FindAsync(id);

            personaDesdeDb.Nombre = persona.Nombre;
            personaDesdeDb.Apellido = persona.Apellido;
            personaDesdeDb.Email = persona.Email;
            personaDesdeDb.Descripcion = persona.Descripcion;
            personaDesdeDb.BirthDate = persona.BirthDate;
            personaDesdeDb.TeamId = persona.TeamId;
            personaDesdeDb.RolId = persona.RolId;
            personaDesdeDb.IsReadyToWork = persona.IsReadyToWork;


            await _context.SaveChangesAsync();

            return personaDesdeDb;

        }
        public async Task<Persona> CrearPersona(Persona persona)
        {
            if (persona is not null)
            {
                await _context.Personas.AddAsync(persona);
                await _context.SaveChangesAsync();
                return persona;

            }
        }

        public Task EliminarPersona(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Persona> GetPersonaId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Persona>> GetPersonas()
        {
            throw new NotImplementedException();
        }
    }
