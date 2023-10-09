using LojaLivro.Core.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LojaLivro.Livro.API.Models
{
    public interface IProdutoRepository : IRepository<Produto>
    {
        Task<IEnumerable<Produto>> ObterTodos();
        Task<Produto> ObterPorId(Guid id);
        Task<IEnumerable<Produto>> ObterPorData(DateTime dataIn, DateTime dataOut);

        void Adicionar(Produto produto);
        void Atualizar(Produto produto);
    }
}
