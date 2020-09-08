using AutoMapper;
using ProjetoExemplo.Application.Interfaces;
using ProjetoExemplo.Application.Modulo.Exemplos.Models;
using ProjetoExemplo.Domain.Core.Interfaces.Services;
using ProjetoExemplo.Domain.Entities.Modulo.Exemplo;
using System.Threading.Tasks;

namespace ProjetoExemplo.Application.Modulo.Exemplos.Command
{
    public class ExemploCommand : IExemploCommand
    {
        private readonly IExemploService serviceExemplo;
        private readonly IMapper mapper;

        public ExemploCommand(IExemploService serviceExemplo
                                       , IMapper mapper)
        {
            this.serviceExemplo = serviceExemplo;
            this.mapper = mapper;
        }

        public async Task<ExemploModel> AdicionarAsync(ExemploModel exemplo)
            => mapper.Map<ExemploModel>(await serviceExemplo.AdicionarAsync(mapper.Map<Exemplo>(exemplo)));

        public async Task<ExemploModel> AtualizarAsync(ExemploModel exemplo)
            => mapper.Map<ExemploModel>(await serviceExemplo.AtualizarAsync(mapper.Map<Exemplo>(exemplo)));

        public async Task<int> ExcluirAsync(ExemploModel exemplo)
            => mapper.Map<int>(await serviceExemplo.ExcluirAsync(mapper.Map<Exemplo>(exemplo)));
    }
}
