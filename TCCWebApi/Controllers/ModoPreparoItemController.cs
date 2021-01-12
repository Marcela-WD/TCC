using TCCWebApi.Data.Services.Interfaces;
using TCCWebApi.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;

namespace TCCWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ModoPreparoItemController : Controller
    {
        private readonly IRepositorio _repositorio;
        private readonly IRepositorioModoPreparo _repositorioModoPreparo;
        private readonly IRepositorioModoPreparoItem _repositorioModoPreparoItem;

        public ModoPreparoItemController(IRepositorio repositorio, 
                                         IRepositorioModoPreparo repositorioModoPreparo,
                                         IRepositorioModoPreparoItem repositorioModoPreparoItem)
        {
            this._repositorio = repositorio;
            this._repositorioModoPreparo = repositorioModoPreparo;
            this._repositorioModoPreparoItem = repositorioModoPreparoItem;
        }

        [HttpGet]
        public async Task<IActionResult> Get() 
        {
            try
            {
                return Ok(await _repositorioModoPreparoItem.ObterTodos());
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro ao consultar todos, erro: {ex.Message}");
            }
        }   
        [HttpGet("mpid={modoPreparoId}")]
        public async Task<IActionResult> GetByMPI(int modoPreparoId) 
        {
            try
            {
                return Ok(await _repositorioModoPreparoItem.ObterPelaModoPreparoItemId(modoPreparoId));
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro ao consultar todos, erro: {ex.Message}");
            }
        }   
        
    }
}