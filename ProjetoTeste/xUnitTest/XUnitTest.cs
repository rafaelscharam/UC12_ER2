using ProjetoTeste;
using System;
using Xunit;

namespace xUnitTest
{
    public class XUnitTest
    {
        [Fact]
        public void CalculoIMC()
        {
            //Arrange -- Organizar

            double peso = 75;
            double altura = 1.84;

            //Act -- Agir

            var resultado = Operacoes.Calculo(peso, altura);

            //Assert -- Verificar

            Assert.NotInRange(resultado, 0, 999);


        }

        [Theory]
        [InlineData(70, 1.80)]
        [InlineData(60, 1.90)]
        [InlineData(180, 1.70)]
        [InlineData(9999999999999999999, 1.65)]

        public void Calculo(double peso, double altura)
        {
            var resultado = Operacoes.Calculo(peso, altura);

            Assert.InRange(resultado, 0, 18.4);
            //Assert.InRange(resultado, 18.5, 24.9);
            //Assert.InRange(resultado, 25, 29.9);
            //Assert.InRange(resultado, 30, 34.9);
            //Assert.InRange(resultado, 35, 39.9);
            //Assert.InRange(resultado, 40, 999);

        }

    }
}
