using System.ComponentModel.DataAnnotations;

namespace ProgWeb.Domain.Entities
{
    public class Programa
    {
        [Key]
        public int Codigo { get; set; }
        public string Titulo { get; set; }
    }
}
