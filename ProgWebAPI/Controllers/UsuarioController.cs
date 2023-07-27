using Microsoft.AspNetCore.Mvc;
using ProgWeb.Domain.Dtos;
using ProgWeb.Domain.Entities;
using ProgWeb.Infra.Repositories.Interface;
using System.Diagnostics.Metrics;
using System.Net;

namespace ProgWebAPI.Controllers
{
    [ApiController]
    [Route("[Controller]")]
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
