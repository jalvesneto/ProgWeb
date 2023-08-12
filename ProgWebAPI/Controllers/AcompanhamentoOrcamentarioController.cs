using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProgWeb.Infra.Repositories.Interface;

namespace ProgWebAPI.Controllers
{
    /// <summary>
    /// Controller para buscar dados do DataSet de 
    /// Acompanhamento Orçamentário.
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class AcompanhamentoOrcamentarioController : ControllerBase
    {
        private readonly IAcompanhamentoOrcamentarioRepository _repository;
        public AcompanhamentoOrcamentarioController(IAcompanhamentoOrcamentarioRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("HealthCheck")]
        public IActionResult HealthCheck()
        {
            return Ok("Estou vivo!");
        }

        [HttpGet("ObterTodos")]
        public IActionResult GetModel(
            int page = 1,
            string? funcao="",
            string? subFuncao="",
            string? acao="",
            string? orgao="",
            string? tituloPrograma="",
            string? tipoPrograma="",
            string? localizador="",
            string? unidadeOrcamentaria = ""
            )
        {
            return Ok(_repository.GetObjects(
                            page,
                            funcao,
                            subFuncao,
                            acao,
                            orgao,
                            tituloPrograma,
                            tipoPrograma,
                            localizador,
                            unidadeOrcamentaria
                        ));
        }

        [HttpGet("ObterValores")]
        public IActionResult GetValues(
            string? funcao = "",
            string? subFuncao = "",
            string? acao = "",
            string? orgao = "",
            string? tituloPrograma = "",
            string? tipoPrograma = "",
            string? localizador = "",
            string? unidadeOrcamentaria = ""
            )
        {
            return Ok(_repository.GetValues(
                            funcao,
                            subFuncao,
                            acao,
                            orgao,
                            tituloPrograma,
                            tipoPrograma,
                            localizador,
                            unidadeOrcamentaria
                        ));
        }
    }
}
