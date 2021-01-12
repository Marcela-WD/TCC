using Microsoft.AspNetCore.Mvc;
using TCCWebApi.Data.Services.Interfaces;
using TCCWebApi.Data.Interfaces;
using System;
using System.Threading.Tasks;

namespace TCCWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ModoPreparoController : Controller
    {
        private readonly IRepositorio _repositorio;
        private readonly IRepositorioModoPreparo _repositorioModoPreparo;

        public ModoPreparoController(IRepositorio repositorio, 
                                     IRepositorioModoPreparo repositorioModoPreparo)
        {
            this._repositorio = repositorio;
            this._repositorioModoPreparo = repositorioModoPreparo;
        }
        [HttpGet]
        public async Task<IActionResult> Get() 
        {
            try
            {
                return Ok(await _repositorioModoPreparo.ObterTodos());
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro ao consultar todos, erro: {ex.Message}");
            }
        }   
        [HttpGet("id={modoPreparoId}")]
        public async Task<IActionResult> GetById(int modoPreparoId) 
        {
            try
            {
                return Ok(await _repositorioModoPreparo.ObterPeloId(modoPreparoId));
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro ao consultar todos, erro: {ex.Message}");
            }
        }
        [HttpGet("descricao={descricao}")]
        public async Task<IActionResult> GetByDescription(string descricao) 
        {
            try
            {
                return Ok(await _repositorioModoPreparo.ObterPelaDescricao(descricao));
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro ao consultar todos, erro: {ex.Message}");
            }
        }
    }
}