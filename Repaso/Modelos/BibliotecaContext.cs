using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Repaso.Modelos;   

namespace Repaso.Modelos
{
    public class BibliotecaContext : DbContext
    {

        public BibliotecaContext(DbContextOptions<BibliotecaContext> options) : base(options)
        {

        }

        public DbSet<libro> libros { get; set; }
        public DbSet<autor> autores { get; set; } 
        public DbSet<categoria> categorias { get; set; }
    }
}
