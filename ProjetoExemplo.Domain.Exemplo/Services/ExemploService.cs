

using ProjetoExemplo.Domain.Core.Interfaces.Repositories;
using ProjetoExemplo.Domain.Core.Interfaces.Services;
using ProjetoExemplo.Domain.Core.Services;
using ProjetoExemplo.Domain.Entities.Modulo.Exemplo;

namespace ProjetoExemplo.Domain.Exemplos.Services
{
    public class ExemploService : BaseService<Exemplo>, IExemploService
    {
        private readonly IExemploRepository repositoryExemplo;

        public ExemploService(IExemploRepository repositoryExemplo)
            : base(repositoryExemplo)
        {
            this.repositoryExemplo = repositoryExemplo;
        }
    }
}
