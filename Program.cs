using System;

namespace ConsoleAppUserImput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Username e Password!");
            Console.WriteLine("Enter Username");
            string userName = Console.ReadLine();
            Console.WriteLine("Username is: " + userName);

            Console.WriteLine("Enter Password");
            string passWord = Console.ReadLine();
            string Password = "J17031984a";
            Console.WriteLine("Password is: " + passWord);


            //User Input and Numbers
            Console.WriteLine("Enter your age:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Your age is: " + age);
            


            Console.ReadKey();
        }
    }
}
