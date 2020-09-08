using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
               Console.WriteLine("How old are you?");
               string UserInput;
               int Age;
               UserInput = Console.ReadLine();
               Age = Int32.Parse(UserInput);

            if (Age < 18)
            {
             Console.WriteLine($"You are too young to qualify for a drivers license.");
            }
            else if (Age > 18)
            {
             Console.WriteLine($"You are old enough to qualify for a drivers license.");
            }else
             Console.WriteLine($"You are eligible to get a drivers license.");
                   

        }
    }
}
