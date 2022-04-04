using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wuerfelspiel;

namespace WuerfelspielTests
{
    [TestClass]
    public class WuerfelTests
    {
        [TestMethod]
        public void Wuerfel_DummyTest()

        {
            //Arange
            WuerfelTests wuefel = new WuerfelTests();
            int anzahlSeitenErgebnis = 6;


            //Act
            Wuefel wuefel = new Wuefel(6);

            //Assert
            Assert.AreEqual(wuerfel.AnzahlSeiten, anzahlSeitenErgebnis);
       
        }

        [TestMethod]
        public void Wuerfel_AnzahlSeiten()

        {
            //Arange
            int anzahlseiten = 6;

            //Act
            Wuerfel wuerfel = new Wuerfel(anzahlseiten);

            //Assert
            Assert.AreEqual(wuerfel.AnzahlSeiten, anzahlseiten);

        }
    }
}
