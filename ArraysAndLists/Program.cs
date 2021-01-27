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

                Console.WriteLine("odds");

                var odds = new List<int>();

                for (int b = 1; b < 11; b+=1)
                {
                    odds.Add(b);
                }
                foreach (var num in odds)
                {
                    Console.WriteLine(num);
                }

            }
            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */

            /* Now using foeach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
        }
    }
}
