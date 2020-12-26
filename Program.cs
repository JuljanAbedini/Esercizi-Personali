using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string greeting = "Hello World!";
            Console.WriteLine(greeting);

            //Length

            string txt = "hshdfjhhsdfjkhdsfjdjfdsjgfhfdsj";
            Console.WriteLine(txt.ToUpper());
            Console.WriteLine("the length must be only words: " + txt.Length);

            // ToUpper ToLower
            string words = "Hi Juli";
            Console.WriteLine(words.ToUpper());
            Console.WriteLine(words.ToLower());

            //String Concatenation
            string firstName = "Juljan";
            string lastname = "Abedini";
            string name = firstName + " " + lastname;
            Console.WriteLine(name.ToUpper());

            string primoNome = "Giorgio";
            string cognome = "Rossi";
            string nome = string.Concat(primoNome, " ", cognome);
            Console.WriteLine(nome.ToLower());
            */

            //String Interpolation
            /*
            string firstName = "Joel";
            string lastName = "Abedini";
            string name = $"{firstName} {lastName}";
            Console.WriteLine(name.ToUpper());
            */

            //Access Strings

            string myString = "Hello";
            Console.WriteLine(myString.ToUpper()[0]);
            Console.WriteLine(myString.ToUpper()[1]);
            Console.WriteLine(myString.ToUpper()[2]);
            Console.WriteLine(myString.ToUpper()[3]);
            Console.WriteLine(myString.ToUpper()[4]);
          
            //OR
            Console.WriteLine(myString.IndexOf("e"));

            //Substring

            //Full Name
            string name = "Juljan Abedini";

            //location of letter A
            int charPos = name.IndexOf("A");

            //get last name
            string lastName = name.Substring(charPos);

            Console.WriteLine(lastName.ToUpper());


            //Special Characters:

            // \"
            string txt = "Ne jemi \"CAME\" dhe vim nga Jugu i Shqiperise. ";
            Console.WriteLine(txt);

            // \'
            string word = "It\'s alright.";
            Console.WriteLine(word);

            //   \\
            string wordOne = "The character \\ is called backslash.";
            Console.WriteLine(wordOne);

            // \n   	New Line
            string wordtwo = "Tirane \nAlbania";
            Console.WriteLine(wordtwo);

            // \t   	Tab
            string wordThree = "Tirane \tAlbania";
            Console.WriteLine(wordThree);

            // \b   Backspace
            string wordFour = "Tirane \bAlbania";
            Console.WriteLine(wordFour);

            // C# uses the + operator for both addition and concatenation.
            // Remember: Numbers are added.Strings are concatenated.

            int x = 10;
            int y = 15;
            int z = x + y; // // z will be 30 (an integer/number)
            Console.WriteLine(z);

            string a = "10";
            string b = "25";
            string c = a + b; // // z will be 1020 (a string)
            Console.WriteLine(c);

            Console.ReadKey();
        }
    }
}
