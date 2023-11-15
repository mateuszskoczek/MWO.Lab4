using System.Reflection;

namespace Lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Assembly.GetExecutingAssembly().GetName());
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"a + b = {Calculator.Sum(a, b)}");
            Console.WriteLine($"a + b = {Calculator.Multiply(a, b)}");
            Console.WriteLine($"a / b = {Calculator.Divide(a, b)}");
        }
    }
}