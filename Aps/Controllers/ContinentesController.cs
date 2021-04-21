using Aps.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Aps.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContinentesController : ControllerBase
    {
        private readonly ContinentesRepo _repo;
        public ContinentesController(ContinentesRepo repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<ActionResult<dynamic>> GetAll()
        {
            var resp = await _repo.GetContinentes();
            return Ok(resp);
        }

        [HttpGet("{continenteId}")]
        public async Task<ActionResult<dynamic>> GetAll(int continenteId)
        {
            var resp = await _repo.GetContinenteById(continenteId);
            return Ok(resp);
        }
    }
}
