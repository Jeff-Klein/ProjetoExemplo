using ProjetoExemplo.Domain.Entities.Modulo.Exemplo;
using System;
using Xunit;

namespace ProjetoExemplo.XUnitTest.Modulos.Exemplos
{
    public class AlterarNomeTests
    {
        private readonly Exemplo _exemplo;
        private readonly string nomeInicial = "Maria";

        public AlterarNomeTests()
        {
            _exemplo = new Exemplo(nomeInicial);
        }

        [Theory]
        [InlineData("Joao")]
        [InlineData("Pedro")]
        [InlineData("Ana")]
        public void Se_Nome_Valido_RetornarNovoNome(string novoNome)
        {
            var resultado = _exemplo.AlterarNome(novoNome);
            Assert.True(novoNome == resultado);
        }

        [Fact]
        public void Se_Nome_Invalido_RetornarNomeInicial()
        {
            var novoNome = string.Empty;
            var resultado = _exemplo.AlterarNome(novoNome);
            Assert.False(novoNome == resultado);
        }
    }
}
