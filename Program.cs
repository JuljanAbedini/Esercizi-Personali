using System;

namespace Variables

{
    class Program
    {
        static void Main(string[] args)
        {
            /*
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

             Console.WriteLine("Explicit Casting");    //Manual casting: double to int 
             double myDouble1 = 9.75;
             int myInt1 = (int)myDouble1;

             Console.WriteLine(myDouble1);
             Console.WriteLine(myInt1);  
            */

            int myInt = 11;
            double myDouble = 6.25;
            bool myBool = true;
            string myString = "Ciao";
            char myChar = 'C';


            Console.WriteLine(Convert.ToString(myInt));   //convert int to string
            Console.WriteLine(Convert.ToDouble(myInt));   //convert double to int
            Console.WriteLine(Convert.ToInt32(myDouble)); //convert double to int
            Console.WriteLine(Convert.ToString(myBool)); //convert bool to string
            Console.WriteLine(Convert.ToString(myChar));  //convert char to string
              
            


            


           


            Console.ReadKey();
        }
    }
}
