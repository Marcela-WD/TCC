using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TCCWebApi.Data.Interfaces;
using TCCWebApi.Models;

namespace TCCWebApi.Data.Services
{
    public class RepositorioModoPreparo : IRepositorioModoPreparo
    {
        private readonly Context _context;
        public RepositorioModoPreparo(Context context)
        {
            this._context = context;
        }
        public async Task<ModoPreparo[]> ObterTodos()
        {
            IQueryable<ModoPreparo> consulta = _context.ModoPreparo;

            consulta = consulta.AsNoTracking().OrderBy(i => i.Id);

            return await consulta.ToArrayAsync();
        }
        public async Task<ModoPreparo> ObterPeloId(int modoPreparoId)
        {
            IQueryable<ModoPreparo> consulta = _context.ModoPreparo;

            consulta = consulta.AsNoTracking()
                               .OrderBy(i => i.Id)
                               .Where(i => i.Id == modoPreparoId);

            return await consulta.FirstOrDefaultAsync();
        }
        public async Task<ModoPreparo[]> ObterPelaDescricao(string descricao)
        {
            IQueryable<ModoPreparo> consulta = _context.ModoPreparo;

            consulta = consulta.AsNoTracking()
                               .OrderBy(i => i.Descricao)
                               .Where(i => i.Descricao.Contains(descricao));

            return await consulta.ToArrayAsync();
        }
    }
}