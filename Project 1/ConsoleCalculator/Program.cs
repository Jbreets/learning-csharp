using System;

namespace ConsoleCalculator
{
    class Program 
    {
        static void Main(string[] args) 
        {

            // Loop the app so that it runs until closed
            while(true)
            {   
                // ensure character is correct within call
                Console.WriteLine("Input your first Number: ");
                string numberOne = Console.ReadLine();

                Console.WriteLine("Input your Operator: ");
                string operation = Console.ReadLine();
                while (operation != )

                Console.WriteLine("Input your Second Number: ");
                string numberTwo = Console.ReadLine(); 


                // Updated double call to add character Parse
                double result;
                if(!double.TryParse(numberOne, out double numOne) ||
                   !double.TryParse(numberTwo, out double numTwo))
                {
                    Console.WriteLine("Character is undefined please enter correct character!");
                    return;
                }
                // double numOne = Convert.ToDouble(numberOne);
                // double numTwo = Convert.ToDouble(numberTwo);


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
    }
}

