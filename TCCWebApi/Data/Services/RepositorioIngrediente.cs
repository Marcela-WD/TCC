using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TCCWebApi.Data.Interfaces;
using TCCWebApi.Models;

namespace TCCWebApi.Data.Services
{
    public class RepositorioIngrediente : IRepositorioIngrediente
    {
        private readonly Context _context;
        public RepositorioIngrediente(Context context)
        {
            this._context = context;

        }

        public bool ExistePelaDescricao(string descricaoIngrediente)
        {
            var ingredienteCadastrado = ObterPelaDescricao(descricaoIngrediente);

            return ingredienteCadastrado != null;
        }

        public async Task<Ingrediente> ObterPelaDescricao(string descricaoIngrediente)
        {
           IQueryable<Ingrediente> consulta = _context.Ingrediente;

            consulta = consulta.AsNoTracking()
                               .OrderBy(i => i.Descricao)
                               .Where(i => i.Descricao == descricaoIngrediente);
                            // .Where(i => String.Equals(i.Descricao, descricaoIngrediente, StringComparison.OrdinalIgnoreCase));
                            //    String.Equals(row.Name, "test", StringComparison.OrdinalIgnoreCase)
            //select i.* from ingrediente as i where i.descricao = 'leite'

            return await consulta.FirstOrDefaultAsync();
        }

        public async Task<Ingrediente> ObterPeloId(int ingredienteId)
        {
            IQueryable<Ingrediente> consulta = _context.Ingrediente;

            consulta = consulta.AsNoTracking()
                               .OrderBy(i => i.Descricao)
                               .Where(i => i.Id == ingredienteId);

            return await consulta.FirstOrDefaultAsync();
        }

        public async Task<Ingrediente[]> ObterTodos()
        {
            IQueryable<Ingrediente> consulta = _context.Ingrediente;

            consulta = consulta.AsNoTracking().OrderBy(i => i.Id);

            return await consulta.ToArrayAsync();
        }
    }
}