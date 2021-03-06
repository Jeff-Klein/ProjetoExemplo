﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjetoExemplo.Domain.Core.Interfaces.Repositories
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        Task<TEntity> AdicionarAsync(TEntity obj);
        Task<TEntity> AtualizarAsync(TEntity obj);
        Task<int> ExcluirAsync(TEntity obj);
        Task<IEnumerable<TEntity>> ObterTodosAsync();
        Task<TEntity> ObterAsync(Guid id);
    }
}
