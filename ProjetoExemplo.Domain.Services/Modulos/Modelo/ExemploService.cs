

using ProjetoExemplo.Domain.Entities.Modulo.Exemplo;

namespace ProjetoExemplo.Domain.Services.Modulo.Exemplos
{
    public class ExemploService : BaseService<Exemplo>, IServiceExemplo
    {
        private readonly IRepositoryExemplo repositoryExemplo;

        public ExemploService(IRepositoryExemplo repositoryExemplo)
            : base(repositoryExemplo)
        {
            this.repositoryExemplo = repositoryExemplo;
        }
    }
}
