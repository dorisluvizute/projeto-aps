using Aps.Data;
using Aps.Models;
using Aps.Models.api;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Aps.Repositories
{
    public class DenunciasRepo
    {
        private readonly Context _context;
        public DenunciasRepo(Context context)
        {
            _context = context;
        }

        public async Task<List<Denuncia>> GetDenuncias()
        {
            var resp = await _context.Denuncias.ToListAsync();
            return resp;
        }

        public async Task<Denuncia> GetDenunciaById(int denunciaId)
        {
            var resp = await _context.Denuncias.FindAsync(denunciaId);
            return resp;
        }

        public async Task<dynamic> CreateDenuncia(DenunciaForm denunciaForm)
        {
            var denuncia = new Denuncia(denunciaForm.TextoDenuncia, denunciaForm.PaisId, DateTime.Now, denunciaForm.ContinenteId);

            await _context.Denuncias.AddAsync(denuncia);
            _context.SaveChanges();

            return denuncia;
        }

        public async Task<dynamic> DeleteDenuncia(int denunciaId)
        {
            var resp = await _context.Denuncias.FindAsync(denunciaId);
            _context.Denuncias.Remove(resp);

            await _context.SaveChangesAsync();

            return "Denuncia excluída.";
        }
    }
}
