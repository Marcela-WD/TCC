using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TCCWebApi.Data.Interfaces;
using TCCWebApi.Models;

namespace TCCWebApi.Data.Services
{
    public class RepositorioProduto : IRepositorioProduto
    {
        private readonly Context _context;
        public RepositorioProduto(Context context)
        {
            this._context = context;
        }

        public async Task<Produto[]> ObterTodos()
        {
            IQueryable<Produto> consulta = _context.Produto;

            consulta = consulta.AsNoTracking().OrderBy(i => i.Id);

            return await consulta.ToArrayAsync();
        }

        public async Task<Produto> ObterPelaDescricao(string descricao)
        {
            IQueryable<Produto> consulta = _context.Produto;

            consulta = consulta.AsNoTracking()
                               .OrderBy(i => i.Descricao)
                               .Where(i => i.Descricao.Contains(descricao));

            return await consulta.FirstOrDefaultAsync();
        }
        public async Task<Produto> ObterPeloId(int produtoId)
        {
            IQueryable<Produto> consulta = _context.Produto;

            consulta = consulta.AsNoTracking()
                               .OrderBy(i => i.Descricao)
                               .Where(i => i.Id == produtoId);

            return await consulta.FirstOrDefaultAsync();
        }
    }
}