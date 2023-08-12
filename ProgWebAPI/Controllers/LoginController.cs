using Microsoft.AspNetCore.Mvc;
using ProgWeb.Application.Services.Abstract;
using ProgWeb.Domain.Dtos.Login;

namespace ProgWebAPI.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class LoginController : ControllerBase
    {
        private readonly ILoginService _loginService;
        public LoginController(ILoginService loginService)
        {
            _loginService = loginService;
        }

        [HttpPost]
        public IActionResult RealizarLogin([FromBody] LoginDto login)
        {
            try
            {
                LoginResponseDto retorno = new LoginResponseDto();

                var token = _loginService.Login(login.UsernameOrEmail, login.Senha) ?? throw new ArgumentException("Usuario ou senha invalidos.");

                retorno.Success = true;
                retorno.Mensagem = "Usuario Logado com sucesso.";
                retorno.Token = token;
                retorno.ExpiresIn = DateTime.Now.AddMinutes(30);

                return Ok(retorno);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception) 
            {
                return StatusCode(500, "Ocorreu um error ao autenticar o usuário!");
            }
        }
    }
}
