using LojaLivro.Core.Data;
using LojaLivro.Livro.API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaLivro.Livro.API.Data.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly CatalogoContext _context;

        public ProdutoRepository(CatalogoContext context)
        {
            _context = context;
        }

        public IUnitOfWork UnitOfWork => _context;

        public async Task<IEnumerable<Produto>> ObterTodos()
        {
            return await _context.Produtos.AsNoTracking().ToListAsync();
        }

        public async Task<Produto> ObterPorId(Guid id)
        {
            return await _context.Produtos.FindAsync(id);
        }

        public void Adicionar(Produto produto)
        {
            _context.Produtos.Add(produto);
        }

        public void Atualizar(Produto produto)
        {
            _context.Produtos.Update(produto);
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
        //Realiza o filtro pela data e retorna pela mesma rota de obter todos para a View
        public async Task<IEnumerable<Produto>> ObterPorData(DateTime dataIn, DateTime dataOut)
        {
            IQueryable<Produto> query = _context.Produtos;
            query = query.Where(x => x.DataPublicacao >= dataIn && x.DataPublicacao <= dataOut).OrderBy(c => c.Nome);

            return await query.AsNoTracking().ToListAsync();
            
        }
    }
}
