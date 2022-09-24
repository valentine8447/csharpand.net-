using System;

namespace Ch04Eh05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double balance, interestRate, targetBalance;
            Console.WriteLine("What is your current balance");
            balance = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your current annual interest rate (in %)?");
            interestRate = 1 + Convert.ToDouble(Console.ReadLine()) / 100.0;

            Console.WriteLine("What balance would you like to have ");
            targetBalance = Convert.ToDouble(Console.ReadLine());
            int totalYears = 0;


            while (balance < targetBalance)
            {
                balance *= interestRate;
                ++totalYears;
            }
            Console.WriteLine($"In {totalYears} year {(totalYears == 1 ? "" : "s")} you'll have a balance of {balance}");

            if (totalYears == 0)
            {
                Console.WriteLine("To be honest you really didnt need to use this calculator");
            }

            for (int i = 0; i < 10; i++)
            {
                if (i == 19)
                {


                    Console.WriteLine(i);
                    break;
                }
                Console.WriteLine(i + ", ");

            }
            Console.WriteLine();
            for (int i = 0; i < 20; i++)
            {
                if (i == 19)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(i + ", ");
                }
            }
        }
    }
}
                
        
   

 