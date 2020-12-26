using System;

namespace If_Else
{
    class Program
    {
        static void Main(string[] args)
        {
            // C# Conditions and If Statements

            /*

            Use if to specify a block of code to be executed, if a specified condition is true
            Use else to specify a block of code to be executed, if the same condition is false
            Use else if to specify a new condition to test, if the first condition is false
            Use switch to specify many alternative blocks of code to be executed
            */

            Console.WriteLine("Hello Juli ");

            if (20>18)
            {
                Console.WriteLine("20 is greater than 18");
            }

            int x = 23;
            int y = 18;
            
            if (x>y)
            {
                Console.WriteLine("x is greater than y");
            }


            //The else Statement: Use the else statement to specify a block of code to be executed if the condition is False.


            int time = 20;
            if (time < 18)
            {
                Console.WriteLine("Good Day");
            }
            else
            {
                Console.WriteLine("Good Night");
            }

            // The   else if   Statement: Use the else if statement to specify a new condition if the first condition is False.

            int time1 = 35;
            if (time1 > 31)
            {
                Console.WriteLine("Good Morning");
            }
            else if (time1 < 38)
            {
                Console.WriteLine("Goog Day");
            }
            else
            {
                Console.WriteLine("Good Night");
            }


            // Short Hand If...Else (Ternary Operator)

            int time2 = 26;
            if (time2 < 20)
            {
                Console.WriteLine("Good Day");
            }
            else
            {
                Console.WriteLine("Good Evening");
            }

            //if else

            int time3 = 26;
            string result = (time3 > 19) ? "Good Day" : "Good Night";
            Console.WriteLine(result);


            Console.ReadKey();
        }
    }
}
