using System;

namespace BadCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Bad Calculator!");
            Console.WriteLine("Enter the first number:");
            string input1 = Console.ReadLine();
            int number1 = int.Parse(input1);

            Console.WriteLine("Enter the second number:");
            string input2 = Console.ReadLine();
            int number2 = int.Parse(input2);

            Console.WriteLine("Enter the operation (+, -, *, /):");
            string operation = Console.ReadLine();

            int result = 0;
            if (operation == "+")
            {
                result = number1 + number2;
            }
            else if (operation == "-")
            {
                result = number1 - number2;
            }
            else if (operation == "*")
            {
                result = number1 * number2;
            }
            else if (operation == "/")
            {
                result = number1 / number2; // This will crash if number2 is 0
            }
            else
            {
                Console.WriteLine("Invalid operation!");
                return;
            }

            Console.WriteLine("The result is: " + result);
        }
    }
}
