namespace LicorneGitHub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello, C# Academy !, one more modification"); 

            myMethod();
            Console.WriteLine(addition(3, 4));
            Console.WriteLine(multiplication(3, 4));
        }

        static void myMethod()
        {
            Console.WriteLine("Now I have a method");
        }

        static double addition(double a, double b)
        {
            return a + b;
        }

        static double multiplication(double a, double b)
        {
            return a * b;
        }
    }
}
