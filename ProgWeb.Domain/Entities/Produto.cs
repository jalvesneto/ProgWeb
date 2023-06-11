using System.ComponentModel.DataAnnotations;

namespace ProgWeb.Domain.Entities
{
    public class Produto
    {
        [Key]
        public int Codigo { get; set; }
        public string Descricao { get; set; }
    }
}
