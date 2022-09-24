using System;

namespace Ch04Eh4._01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int var1 = 5, var2 = 30;
            Console.WriteLine("What boolean test can you perform to determine one or the other");
            bool isGreaterThan10Var1 = var1 > 10;
            bool isGreaterThan10Var2 = var2 < var1;
            Console.WriteLine("isGreaterThan10Var1 ^ isGreaterThan10Var2");
            Console.WriteLine((var1 < 10) ^ (10 < var2));
        }
    }
}
