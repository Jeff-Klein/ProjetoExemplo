using ProjetoExemplo.Domain.Core.Interfaces.Repositories;
using ProjetoExemplo.Domain.Entities.Modulo.Exemplo;

namespace ProjetoExemplo.Infrastructure.Data.Repositories.Modulos.Exemplos
{
    public class ExemploRepository : BaseRepository<Exemplo>, IExemploRepository
    {
        private readonly SqlContext sqlContext;

        public ExemploRepository(SqlContext sqlContext)
            : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}
