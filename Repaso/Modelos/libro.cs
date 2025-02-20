using System.ComponentModel.DataAnnotations;

namespace Repaso.Modelos
{
    public class libro
    {
        [Key]
        public int id { get; set; }
        public string titulo { get; set; }
        public int anioPublicacion { get; set; }
        public int autorId { get; set; }
        public int categoriaId { get; set; }
        public string resumen {  get; set; }
    }
}
