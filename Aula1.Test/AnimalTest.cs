using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Aula1.Test
{
    [TestFixture]
    public class AnimalTest
    {
        //Implementar a casa
        [Test]
        public void SomaTest()
        {
            Animal animal = new Animal();
            int resultadoEsperado = 15;
            int atual = animal.Soma(5, 10);

            Assert.AreEqual(atual, resultadoEsperado);
        }
    }
}
