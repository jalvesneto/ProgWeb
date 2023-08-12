using System.ComponentModel.DataAnnotations;

namespace ProgWeb.Domain.Dtos.Login
{
    public class LoginDto
    {
        [Required(ErrorMessage = "O campo UsernameOrEmail é obrigatório", AllowEmptyStrings = false)]
        public string UsernameOrEmail { get; set; }
        [Required(ErrorMessage = "O campo Senha é obrigatório", AllowEmptyStrings = false)]
        public string Senha { get; set; }
    }
}
