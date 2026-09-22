using System;
using System.Collections.Generic;
using System.Text;

namespace DemoApp_09_22
{
    internal class AgeChecker
    {
        public void Run()
        {
            Console.WriteLine("Vilket år är du född");
            int currentYear = DateTime.Now.Year;
            int birthdateYear = int.Parse(Console.ReadLine());
            int ageYear = currentYear - birthdateYear;

            Console.WriteLine($"Du är {ageYear} år gammal");
        }
    }
}
