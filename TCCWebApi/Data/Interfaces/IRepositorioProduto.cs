using System.Threading.Tasks;
using TCCWebApi.Models;

namespace TCCWebApi.Data.Interfaces
{
    public interface IRepositorioProduto
    {
        Task<Produto[]> ObterTodos();
        Task<Produto> ObterPelaDescricao(string descricao);
        Task<Produto> ObterPeloId(int produtoId);
    }
}