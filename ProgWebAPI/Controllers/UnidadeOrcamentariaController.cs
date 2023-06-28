using Microsoft.AspNetCore.Mvc;
using ProgWeb.Domain.Entities;
using ProgWeb.Infra.DAO.Interface;
using ProgWeb.Infra.Repositories.Interface;

namespace ProgWebAPI.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class UnidadeOrcamentariaController : ControllerBase
    {

        private readonly IDAO<UnidadeOrcamentaria> _unidadeOrcamentariaDAO;

        public UnidadeOrcamentariaController(IDAO<UnidadeOrcamentaria> unidadeOrcamentariaDAO)
        {
            _unidadeOrcamentariaDAO = unidadeOrcamentariaDAO;
        }

        [HttpGet("HealthCheck")]
        public IActionResult HealthCheck()
        {
            return Ok("Estou vivo!");
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(_unidadeOrcamentariaDAO.Get().ToList());
        }


    }
}