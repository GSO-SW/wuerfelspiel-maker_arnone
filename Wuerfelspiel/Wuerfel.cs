using System;

namespace Wuerfelspiel
{
    public class Wuerfel
    {
        int anzahlSeiten;
        bool gesichert = false;
        int letztesErgebnis;
        Random rnd = new Random();

        public Wuerfel()
        {



        }

        public Wuerfel(int Anzahlseiten)
        {

        }
        public int AnzahlSeiten
        {
           get
            {
                return anzahlSeiten;
            }

            
        }
        public int LetztesEreignis
        {
            get
            {
                return letztesErgebnis;
            }


        }

        public bool Gesichert
        {
            get
            {
                return gesichert;
            }

            set 
            { 
            
            }

        }

        public void SicherungUmschalten()
        {
           


        }

        public  int Wuerfeln()
        {
            return rnd.Next(1, anzahlSeiten);
        }

    }

}
