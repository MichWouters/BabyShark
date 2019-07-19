using System;
using System.Threading;

namespace BabyShark
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sharks = new string[] { "Baby Shark", "Mommy Shark", "Daddy Shark", "Grandma Shark", "Grandpa Shark", "Let's go hunt", "Run away", "Safe at last", "It's the end" };

            foreach (string shark in sharks)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine($"{shark} doo doo doo doo doo doo.");
                    Thread.Sleep(1000);
                }

                Console.WriteLine($"{shark}!");
                Console.WriteLine();
                Thread.Sleep(1000);
            }

            Console.ReadLine();
        }
    }
}
