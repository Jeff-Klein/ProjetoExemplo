using ProjetoExemplo.Domain.Core.Interfaces.Repositories;
using ProjetoExemplo.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjetoExemplo.Domain.Core.Services
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : class
    {
        private readonly IBaseRepository<TEntity> repository;

        public BaseService(IBaseRepository<TEntity> repository)
        {
            this.repository = repository;
        }

        public Task<TEntity> AdicionarAsync(TEntity obj)
        {
            return repository.AdicionarAsync(obj);
        }

        public Task<TEntity> AtualizarAsync(TEntity obj)
        {
            return repository.AtualizarAsync(obj);
        }

        public Task<TEntity> ObterAsync(Guid id)
        {
            return repository.ObterAsync(id);
        }

        public Task<IEnumerable<TEntity>> ObterTodosAsync()
        {
            return repository.ObterTodosAsync();
        }

        public Task<int> ExcluirAsync(TEntity obj)
        {
            return repository.ExcluirAsync(obj);
        }
    }
}