using System;

namespace Variables

{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "John";
            string surname = "McCain";
            Console.WriteLine("Hello " + name + " " + surname);

            Console.WriteLine("Variables ");
           
            int myNum = 5;                  //intiger (whole number)
            double mydouble = 5.5;          // floating point number
            char myChar = 'J';              // character
            string myString = "Abedini";    // string
            bool myBool = true;            // boolean

            Console.WriteLine(myNum + "\n" + mydouble + "\n" + myChar + "\n" + myString + "\n" + myBool);

            Console.WriteLine("Implicit Casting");
            int myInt = 9;                              
            double myDouble = myInt;
            Console.WriteLine(myInt + "\n" + myDouble);



            


           


            Console.ReadKey();
        }
    }
}
