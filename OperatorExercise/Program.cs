using System;

namespace OperatorExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = 17;
            var b = 4;
            var divide = a / b;
            var mod = a % b;

            Console.WriteLine($"{a}/{b} is {divide} remainder {mod}");

            Console.WriteLine("What is the radius of your circle?");
            
            var radius = double.Parse(Console.ReadLine());
            
            

            Console.WriteLine($"The area of a cirlce witht the radius of {radius} is {CalculateArea(radius)}");


        }

        public static double CalculateArea (double radius)
        { return Math.PI * (radius * radius); }
    }

}
