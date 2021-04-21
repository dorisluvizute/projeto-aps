using Aps.Data;
using Aps.Models;
using Aps.Models.api;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Aps.Repositories
{
    public class UsuariosRepo
    {
        private readonly Context _context;
        public UsuariosRepo(Context context)
        {
            _context = context;
        }

        public async Task<dynamic> ValidateLogIn(string email, string password)
        {
            var user = await this.FindUserByEmail(email);
            if (user != null)
            {
                bool isValisPassword = BCrypt.Net.BCrypt.Verify(password, user.Password);
                if (isValisPassword)
                {
                    return user;
                }
            }
            return null;
        }

        public async Task<dynamic> Create(UsuarioForm user)
        {
            var verify = await this.FindUserByEmail(user.Email);

            if (verify == null)
            {
                user.Senha = BCrypt.Net.BCrypt.HashPassword(user.Senha);
                var usuario = new Usuario(user.Nome, user.Email, user.Senha);

                await _context.Usuarios.AddAsync(usuario);
                _context.SaveChanges();

                return new
                {
                    id = usuario.Id,
                    name = usuario.Name,
                    email = usuario.Email,
                };
            }
            else
            {
                throw new System.ArgumentException("E-mail já cadastrado.");
            }
        }

        private async Task<dynamic> FindUserByEmail(string email)
        {
            var user = await _context.Usuarios.FirstOrDefaultAsync(x => x.Email == email);
            if (user != null)
            {
                return user;
            }
            return null;
        }
    }
}
