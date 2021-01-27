using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
            int[] myArray01 = new int[10];

            myArray01[0] = 1;
            myArray01[1] = 2;
            myArray01[2] = 3;
            myArray01[3] = 4;
            myArray01[4] = 5;
            myArray01[5] = 6;
            myArray01[6] = 7;
            myArray01[7] = 8;
            myArray01[8] = 9;
            myArray01[9] = 10;

            //Evens

            Console.WriteLine("evens");

            {
                var evens = new List<int>();

                for (int a = 2; a < 12; a+=2)
                {
                    evens.Add(a);
                }
                foreach (var num in evens)
                {
                    Console.WriteLine(num);
                }

                Console.WriteLine();

                //Odds
                
                Console.WriteLine("odds");

                var odds = new List<int>();

                for (int b = 1; b < 11; b+=2)
                {
                    odds.Add(b);
                }
                foreach (var num in odds)
                {
                    Console.WriteLine(num);
                }

            }
        }
    }
}
