using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TCCWebApi.Data.Interfaces;
using TCCWebApi.Models;

namespace TCCWebApi.Data.Services
{
    public class RepositorioIngredienteProduto : IRepositorioIngredienteProduto
    {
        private readonly Context _context;
        public RepositorioIngredienteProduto(Context context)
        {
            this._context = context;
        }
        public async Task<IngredienteProduto[]> ObterTodos()
        {
            IQueryable<IngredienteProduto> consulta = _context.IngredienteProduto;

            consulta = consulta.AsNoTracking().OrderBy(i => i.Id);

            return await consulta.ToArrayAsync();
        }
        public async Task<IngredienteProduto> ObterPeloId(int ingrediente_produtoId)
        {
            IQueryable<IngredienteProduto> consulta = _context.IngredienteProduto;

            consulta = consulta.AsNoTracking()
                               .OrderBy(i => i.Id)
                               .Where(i => i.Id == ingrediente_produtoId);
                               
            return await consulta.FirstOrDefaultAsync();
        }

        public async Task<IngredienteProduto[]> ObterPeloProdutoId(int produtoId)
        {
            IQueryable<IngredienteProduto> consulta = _context.IngredienteProduto;

            consulta = consulta.AsNoTracking()
                               .OrderBy(i => i.ProdutoId)
                               .Where(i => i.ProdutoId == produtoId);
                               
            return await consulta.ToArrayAsync();
        }
        public async Task<IngredienteProduto> ObterPeloIngredienteId(int ingredienteId)
        {
            IQueryable<IngredienteProduto> consulta = _context.IngredienteProduto;

            consulta = consulta.AsNoTracking()
                               .OrderBy(i => i.IngredienteId)
                               .Where(i => i.IngredienteId == ingredienteId);
                               
            return await consulta.FirstOrDefaultAsync();
        }
    }
}