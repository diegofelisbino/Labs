using Alura.LeilaoOnline.Core;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Alura.LeilaoOnline.Tests
{
    public class LeilaoTerminaPregao
    {

        [Theory]
        [InlineData(1000, new double[] { 800, 900, 990, 1000 })]
        [InlineData(1000, new double[] { 800, 900, 1000, 990 })]
        [InlineData(800, new double[] { 800 })]
        public void RetornaMaiorValorDadoLeilaoComPeloMenosUmLance(double valorEsperado, double[] ofertas)
        {
            var leilao = new Leilao("Van Gogh");

            var fulano = new Interessada("Fulano", leilao);



            foreach (var valor in ofertas)
            {
                leilao.RecebeLance(fulano, valor);
            }

            //Act - método sob teste
            leilao.TerminaPregao();

            //Assert          
            var valorObtido = leilao.Ganhador.Valor;

            Assert.Equal(valorEsperado, valorObtido);
        }

        [Fact]
        public void LeilaoSemLance()
        {
            var leilao = new Leilao("Van Gogh");

            //Act - método sob teste
            leilao.TerminaPregao();

            //Assert
            var valorEsperado = 0;
            var valorObtido = leilao.Ganhador.Valor;

            Assert.Equal(valorEsperado, valorObtido);
        }



        [Theory]
        [InlineData(7, 2, 5)]
        public void RetornaZeroDadoLeilaoSemLance(int resultadoEsperado, int num1, int num2)
        {
            //Act
            var resultadoObtido = num1 + num2;
            //Assert
            Assert.Equal(resultadoEsperado, resultadoObtido);
        }
    }
}
