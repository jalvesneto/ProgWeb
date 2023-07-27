using System.ComponentModel.DataAnnotations;

namespace ProgWeb.Domain.Dtos
{
    public class AddUsuarioDto
    {
        public string UserName { get; set; }
        [EmailAddress(ErrorMessage = "Insira um endereçod e e-mail válido.")]
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
