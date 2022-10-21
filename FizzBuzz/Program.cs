using System;
using System.Threading;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter a number: ");
            int iNumber;
            bool isTrue = int.TryParse(Console.ReadLine(),out iNumber);
            if (isTrue)
            {
                if (iNumber % 3 == 0 && iNumber % 5 != 0)
                    Console.WriteLine("Fizz");
                else if (iNumber % 5 == 0 && iNumber % 3 != 0)
                    Console.WriteLine("Buzz");
                else if (iNumber % 3 == 0 && iNumber % 5 == 0)
                    Console.WriteLine("Fizzbuzz");
                else
                    for (int i = 0; i < iNumber; i++)
                    {
                        Console.WriteLine(i + 1);
                    }
            }
            else
            {
                Console.WriteLine("Invalid interger value!");
                Main(args);
            }
              
            Console.ReadLine();



        }
    }
}
