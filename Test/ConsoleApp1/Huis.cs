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

		public Huis(string naam)
		{
			this.Naam = naam;
			this.AantalRamen = 3;
			this.Dak = true;

		}

		public int GeefAantalRamen()
		{
			return this.AantalRamen;
		}

		public bool HeeftDak()
		{
			return this.Dak;
		}
	}
}