using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjetoTeste;

namespace MSTest
{
    [TestClass]
    public class MSTest
    {
        [TestMethod]
        public void CalculoIMC()
        {
            //Arrange -- Organizar

            double peso = 75;
            double altura = 1.84;

            //Act -- Agir

            var resultado = Operacoes.Calculo(peso, altura);

            //Assert -- Verificar
            
            Assert.IsNotNull(resultado);

        }

        [DataTestMethod]
        [DataRow(70, 1.60)]
        [DataRow(1,1)]
        [DataRow(40, 1.65)]
        

        public void CalculoIMCLista(double peso, double altura)
        { 
            var resultado = Operacoes.Calculo(peso, altura);

            Assert.IsNotNull (resultado);
        }

    }
}
