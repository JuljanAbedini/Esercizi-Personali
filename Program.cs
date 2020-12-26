using System;

namespace C_Sharp_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fai dei calcoli!");

            //C# Math
            int x = 84;
            int y = 97;

            Console.WriteLine(Math.Max(x, y)); //The Math.Max(x,y) method can be used to find the highest value of x and y:
            Console.WriteLine(Math.Min(x, y)); //The Math.Min(x,y) method can be used to find the lowest value of of x and y:
            Console.WriteLine(Math.Sqrt (x)); //The Math.Sqrt(x) method returns the square root of x:
            Console.WriteLine(Math.Abs(-9.8)); //The Math.Abs(x) method returns the absolute (positive) value of x:
            Console.WriteLine(Math.Round(8.75)); //Math.Round() rounds a number to the nearest whole number:

            /*
            int x = 195 + 6;
            Console.WriteLine(x);

            int sum1 = 100 + 50;        // 150 (100 + 50)
            int sum2 = sum1 + 250;      // 400 (150 + 250)
            int sum3 = sum2 + sum2;     // 800 (400 + 400)

            Console.WriteLine(sum1);
            Console.WriteLine(sum2);
            Console.WriteLine(sum3);
            

            
            int x = 15;
            int y = 2;
            int z = 24;
              
            Console.WriteLine(x * y * z);
            */

            /*
             * C# Comparison Operators
              Comparison operators are used to compare two values:
            ==	Equal to	x == y
            !=	Not equal	x != y
            >	Greater than	x > y
            <	Less than	x < y
            >=	Greater than or equal to	x >= y
            <=	Less than or equal to	x <= y

             /*

            int x = 15;
            x *= 5;
            Console.WriteLine(x);

            int a = 34;
            a += 8;
            Console.WriteLine(a);

            int b = 45;
            b /= 8;
            Console.WriteLine(b);

            */

            Console.ReadKey();
        }
    }
}
