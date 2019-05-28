using System;
using System.Collections.Generic;

namespace random_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Look at all these random numbers, what a smart cool thing");
            // Random is a class that represents a random number generator
            Random random = new Random();
            // Our list of numbers that are between one and 5.  .Next gives us a positive integer within that paraemeter.
            List<int> numbers = new List<int> {
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
            };

            for (int i = 0; i < numbers.Count; i++)
            {
            //    Here we are looping through our List of numbers and for each number, we are using .Contain to see if the current index position is one of our randomly generated numbers. If it is, we'll get a message telling us that and if not we will receive a message telling us that the random number list does NOT contain the number of that index position.

                if( numbers.Contains(i)) {
                    Console.WriteLine($"numbers list contains {i}");
                } 
                else {
                    Console.WriteLine($"numbers list does not contain {i}");
                }
            }
        }
    }
}
