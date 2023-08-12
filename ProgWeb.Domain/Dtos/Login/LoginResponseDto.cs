namespace ProgWeb.Domain.Dtos.Login
{
    public class LoginResponseDto
    {
        public bool Success { get; set; }
        public string Mensagem { get; set; }
        public string Token { get; set; }
        public DateTime ExpiresIn { get; set; }
    }
}
