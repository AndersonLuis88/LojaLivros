using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaLivro.WebApp.MVC.Models
{
    public class ProdutoViewModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Isbn { get; set; }
        public string Editora { get; set; }
        public string Autor { get; set; }
        public string Sinopse { get; set; }
        public DateTime DataPublicacao { get; set; }
        public string Imagem { get; set; }
    }
}
