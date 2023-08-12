using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProgWeb.Domain.Dtos;
using ProgWeb.Infra.Repositories.Interface;

namespace ProgWebAPI.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    [Authorize]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioController (IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        [HttpPost("Adicionar")]
        public IActionResult CriarUsuario(AddUsuarioDto usuario) 
        {
            try
            {
                var User = _usuarioRepository.RegistrarUsuario(usuario);
                if (User != null) { return Ok("Usuário registrado com sucesso!"); }
                else return BadRequest("Algo deu errado ao salvar o usuário");
            }catch (Exception ex)
            {
                return new ObjectResult(ex.InnerException.Message) { StatusCode = 500 };
            }
            
        }
    }
}
