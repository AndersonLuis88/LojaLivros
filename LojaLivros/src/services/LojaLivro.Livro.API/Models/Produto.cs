﻿using LojaLivro.Core.DomainObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaLivro.Livro.API.Models
{
    public class Produto : Entity, IAggregateRoot
    {
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
