using System.Threading.Tasks;
using TCCWebApi.Models;

namespace TCCWebApi.Data.Interfaces
{
    public interface IRepositorioIngredienteProduto
    {
        Task<IngredienteProduto[]> ObterTodos();
        Task<IngredienteProduto> ObterPeloId(int ingrediente_produtoId);
        Task<IngredienteProduto[]> ObterPeloProdutoId(int produtoId);
        Task<IngredienteProduto> ObterPeloIngredienteId(int ingredienteId);
        
    }
}