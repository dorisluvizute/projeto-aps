using Aps.Data;
using Aps.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
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
            var resp = await _context.Paises.Include("Denuncias").ToListAsync();
            return resp;
        }

        public async Task<Pais> GetPaisById(int paisId)
        {
            var resp = await _context.Paises.Where(p => p.Id == paisId).Include("Denuncias").FirstOrDefaultAsync();
            return resp;
        }
    }
}
