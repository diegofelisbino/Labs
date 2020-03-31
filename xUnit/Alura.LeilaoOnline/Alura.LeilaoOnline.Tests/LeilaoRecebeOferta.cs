using Alura.LeilaoOnline.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace Alura.LeilaoOnline.Tests
{
    public class LeilaoRecebeOferta
    {
        [Fact]
        public void NaoPermiteNovosLancesDadoLeilaoFinal()
        {
            var leilao = new Leilao("Van Gogh");

            var fulano = new Interessada("Fulano", leilao);
            leilao.RecebeLance(fulano, 800);
            leilao.RecebeLance(fulano, 900);
            leilao.TerminaPregao();

            //Act - método sob teste
            leilao.RecebeLance(fulano, 1000);

            //Assert    
            var valorEsperado = 2;
            var valorObtido = leilao.Lances.Count();

            Assert.Equal(valorEsperado, valorObtido);
        }

    }
}
