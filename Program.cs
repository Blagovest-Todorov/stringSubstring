using System;

namespace _04.substrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Pesho Gosho";
            string substr = text.Substring(5);///remove all in text till index 4 , 
            //and gets all from index 5 till end of text 
            //gets all starting from index 5 till rest of the string
            Console.WriteLine(substr);
        }
    }
}
