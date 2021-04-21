using Aps.Data;
using Aps.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aps.Repositories
{
    public class ContinentesRepo
    {
        private readonly Context _context;
        public ContinentesRepo(Context context)
        {
            _context = context;
        }

        public async Task<List<Continente>> GetContinentes()
        {
            var resp = await _context.Continentes.Include("Paises").ToListAsync();
            return resp;
        }

        public async Task<Continente> GetContinenteById(int continenteId)
        {
            var resp = await _context.Continentes.Where(c => c.Id == continenteId).Include("Paises").FirstOrDefaultAsync();
            return resp;
        }
    }
}
