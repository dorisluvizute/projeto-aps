using Aps.Models.api;
using Aps.Repositories;
using Aps.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Aps.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : Controller
    {
        private readonly UsuariosRepo _repo;
        private readonly JwtService _jwtService;
        public UsuariosController(UsuariosRepo repo, JwtService jwtService)
        {
            _repo = repo;
            _jwtService = jwtService;
        }

        //Rota de login e geração do token
        [HttpPost("login")]
        public async Task<ActionResult<dynamic>> LogIn([FromBody] LogIn model)
        {
            try
            {
                var user = await _repo.ValidateLogIn(model.Email, model.Password);

                if (user == null) { return NotFound(new { message = "Usuário ou senha inválidos." }); }

                var token = _jwtService.GenerateToken(user);
                return new
                {
                    token = token
                };
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        //Rota de criação de usuários
        [HttpPost("signup")]
        public async Task<ActionResult<dynamic>> SignUp([FromBody] UsuarioForm user)
        {
            try
            {
                var resp = await _repo.Create(user);

                return Ok(resp);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
