using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ProgWeb.Infra.Repositories.Interface;

namespace ProgWebAPI.Controllers
{
    [Route("Consultas")]
    public class ConsultasController : Controller
    {
        private readonly IAcompanhamentoOrcamentarioRepository _repository;
        public ConsultasController(IAcompanhamentoOrcamentarioRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("{NrQuestao}")]
        public IActionResult Index(int NrQuestao = 1)
        {
            switch (NrQuestao)
            {
                case 1:
                    return Ok(_repository.SelectSumWhereInQ1(new List<int>() { 10,12 }));
                case 2:
                    return Ok(_repository.SelectSumWhereInQ2("Assistência Médica e Odontológica aos Servidores Civis, Empregados, Militares e seus Dependentes", "Gestao e Manutencao", "HOSPITAIS"));
                case 3:
                    return Ok(_repository.SelectSumWhereInQ3(new List<string>() { "Agricultura" }));
                case 4:
                    return Ok(_repository.SelectSumWhereInQ4("Educacao", "Ensino Superior", "Sergipe"));
                case 5:
                    return Ok(_repository.SelectSumWhereInQ5("Saude", "Sergipe"));
                case 6:
                    return Ok(_repository.SelectSumQ6());
                case 7:
                    return Ok(_repository.SelectSumQ7(1));
                case 8:
                    return Ok(_repository.SelectSumQ8(new List<string>() { "Instituto Federal de Sergipe", "Fundacao Universidade Federal de Sergipe" }));
                case 9:
                    return Ok(_repository.SelectSumWhereInQ9("Tribunal Regional Federal da 1a. Região", "Justiça Federal"));
                case 10:
                    return Ok(_repository.SelectSumQ10());
                default:
                    return NoContent();
            }

        }
    }
}
