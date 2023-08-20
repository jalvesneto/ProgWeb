using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProgWeb.Domain.Entities;
using ProgWeb.Infra.Repositories.Interface;

namespace ProgWebAPI.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    //[Authorize]
    public class LocalizacaoController : ControllerBase
    {
        private readonly ILocalizacaoRepository _localizacaoRepository;

        public LocalizacaoController(ILocalizacaoRepository localizacaoRepository)
        {
            _localizacaoRepository = localizacaoRepository;
        }

        [HttpPost("Adicionar")]
        public IActionResult CriarLocalizacao(Localizacao localizacao)
        {
            try
            {
                var Localizacao = _localizacaoRepository.RegistrarOuAtualizarLocalizacao(localizacao);
                if (Localizacao != null) { return Ok("Localizacao registrada com sucesso!"); }
                else return BadRequest("Algo deu errado ao salvar a localizacao");
            }
            catch (Exception ex)
            {
                return new ObjectResult(ex.InnerException?.Message ?? ex.Message) { StatusCode = 500 };
            }

        }

        /// <summary>
        /// Endpoint para obter a lista de localizações
        /// </summary>
        /// <param name="clauseGroup">1 - Cidade | 2 - Estado | 3 - Pais</param>
        /// <param name="order">1 - Descrescente | 2 - Crescente</param>
        /// <returns></returns>
        [HttpGet("Obter")]
        public IActionResult ObterLocalizacoes()
        {
            try
            {
                var localizacoes = _localizacaoRepository.ObterListaLocalizacoes();
                if (localizacoes != null) { return Ok(localizacoes); }
                else return NoContent();
            }
            catch (Exception ex)
            {
                return new ObjectResult(ex.InnerException?.Message ?? ex.Message) { StatusCode = 500 };
            }

        }

    }
}
