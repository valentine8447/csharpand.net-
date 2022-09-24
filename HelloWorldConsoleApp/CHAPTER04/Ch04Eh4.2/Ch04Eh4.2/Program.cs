using System;

namespace Ch04Eh4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            bool flag = false;

            do
            {
                Console.WriteLine("Enter the first number: ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the second number: ");
                num2 = Convert.ToInt32(Console.ReadLine());



                flag = num1 > 10 ^ num2 > 10;
                if (!flag)
                {
                    Console.WriteLine("Enter new numbers!");
                }


            } while (!flag);

                Console.WriteLine("You've enter exctly one number greater than 10!");
            }
            }

    }
            
        
