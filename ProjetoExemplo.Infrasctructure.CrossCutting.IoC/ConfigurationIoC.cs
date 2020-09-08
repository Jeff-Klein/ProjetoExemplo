using Autofac;
using AutoMapper;
using ProjetoExemplo.Application.Interfaces;
using ProjetoExemplo.Application.Modulo.Exemplos.Command;
using ProjetoExemplo.Application.Modulo.Exemplos.Queries;
using ProjetoExemplo.Application.Modulos.Exemplos.Mapper;
using ProjetoExemplo.Domain.Core.Interfaces.Repositories;
using ProjetoExemplo.Domain.Core.Interfaces.Services;
using ProjetoExemplo.Domain.Exemplos.Services;
using ProjetoExemplo.Infrastructure.Data.Repositories.Modulos.Exemplos;

namespace ProjetoExemplo.Infrastructure.CrossCutting.IoC
{
    public class ConfigurationIoC
    {
        public static void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ExemploRepository>().As<IExemploRepository>();            
            builder.RegisterType<ExemploService>().As<IExemploService>();
            builder.RegisterType<ExemploQuery>().As<IExemploQuery>();
            builder.RegisterType<ExemploCommand>().As<IExemploCommand>();

            builder.Register(ctx => new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new ExemploModelMap());
            }));

            builder.Register(ctx => ctx.Resolve<MapperConfiguration>().CreateMapper()).As<IMapper>().InstancePerLifetimeScope();
        }
    }
}
