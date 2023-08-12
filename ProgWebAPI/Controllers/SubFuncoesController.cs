using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProgWeb.Infra.Repositories.Interface;

namespace ProgWebAPI.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    [Authorize]
    public class SubFuncoesController: ControllerBase {

        private readonly ISubFuncaoRepository _repository;

        public SubFuncoesController(ISubFuncaoRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("HealthCheck")]
        public IActionResult HealthCheck()
        {
            return Ok("Estou vivo!");
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll() { 
            return Ok(_repository.GetAllSubFuncoes());
        }


    }
}