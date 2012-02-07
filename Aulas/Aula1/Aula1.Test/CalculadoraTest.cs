using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Aula1.Test
{
    [TestFixture]
    public class CalculadoraTest
    {
        //Teste do animal
        [Test]
        public void SomaTest()
        {
            Calculadora calc = new Calculadora();
            int resultadoEsperado = 15;
            int atual = calc.Soma(5, 10);

            Assert.AreEqual(atual, resultadoEsperado);
        }
    }
}
