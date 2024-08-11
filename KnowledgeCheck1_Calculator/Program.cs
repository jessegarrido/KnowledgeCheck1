using System;

namespace KnowledgeCheck1_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            int selection;
            Console.Write("Hello. ");
            do
            {
                Console.WriteLine("Press 1 for addition, 2 for subtraction, 3 for multiplication, and 4 for division");
                selection = calculator.UserInput();
            } while (selection < 1 || selection > 4);
            Console.WriteLine($"You chose {selection}");
            Console.WriteLine("Enter the first integer: ");
            var numOne = calculator.UserInput();
            Console.WriteLine("Enter another integer: ");
            var numTwo = calculator.UserInput();
            switch (selection)
            {
                case 1:
                    Console.Write($"{numOne} + {numTwo} = ");
                    Console.Write(calculator.Add(numOne, numTwo));
                    break;
                case 2:
                    Console.Write($"{numOne} - {numTwo} = ");
                    Console.Write(calculator.Subtract(numOne, numTwo));
                    break;
                case 3:
                    Console.Write($"{numOne} * {numTwo} = ");
                    Console.Write(calculator.Multiply(numOne, numTwo));
                    break;
                case 4:
                    Console.Write($"{numOne} / {numTwo} = ");
                    Console.Write(calculator.Divide(numOne, numTwo));
                    break;
            }
        }
    }

}
