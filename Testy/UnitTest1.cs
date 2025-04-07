using BarevnaKonzole;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testy
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSuma()
        {
            //prepare
            Vypisovac vypisovac = new Vypisovac();



            //execution
            int vysledek = vypisovac.Suma(4, 8);


            //assert
            Assert.AreEqual(12, vysledek);


        }

        [TestMethod]
        public void TestSuma2()
        {
            //prepare
            Vypisovac vypisovac = new Vypisovac();



            //execution
            int vysledek = vypisovac.Suma(444, 555);


            //assert
            Assert.AreEqual(999, vysledek);


        }
    }
}
