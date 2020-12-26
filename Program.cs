using System;

namespace Booleans
{
    class Program
    {
        static void Main(string[] args)
        {
            // A boolean type is declared with the bool keyword and can only take the values true or false:

            bool isCSharpFun = true;
            bool isFishTasty = false;

            Console.WriteLine(isCSharpFun);
            Console.WriteLine(isFishTasty);
            
            int x = 82;
            int y = 56;
            Console.WriteLine(x < y); // returns False, because 82 is higher than 56

            int a = 12;
            Console.WriteLine(a == 12); // returns True, because the value of x is equal to 12

            Console.WriteLine(10 == 15); // returns False, because 10 is not equal to 15

            Console.ReadKey();
        }
    }
}
