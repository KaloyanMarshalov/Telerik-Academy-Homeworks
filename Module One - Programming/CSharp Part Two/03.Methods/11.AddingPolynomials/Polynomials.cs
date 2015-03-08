using System;

//Write a method that adds two polynomials.
//Represent them as arrays of their coefficients.
//x2 + 5 = 1x2 + 0x + 5 => {5, 0, 1}
namespace _11.AddingPolynomials
{
    class Polynomials
    {
        static int[] AddPolynomials(int[] poly1, int[] poly2)
        {
            int[] addedPolynomials = new int[3];
            for (int i = 0; i < 3; i++)
            {
                addedPolynomials[i] = poly1[i] + poly2[i];
            }
            return addedPolynomials;
        }
        static int[] SubstractPolynomials(int[] poly1, int[] poly2)
        {
            int[] substractedPolynomials = new int[3];
            for (int i = 0; i < 3; i++)
            {
                substractedPolynomials[i] = poly1[i] - poly2[i];
            }
            return substractedPolynomials;
        }
        static int[] MultiplicatePolynomials(int[] poly1, int[] poly2)
        {
            int[] multiplicatedPolynomials = new int[3];
            for (int i = 0; i < 3; i++)
            {
                multiplicatedPolynomials[i] = poly1[i] * poly2[i];
            }
            return multiplicatedPolynomials;
        }

        static void Main()
        {
            int[] polynomial1 = new int[3];
            Console.WriteLine("Polynomial One:");
            for (int i = 0; i < polynomial1.Length; i++)
            {
                Console.Write("Insert x^{0}: ", i);
                polynomial1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Polynomial Two:");
            int[] polynomial2 = new int[3];
            for (int i = 0; i < polynomial2.Length; i++)
            {
                Console.Write("Insert x^{0}: ", i);
                polynomial2[i] = int.Parse(Console.ReadLine());
            }

            int[] addedPolynomials = AddPolynomials(polynomial1, polynomial2);
            int[] substractedPolynomials = SubstractPolynomials(polynomial1, polynomial2);
            int[] multiplicatedPolinomials = MultiplicatePolynomials(polynomial1, polynomial2);
            Console.WriteLine("Addition: " + string.Join(", ", addedPolynomials));
            Console.WriteLine("Substraction: " + string.Join(", ", substractedPolynomials));
            Console.WriteLine("Multiplication: " + string.Join(", ", multiplicatedPolinomials));
        }
    }
}
