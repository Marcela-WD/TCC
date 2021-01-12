using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TCCWebApi.Data.Interfaces;
using TCCWebApi.Data.Services.Interfaces;

namespace TCCWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IngredienteController : ControllerBase
    {
        private readonly IRepositorio _repositorio;
        private readonly IRepositorioIngrediente _repositorioIngrediente;

        public IngredienteController(IRepositorio repositorio, 
                                     IRepositorioIngrediente repositorioIngrediente)
        {
            this._repositorio = repositorio;
            this._repositorioIngrediente = repositorioIngrediente;
        }

        [HttpGet]
        public async Task<IActionResult> Get() 
        {
            try
            {
                var ingredientes = await _repositorioIngrediente.ObterTodos();
                return Ok(ingredientes);
            }
            catch (Exception ex)
            {
                return BadRequest($"Ao buscar todos os ingredientes, ocorreu o erro: {ex.Message}");
            }
        }

        [HttpGet("id={ingredienteId}")]
        public async Task<IActionResult> Get(int ingredienteId) 
        {
            try
            {
                var ingrediente = await _repositorioIngrediente.ObterPeloId(ingredienteId);
                return Ok(ingrediente);
            }
            catch (Exception ex)
            {
                return BadRequest($"Ao buscar o ingrediente pelo id, ocorreu o erro: {ex.Message}");
            }
        }

        [HttpGet("descricao={descricao}")]
        public async Task<IActionResult> GetPelaDescricao(string descricao) 
        {
            try
            {
                var ingrediente = await _repositorioIngrediente.ObterPelaDescricao(descricao);
                return Ok(ingrediente);
            }
            catch (Exception ex)
            {
                return BadRequest($"Ao buscar o ingrediente pela descricao, ocorreu o erro: {ex.Message}");
            }
        }
    }
}