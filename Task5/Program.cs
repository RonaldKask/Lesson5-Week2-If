using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your favorite pet");
            string UserInput = Console.ReadLine();

            //Console.WriteLine($"You are a {UserInput} person.");

            if (UserInput == "cat")
            {
                Console.WriteLine("You are a homebird.");
            }else if (UserInput == "dog")
            {
                Console.WriteLine("You are a party animal.");
            }else
            {
                Console.WriteLine($"You are a {UserInput} lover");
            }
        }
    }
}
