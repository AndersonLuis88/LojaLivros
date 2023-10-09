using LojaLivro.Livro.API.Models;
using LojaLivros.WebApi.Core.Identidade;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaLivro.Livro.API.Controllers
{
    [ApiController]
    [Authorize]
    public class CatalogoController : Controller
    {
        private readonly IProdutoRepository _produtoRepository;

        public CatalogoController(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        [AllowAnonymous]
        [HttpGet("catalogo/produtos")]
        public async Task<IEnumerable<Produto>> Index()
        {
            return await _produtoRepository.ObterTodos();
        }

        [ClaimsAuthorize("Catalogo", "Ler")]
        [HttpGet("catalogo/produtos/{id}")]
        public async Task<Produto> ProdutoDetalhe(Guid id)
        {
            return await _produtoRepository.ObterPorId(id);
        }

        //Retirar comentário para ativar a role
        //[ClaimsAuthorize("Catalogo", "Ler")]
        [HttpGet("catalogo/produtos/Data")]
        public async Task<Produto> ProdutoPorData(DateTime dataIn, DateTime dataOut)
        {
            return (Produto)await _produtoRepository.ObterPorData(dataIn, dataOut);
        }
    }
}
