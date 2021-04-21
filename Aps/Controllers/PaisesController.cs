using Aps.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Aps.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PaisesController : ControllerBase
    {
        private readonly PaisesRepo _repo;
        public PaisesController(PaisesRepo repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<ActionResult<dynamic>> GetAll()
        {
            var resp = await _repo.GetPaises();
            return Ok(resp);
        }

        [HttpGet("{paisId}")]
        public async Task<ActionResult<dynamic>> GetAll(int paisId)
        {
            var resp = await _repo.GetPaisById(paisId);
            return Ok(resp);
        }
    }
}
