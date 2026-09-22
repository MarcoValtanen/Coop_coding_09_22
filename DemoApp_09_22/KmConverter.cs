using System;
using System.Collections.Generic;
using System.Text;

namespace DemoApp_09_22
{
    public class KmConverter
    {
        public void Run()
        {
            Console.Clear();
            Console.WriteLine("<---Kilometer till Miles konvertering--->");
            Console.WriteLine("Skriv in antal Km du sprungit idag.");

            if (double.TryParse(Console.ReadLine(), out double km))
            {
                double miles = km * 0.621371;
                Console.WriteLine($"{km} km är {miles:F2}miles.");
            
            }
            else
            {
                Console.WriteLine("Ogiltig inmatning, skriv en siffra.");
            }
            Console.WriteLine("\nTryck på valfri knapp för att gå tillbaka...");
            Console.ReadKey();
        }
    }
}
