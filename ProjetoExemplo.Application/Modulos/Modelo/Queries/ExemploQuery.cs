using AutoMapper;
using ProjetoExemplo.Application.Interfaces;
using ProjetoExemplo.Application.Modulo.Exemplos.Models;
using ProjetoExemplo.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjetoExemplo.Application.Modulo.Exemplos.Queries
{
    public class ExemploQuery : IExemploQuery
    {
        private readonly IExemploService serviceExemplo;
        private readonly IMapper mapper;

        public ExemploQuery(IExemploService serviceExemplo
                                       , IMapper mapper)
        {
            this.serviceExemplo = serviceExemplo;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<ExemploModel>> BuscarTodosAsync()
            => mapper.Map<IEnumerable<ExemploModel>>(await serviceExemplo.ObterTodosAsync());

        public async Task<ExemploModel> ObterAsync(Guid id)
            => mapper.Map<ExemploModel>(await serviceExemplo.ObterAsync(id));
    }
}
