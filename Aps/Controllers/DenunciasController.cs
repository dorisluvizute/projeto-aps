using Aps.Models;
using Aps.Models.api;
using Aps.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aps.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DenunciasController : ControllerBase
    {
        private readonly DenunciasRepo _repo;
        public DenunciasController(DenunciasRepo repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<ActionResult<dynamic>> GetAll()
        {
            var resp = await _repo.GetDenuncias();
            return Ok(resp);
        }

        [HttpGet("{denunciaId}")]
        public async Task<ActionResult<dynamic>> GetAll(int denunciaId)
        {
            var resp = await _repo.GetDenunciaById(denunciaId);
            return Ok(resp);
        }

        [HttpPost]
        public async Task<ActionResult<dynamic>> Create(DenunciaForm denuncia)
        {
            var resp = await _repo.CreateDenuncia(denuncia);
            return Ok(resp);
        }
    }
}
