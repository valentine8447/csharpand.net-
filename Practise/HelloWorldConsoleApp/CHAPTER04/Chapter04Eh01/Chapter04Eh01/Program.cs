using System;

namespace Chapter04Eh01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer:");
            int myInt = Convert.ToInt32(Console.ReadLine());
            bool isLessThan10 = myInt < 10;
            bool isBetween0And5 = (0 <= myInt) && (myInt <= 5);
            Console.WriteLine($"Integer less than 10? {isLessThan10}");
            Console.WriteLine($"Integer between 0 and 5? {isBetween0And5}");
            Console.WriteLine($"Exactly one of above is true? " +
                $"{isLessThan10 ^ isBetween0And5}");
            Console.ReadKey();

            string myString = "The number is ";
            myString += myInt < 10 ? "less than 10" : "greater than 10";
            Console.WriteLine(myString);
        }
    }
}

