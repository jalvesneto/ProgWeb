using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProgWeb.Infra.Repositories.Interface;

namespace ProgWebAPI.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    [Authorize]
    public class OrgaoController : ControllerBase
    {

        private readonly IOrgaoRepository _repository;

        public OrgaoController(IOrgaoRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("HealthCheck")]
        public IActionResult HealthCheck()
        {
            return Ok("Estou vivo!");
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(_repository.Getall());
        }


    }
}