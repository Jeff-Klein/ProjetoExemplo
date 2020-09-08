using AutoMapper;
using ProjetoExemplo.Application.Modulo.Exemplos.Models;
using ProjetoExemplo.Domain.Entities.Modulo.Exemplo;

namespace ProjetoExemplo.Application.Modulos.Exemplos.Mapper
{
    public class ExemploModelMap : Profile
    {
        public ExemploModelMap()
        {
            CreateMap<ExemploModel, Exemplo>();
            CreateMap<Exemplo, ExemploModel>();
        }
    }
}
