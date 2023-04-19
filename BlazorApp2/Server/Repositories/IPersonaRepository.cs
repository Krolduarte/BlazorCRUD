using BlazorApp2.Shared.Models;

namespace BlazorApp2.Server.Repositories
{
    public interface IPersonaRepository
    {

        public Task<List<Persona>> GetPersonas();
        public Task<Persona> GetPersonaId(int id);

        public Task<Persona> CrearPersona(Persona persona);

        public Task<Persona> ActualizarPersona(int id, Persona persona);

        public Task EliminarPersona(int id);

    }
}
