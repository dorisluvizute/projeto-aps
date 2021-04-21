using Aps.Data;
using Aps.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Aps.Repositories
{
    public class PaisesRepo
    {
        private readonly Context _context;
        public PaisesRepo(Context context)
        {
            _context = context;
        }

        public async Task<List<Pais>> GetPaises()
        {
            var resp = await _context.Paises.ToListAsync();
            return resp;
        }

        public async Task<Pais> GetPaisById(int paisId)
        {
            var resp = await _context.Paises.FindAsync(paisId);
            return resp;
        }
    }
}
