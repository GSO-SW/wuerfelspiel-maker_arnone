using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wuerfelspiel;

namespace WuerfelspielTests
{
    [TestClass]
    public class WuerfelTests
    {
        [TestMethod]
        public void DummyTest()

        {
            //Arange
            WuerfelTests wuefel = new WuerfelTests()
            Wuefel wuefel = new Wuefel= (6);
            int anzahlSeitenErgebnis = 6;


            //Act

            //Assert
            Assert.AreEqual(wuerfel.AnzahlSeiten, anzahlSeitenErgebnis);
       
        }
    }
}
