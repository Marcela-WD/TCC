using System.Data;
using TCCWebApi.Data.Services.Interfaces;
using TCCWebApi.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using TCCWebApi.Models;

namespace TCCWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : Controller
    {
        private readonly IRepositorio _repositorio;
        private readonly IRepositorioProduto _repositorioProduto;

        public ProdutoController(IRepositorio repositorio, 
                                 IRepositorioProduto repositorioProduto)
        {
            this._repositorio = repositorio;
            this._repositorioProduto = repositorioProduto;
        }

        [HttpGet]
        public async Task<IActionResult> Get() 
        {
            try
            {
                return Ok(await _repositorioProduto.ObterTodos());
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }
        }
        [HttpGet("descricao={descricao}")]
        public async Task<IActionResult> GetByDescription(string descricao) 
        {
            try
            {
                return Ok(await _repositorioProduto.ObterPelaDescricao(descricao)); 
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post(Produto produto)
        {
            try
            {
                _repositorio.Adicionar(produto);

                if (await _repositorio.EfetuouAlteracoesAssincronas())
                {
                    return Ok(produto);
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"Ao salvar o produto, ocorreu o erro: {ex.Message}");               
            }
            return BadRequest();    
        }

         [HttpPut("id={produtoId}")]
        public async Task<IActionResult> Put(int produtoId, Produto produto)
        {
            try
            {
              var produtoCadastrado = await _repositorioProduto.ObterPeloId(produtoId);
              if (produtoCadastrado == null)
              {
                  return NotFound();
              }  
              _repositorio.Atualizar(produto);  
              
              if (await _repositorio.EfetuouAlteracoesAssincronas())
              {
                  return Ok(produto);
              }
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro ao tentar atualizar o produto: {ex.Message}");                
            } 
            return BadRequest();
        }

        [HttpDelete("id={produtoId}")]
        public async Task<IActionResult> Delete(int produtoId)
        {
            try
            {
              var produtoCadastrado = await _repositorioProduto.ObterPeloId(produtoId);
              if (produtoCadastrado == null)
              {
                  return NotFound();
              }  

              _repositorio.Deletar(produtoCadastrado);

              if (await _repositorio.EfetuouAlteracoesAssincronas())
              {
                  return Ok(
                      new {
                          message="Removido!"
                      }
                  );
              }
            }
            catch (Exception ex)
            {
                return BadRequest($"Ao tentar remover o produto, ocorreu o erro: {ex.Message}");                
            }
            return BadRequest();
        }
    }
}