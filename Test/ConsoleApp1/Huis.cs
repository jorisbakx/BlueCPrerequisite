using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Huis
    {
        // velden
        private int AantalDakgoten;
        private int AantalRamen;
        private string Naam;
        private bool Dak;

        private bool SRE1b;

        public Huis( string naam, int aantalDakgoten )
        {
            this.Naam = naam;
            this.AantalRamen = 3;
            this.Dak = true;

            SRE1b = false;

            this.AantalDakgoten = aantalDakgoten;
        }

        public int GeefAantalRamen()
        {
            return this.AantalRamen;
        }

        public string GeefWoonindicatie()
        {
            return "Het is hier zoo mooi wonen!";
        }

        public int GeefAantalDakgoten()
        {
            return this.AantalDakgoten;
        }

        public bool HeeftSRE1b()
        {
            return this.SRE1b;
        }

        public bool HeeftDak()
        {
            return this.Dak;
        }
    }
}
