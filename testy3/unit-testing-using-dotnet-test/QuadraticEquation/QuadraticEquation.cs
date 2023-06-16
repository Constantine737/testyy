using System;

namespace QuadraticEquation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the coefficients of the quadratic equation:");
            Console.Write("a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c: ");
            double c = double.Parse(Console.ReadLine());

            double delta = b * b - 4 * a * c;

            if (delta < 0)
            {
                Console.WriteLine("No real roots");
            }
            else if (delta == 0)
            {
                double root = -b / (2 * a);
                Console.WriteLine($"One real root: {root}");
            }
            else
            {
                double root1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double root2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"Two real roots: {root1}, {root2}");
            }
        }
    }
}
