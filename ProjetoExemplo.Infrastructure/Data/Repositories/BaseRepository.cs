using Microsoft.EntityFrameworkCore;
using ProjetoExemplo.Domain.Core.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjetoExemplo.Infrastructure.Data.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly SqlContext sqlContext;

        public BaseRepository(SqlContext sqlContext)
        {
            this.sqlContext = sqlContext;
        }

        public async Task<TEntity> AdicionarAsync(TEntity obj)
        {
            sqlContext.Set<TEntity>().Add(obj);
            var resultado = await sqlContext.SaveChangesAsync();

            if (resultado > 0)
                return obj;
            else
                throw new Exception();
        }

        public async Task<TEntity> AtualizarAsync(TEntity obj)
        {
            sqlContext.Entry(obj).State = EntityState.Modified;
            var resultado = await sqlContext.SaveChangesAsync();

            if (resultado > 0)
                return obj;
            else
                throw new Exception();
        }

        public async Task<TEntity> ObterAsync(Guid id)
        {
            return await sqlContext.Set<TEntity>().FindAsync(id);
        }

        public async Task<IEnumerable<TEntity>> ObterTodosAsync()
        {
            return await sqlContext.Set<TEntity>().ToListAsync();
        }

        public async Task<int> ExcluirAsync(TEntity obj)
        {
            sqlContext.Set<TEntity>().Remove(obj);
            return await sqlContext.SaveChangesAsync();
        }
    }
}
