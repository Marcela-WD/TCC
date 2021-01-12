using System.Threading.Tasks;
using TCCWebApi.Models;

namespace TCCWebApi.Data.Interfaces
{
    public interface IRepositorioIngrediente
    {
        Task<Ingrediente[]> ObterTodos();
        Task<Ingrediente> ObterPeloId(int ingredienteId);
        Task<Ingrediente> ObterPelaDescricao(string descricaoIngrediente);
        bool ExistePelaDescricao(string descricaoIngrediente);
    }
}