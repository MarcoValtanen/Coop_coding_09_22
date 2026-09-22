namespace DemoApp_09_22
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            //Skapar objekten
           AgeChecker ageChecker = new AgeChecker();
            Calculator calculator = new Calculator();

            bool running = true;

            while (running)
            {
                Console.Clear();
                Console.WriteLine("---Klassens verktygsläda---");
                Console.WriteLine();
                Console.WriteLine("1. Kolla åldern"); // Marco 
                Console.WriteLine("2. Räkna med siffror"); // Mattias
                Console.WriteLine("3. Gissa numret");// Martin
                Console.WriteLine("4. Inch till cm konvertering"); //Ben
                Console.WriteLine("5. Km till Miles konvertering"); //Ammar
                Console.WriteLine();

                Console.Write("Välj, använd 0 för att avsluta: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ageChecker.Run();
                        break;

                    case "2":
                        calculator.Run();
                        break;
                    case "3":

                        break;
                    case "4":

                        break;
                    case "5":

                        break;
                    case "0":
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Felaktig inmatning");
                        break;

                }
                Console.WriteLine();
                Console.WriteLine("Välj en funktion från verktygslådan");
                Console.ReadKey();
            }
        }
    }
}
