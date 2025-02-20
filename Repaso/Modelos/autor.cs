using System.ComponentModel.DataAnnotations;
namespace Repaso.Modelos;

public class autor
{
    [Key]
    public int autorId { get; set; }
    public string nombre { get; set; }
    public string nacionalidad { get; set; }
}

