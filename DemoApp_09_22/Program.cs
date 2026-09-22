namespace DemoApp_09_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.Clear();

                Console.WriteLine("=== KLASSENS VERKTYGSLÅDA ===");
                Console.WriteLine();
                Console.WriteLine("1. Hälsa på användaren");
                Console.WriteLine("2. Kontrollera ålder");
                Console.WriteLine("3. Enkel miniräknare");
                Console.WriteLine("4. Multiplikationstabell");
                Console.WriteLine("5. Gissa talet");
                Console.WriteLine("0. Avsluta");
                Console.WriteLine();

                Console.Write("Välj: ");
                string choice = Console.ReadLine();

                Console.Clear();

                switch (choice)
                {
                    case "1":
                        Greeting();
                        break;

                    case "2":
                        CheckAge();
                        break;

                    case "3":
                        Calculator();
                        break;

                    case "4":
                        MultiplicationTable();
                        break;

                    case "5":
                        GuessNumber();
                        break;

                    case "0":
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Felaktigt val.");
                        break;
                }

                if (running)
                {
                    Console.WriteLine();
                    Console.WriteLine("Tryck på valfri tangent...");
                    Console.ReadKey();
                }
            }
        }

        // ELE V 1
        static void Greeting()
        {
            Console.WriteLine("Den här funktionen ska elev 1 utveckla.");
        }

        // ELEV 2
        static void CheckAge()
        {
            Console.WriteLine("Den här funktionen ska elev 2 utveckla.");
        }

        // ELEV 3
        static void Calculator()
        {
            Console.WriteLine("Den här funktionen ska elev 3 utveckla.");
        }

        // ELEV 4
        static void MultiplicationTable()
        {
            Console.WriteLine("Den här funktionen ska elev 4 utveckla.");
        }

        // ELEV 5
        static void GuessNumber()
        {
            Console.WriteLine("Den här funktionen ska elev 5 utveckla.");
        }
    }
}
