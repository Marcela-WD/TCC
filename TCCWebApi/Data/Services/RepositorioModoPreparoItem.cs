using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TCCWebApi.Data.Interfaces;
using TCCWebApi.Models;

namespace TCCWebApi.Data.Services
{
    public class RepositorioModoPreparoItem : IRepositorioModoPreparoItem
    {
        private readonly Context _context;
        public RepositorioModoPreparoItem(Context context)
        {
            this._context = context;
        }
        public async Task<ModoPreparoItem[]> ObterTodos()
        {
            IQueryable<ModoPreparoItem> consulta = _context.ModoPreparoItem;

            consulta = consulta.AsNoTracking().OrderBy(i => i.Id);

            return await consulta.ToArrayAsync();
        }

        public async Task<ModoPreparoItem[]> ObterPelaModoPreparoItemId(int modoPreparoId)
        {
            IQueryable<ModoPreparoItem> consulta = _context.ModoPreparoItem;

            consulta = consulta.AsNoTracking()
                               .OrderBy(i => i.ModoPreparoId)
                               .Where(i => i.ModoPreparoId == modoPreparoId);

            return await consulta.ToArrayAsync();
        }
    }
}