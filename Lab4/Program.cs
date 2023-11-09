namespace Lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"a + b = {Calculator.Sum(a, b)}");
            Console.WriteLine($"a + b = {Calculator.Multiply(a, b)}");
        }
    }
}