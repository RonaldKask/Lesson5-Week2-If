using System;

namespace Week2IfStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            int Age;
            string Userinput;

            Console.WriteLine("How old are you?");
            Userinput = Console.ReadLine();
            Age = Int32.Parse(Userinput);

            if(Age < 18)
            {
               Console.WriteLine($"you are {Age}, you are too young.");
            } else if (Age > 18)
            {
               Console.WriteLine($"you are {Age}, you are old enough");
            } else
            {
               Console.WriteLine($"Congratulations! you are {Age}");
            }

        }
    }
}
