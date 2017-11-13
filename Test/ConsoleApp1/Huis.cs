using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Huis
    {
        // velden
        private int AantalRamen;
        private string Naam;
        private bool Dak;

        private bool SRE1b;

        public Huis( string naam )
        {
            this.Naam = naam;
            this.AantalRamen = 3;
            this.Dak = true;

            SRE1b = false;
        }

        public int GeefAantalRamen()
        {
            return this.AantalRamen;
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
