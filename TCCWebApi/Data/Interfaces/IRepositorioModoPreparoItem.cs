using System.Threading.Tasks;
using TCCWebApi.Models;

namespace TCCWebApi.Data.Interfaces
{
    public interface IRepositorioModoPreparoItem
    {
        Task<ModoPreparoItem[]> ObterTodos();
        Task<ModoPreparoItem[]> ObterPelaModoPreparoItemId(int modoPreparoId);
    }
}