using Aps.Models;
using Microsoft.EntityFrameworkCore;

namespace Aps.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
            : base(options)
        { }

        public DbSet<Pais> Paises { get; set; }
        public DbSet<Denuncia> Denuncias { get; set; }
        public DbSet<Continente> Continentes { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
