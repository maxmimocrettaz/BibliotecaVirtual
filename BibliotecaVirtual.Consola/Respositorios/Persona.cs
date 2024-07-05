using BibliotecaVirtual.Model;

namespace  BibliotecaVirtual.Repositorio
{
    internal class Persona<Persona>
    {
        public ObtenerPorNombre(String nombre)
        {
            using (AppDbContext context = new AppDbContext())
            {
                persona = context.Set<Persona>().Where(x => x.Nombre == nombre).First();
            }

            return persona
        }
    }
}