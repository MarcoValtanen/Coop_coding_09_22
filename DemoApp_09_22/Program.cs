namespace DemoApp_09_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            SayHello("Reidar");

            int result = Add(3, 3);
            int.Parse("128");
            Math.Max(11,12);
            Console.WriteLine(result);
        }

        static void SayHello(string name)
        {
            Console.WriteLine($"Hej från Sverige {name}");
        }

        static int Add(int a, int b)
        {
            Console.WriteLine("Resuktatet blir: ");
            return a + b;
            
        }
    }
}
