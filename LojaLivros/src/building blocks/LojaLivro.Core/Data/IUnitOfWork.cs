﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LojaLivro.Core.Data
{
    public interface IUnitOfWork
    {
        Task<bool> Commit();
    }
}
