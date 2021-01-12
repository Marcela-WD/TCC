using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TCCWebApi.Data.Interfaces;
using TCCWebApi.Data.Services.Interfaces;

namespace TCCWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IngredienteProdutoController : ControllerBase
    {
        private readonly IRepositorio _repositorio;
        private readonly IRepositorioIngrediente _repositorioIngrediente;
        private readonly IRepositorioIngredienteProduto _repositorioIngredienteProduto;

        public IngredienteProdutoController(IRepositorio repositorio, 
                                             IRepositorioIngredienteProduto repositorioIngrediente_Produto,
                                             IRepositorioIngrediente repositorioIngrediente)
        {
            this._repositorio = repositorio;
            this._repositorioIngredienteProduto = repositorioIngrediente_Produto;
            this._repositorioIngrediente = repositorioIngrediente;
        }

        [HttpGet]
        public async Task<IActionResult> Get() 
        {
            try
            {
                return Ok(await _repositorioIngredienteProduto.ObterTodos());
            }
            catch (Exception ex)
            {
                return BadRequest($"Ao buscar todos os ingredientes, ocorreu o erro: {ex.Message}");
            }
        }
        [HttpGet("id={ingrediente_produtoId}")]
        public async Task<IActionResult> Get(int ingredienteProdutoId) 
        {
            try
            {
                return Ok(await _repositorioIngredienteProduto.ObterPeloId(ingredienteProdutoId));
            }
            catch (Exception ex)
            {
                return BadRequest($"Ao buscar o ingrediente do produto pelo ID, ocorreu o erro: {ex.Message}");
            }
        }
        [HttpGet ("produtoId={produtoId}")]
        public async Task<IActionResult> GetByProdutoId(int produtoId) 
        {
            try
            {
                return Ok(await _repositorioIngredienteProduto.ObterPeloProdutoId(produtoId));
            }
            catch (Exception ex)
            {
                return BadRequest($"Ao buscar pelo ID do produto, ocorreu o erro: {ex.Message}");
            }
        }
        [HttpGet ("ingredienteId={ingredienteId}")]
        public async Task<IActionResult> GetByIngredienteId(int ingredienteId) 
        {
            try
            {
                return Ok(await _repositorioIngredienteProduto.ObterPeloIngredienteId(ingredienteId));
            }
            catch (Exception ex)
            {
                return BadRequest($"Ao buscar pelo ID do ingrediente, ocorreu o erro: {ex.Message}");
            }
        }
    }
}