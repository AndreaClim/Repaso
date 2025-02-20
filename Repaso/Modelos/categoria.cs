using System.ComponentModel.DataAnnotations;
namespace Repaso.Modelos
{
    public class categoria
    {
        [Key]
        public int categoriaId { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
    }
}
