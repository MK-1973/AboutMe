using System;

namespace AboutMe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myName = "Mikhail";
            byte myAge = 45;
            bool iHavePet = true;
            double myShoeSize = 43.5;

            Console.WriteLine("My name is " + myName);
            Console.WriteLine("My age is " + myAge);
            Console.WriteLine("Do I have a pet? " + iHavePet);
            Console.WriteLine("My shoe size is " + myShoeSize);
        }
    }
}
