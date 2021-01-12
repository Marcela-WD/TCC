using System.Threading.Tasks;
using TCCWebApi.Data.Services.Interfaces;

namespace TCCWebApi.Data.Services
{
    public class Repositorio : IRepositorio
    {
        private readonly Context _context;

        public Repositorio(Context context)
        {
            this._context = context;
        }
        public void Adicionar<A>(A entidade) where A : class
        {
            _context.Add(entidade);
        }

        public void Atualizar<A>(A entidade) where A : class
        {
            _context.Update(entidade);
        }

        public void Deletar<A>(A entidade) where A : class
        {
            _context.Remove(entidade);
        }

        public async Task<bool> EfetuouAlteracoesAssincronas()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }
    }
}