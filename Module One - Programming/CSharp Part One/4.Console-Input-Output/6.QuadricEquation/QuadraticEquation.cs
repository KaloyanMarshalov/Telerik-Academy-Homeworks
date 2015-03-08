using System;

//Write a program that reads the coefficients a, b and c of a quadratic equation ax2+bx+c=0 and solves it (prints its real roots).

namespace _6.QuadraticEquation
{
    class QuadraticEquation
    {
        static void Main()
        {
            Console.Write("Inset a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Inset b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Inset c: ");
            int c = int.Parse(Console.ReadLine());

            double x1 = (-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
            double x2 = (-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
            Console.WriteLine("x1 = {0}, x2 = {1}", x1, x2);
        }
    }
}
