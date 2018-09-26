using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            string message = ", my name is Khail Saboor and I'm going to become a Software Engineer";
            Console.WriteLine("Hello World!" + message);
            /**
             * this is String Interpolation
             * NOTE: just like the node.js app I was writing the other day.
             */
            Console.WriteLine($"Hello World {message}.");
            
            /**
             * Interpolation with two variables
             */
            string bestFriend = "Fred";
            string girlfriend = "Amy";
            
            Console.WriteLine($"{bestFriend} is my best friend and {girlfriend} is my girl friend.");
        }
    }
}