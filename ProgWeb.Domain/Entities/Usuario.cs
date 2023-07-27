using System.ComponentModel.DataAnnotations;

namespace ProgWeb.Domain.Entities {
    public class Usuario {

        [Key]
        public Guid IdUsuario { get; set; }
        public string UserName { get; set; }
        [EmailAddress(ErrorMessage = "Insira um endereçod e e-mail válido.")]
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}