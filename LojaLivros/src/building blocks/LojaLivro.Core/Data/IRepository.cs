using LojaLivro.Core.DomainObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace LojaLivro.Core.Data
{
    public interface IRepository<T> : IDisposable where T : IAggregateRoot
    {

    }
}
