using System.Threading.Tasks;
using TCCWebApi.Models;

namespace TCCWebApi.Data.Interfaces
{
    public interface IRepositorioModoPreparo
    {
        Task<ModoPreparo[]> ObterTodos();
        Task<ModoPreparo> ObterPeloId(int modoPreparoId);
        Task<ModoPreparo[]> ObterPelaDescricao(string descricao);

    }
}