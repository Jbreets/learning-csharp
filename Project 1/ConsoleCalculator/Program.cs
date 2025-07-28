using System;

namespace ConsoleCalculator
{
    class Program 
    {
        static void Main(string[] args) 
        {

            Console.Write("Do you want to run Fizz? y/n ");
            string fizz = Console.ReadLine();

            if(fizz == "y")
                FizzBuzz();

            // Variable declaration
            while(true)
            {   
                double result;
                double numOne;
                string operation;
                double numTwo;
                string[] validOperators = { "+", "-", "*", "/" };

                // Error handling
                while (true) {
                    Console.Write("Enter first number: ");
                    if (double.TryParse(Console.ReadLine(), out numOne))
                        break;
                    Console.WriteLine("Not a valid Number Please try again");
                }

                while (true) {
                    Console.Write("Enter your operator: ");
                    string opInput = Console.ReadLine();

                    if (validOperators.Contains(opInput)) {
                        operation = opInput;
                        break;
                    }
                    Console.WriteLine("Not a valid operator. Please try again.");
                }

                while (true) {
                    Console.Write("Enter Second number: ");
                    if (double.TryParse(Console.ReadLine(), out numTwo))
                        break;
                    Console.WriteLine("Not a valid Number Please try again");
                }

                // Calculation switch case operation
                switch (operation) 
                {
                    case "+":
                        // Method call
                        result = Calculator.Add(numOne, numTwo);
                        Console.WriteLine(result);
                        break;
                    case "-":
                        // Method call
                        result = Calculator.Subtract(numOne, numTwo);
                        Console.WriteLine(result);
                        break;
                    case "*":
                        // Method call
                        result = Calculator.Multiply(numOne, numTwo);
                        Console.WriteLine(result);
                        break;
                    case "/":
                        // Method call
                        if (numOne == 0 || numTwo == 0)
                        {
                            Console.WriteLine("Undefined");
                        }
                        else 
                        {
                            result = Calculator.Divide(numOne, numTwo);
                            Console.WriteLine(result);
                        }
                        break;
                    default:
                        Console.WriteLine("Not a valid operator, please use +  -  * or /");
                        break;
                }

            Console.Write("Do you want to calculate again? (y/n): ");
            if (Console.ReadLine().ToLower() != "y")
                break;

            }
        }

        static void FizzBuzz() 
        {
            for (int i = 1; i<=100; i++)
            {
                if ( i % 3 == 0 && i % 5 == 0  ) 
                    Console.WriteLine("FizzBuzz");
                else if ( i % 3 == 0 )
                    Console.WriteLine("Fizz");
                else if ( i % 5 == 0 )
                    Console.WriteLine("Buzz");
                else 
                    Console.WriteLine(i);
            }
        }
    }
}