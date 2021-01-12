using System.Threading.Tasks;

namespace TCCWebApi.Data.Services.Interfaces
{
    public interface IRepositorio 
    {
        void Adicionar<A>(A entidade) where A : class;
        void Atualizar<A>(A entidade) where A : class;
        void Deletar<A>(A entidade) where A : class;
        Task<bool> EfetuouAlteracoesAssincronas();
    }
}