using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
			StudentJB test1 = new StudentJB("Joris Bakx", 47.5);
			Console.WriteLine(test1.GetName());
			Console.WriteLine(test1.GetStudiepunten());

			Console.Read();
        }
    }
}
