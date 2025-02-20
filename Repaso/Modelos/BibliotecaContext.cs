using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace Repaso.Modelos
{
    public class BibliotecaContext : DbContext
    {

        public BibliotecaContext(DbContextOptions<BibliotecaContext> options) : base(options)
        {

        }

        public DbSet<libros> libros { get; set; }
        public DbSet<autores> autores { get; set; } 
        public DbSet<categorias> categorias { get; set; }
    }
}
