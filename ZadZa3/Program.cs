using System;

namespace ZadZa3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());

            double p = Triangle.Perimeter(a, b, c);
            double s = Triangle.Area(a, b, c);

            Console.WriteLine($"P = {p}, S = {s}");




        }
    }
}
