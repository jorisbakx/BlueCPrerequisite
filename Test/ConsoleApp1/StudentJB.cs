using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class StudentJB
    {
		private string Naam;
		private int Studentnummer;
		private double Studiepunten;
		private Boolean Propedeuse;
		private Boolean SAN1;
		private Boolean SON1;
		private Boolean SRE1a;
		private Boolean SRE1b;

		public StudentJB(string naam, double studiepunten)
		{
			this.Naam = naam;
			this.Studentnummer = 00073350;
			this.Studiepunten = studiepunten;
			this.Propedeuse = false;
			this.SAN1 = true;
			this.SON1 = true;
			this.SRE1a = true;
			this.SRE1b = true;
		}

		public string GetName()
		{
			return this.Naam;
		}

		public double GetStudiepunten()
		{
			return this.Studiepunten;
		}
    }
}
