using System;

namespace GettingUserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your name: ");
            string username = Console.ReadLine();

            Console.WriteLine("Welcome " + username);

            // Asking for numbers
            Console.Write("Please enter your age: ");
            string userInput = Console.ReadLine();
            int age = Convert.ToInt32(userInput);

            Console.WriteLine("Wow, you are " + age + " years of age");

            // Asking number the short way
            Console.Write("Please enter your height: ");
            double height = Convert.ToDouble(Console.ReadLine());
                    // Take user input as argument

            Console.WriteLine("Cool, " + height + "m tall?");

            // Random numbers
            Random generator = new Random();

            int number1 = generator.Next();
            int number2 = generator.Next();

            Console.WriteLine("Numbers: " + number1 + " " + number2);

            // Limited
            int dieThrow = generator.Next(1, 7);

            Console.WriteLine("Die throw: " + dieThrow);

        }
    }
}
