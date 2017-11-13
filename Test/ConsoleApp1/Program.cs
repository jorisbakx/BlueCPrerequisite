using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Huis mijnHuis = new Huis("Zeldenrust", 2);
            Huis deburen = new Huis("Altijd lawaai", 1);
            
            // Dit gaat over mijn huis
            Console.WriteLine(mijnHuis.GeefAantalRamen());
            Console.WriteLine( mijnHuis.GeefWoonindicatie());

            // dit gaat over de buurtjes
            Console.WriteLine(deburen.GeefAantalDakgoten());


            string name = Console.ReadLine();
            

            
            Console.Read();
        }
    }
}
