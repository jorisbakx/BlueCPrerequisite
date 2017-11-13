using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class AboutJB
    {
		private string Naam;
		private int Leeftijd;
		private string Geboortedatum;
		private string Email;
		private int TelefoonNummer;
		private Boolean man;

		public AboutJB(string naam)
		{
			this.Naam = naam;
			this.Email = "jjbakx@zeelandnet.nl";
			this.Geboortedatum = "20-01-1999";
			this.TelefoonNummer = 0643262321;
			this.Leeftijd = 18;
			this.man = true;
		}

		public string GetName()
		{
			return this.Naam;
		}


    }
}
