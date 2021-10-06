using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Calculator\n");
            while (true)
            {
                Console.WriteLine("Choose one of the alternatives:\n1 - Addition\n2 - Subtraction\n3 - Multiplication\n4 - Division\n5 - End application");
                try
                {
                    int userInput = int.Parse(Console.ReadKey().KeyChar.ToString());
                    Console.WriteLine();
                    if (userInput > 0 && userInput < 5)
                    {
                        bool running = true;
                        while (running)
                        {
                            try
                            {
                                Console.WriteLine();
                                Console.WriteLine("Enter the first number:");
                                double firstNumber = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Enter the second number:");
                                double secondNumber = Convert.ToDouble(Console.ReadLine());
                                running = false;
                                switch (userInput)
                                {
                                    case 1:
                                        double sum = Addition(firstNumber, secondNumber);
                                        Console.WriteLine(firstNumber + " + " + secondNumber + " = " + sum + "\n");
                                        break;
                                    case 2:
                                        double diff = Subtraction(firstNumber, secondNumber);
                                        Console.WriteLine(firstNumber + " - " + secondNumber + " = " + diff + "\n");
                                        break;
                                    case 3:
                                        double prod = Multiplication(firstNumber, secondNumber);
                                        Console.WriteLine(firstNumber + " * " + secondNumber + " = " + prod + "\n");
                                        break;
                                    case 4:
                                        double quotient = Division(firstNumber, secondNumber);
                                        if (quotient == 0)
                                        {
                                            running = true;
                                            break;
                                        }
                                        Console.WriteLine(firstNumber + " / " + secondNumber + " = " + quotient + "\n");
                                        break;
                                }
                            }
                            catch
                            {
                                Console.WriteLine("You must enter a digit or decimal number! Try again.");
                            }
                        }
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else if (userInput == 5)
                    {
                        Console.WriteLine("\nThank you for using the application! Welcome back!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("You must enter a digit between 1-5! Try again.\n");
                    }
                }
                catch
                {
                    Console.WriteLine("\nYou must enter a digit! Try again.\n");
                }
            }
        }
        static double Addition(double firstNumber, double secondNumber)
        {
            double sum = firstNumber + secondNumber;
            return sum;
        }
        static double Subtraction(double firstNumber, double secondNumber)
        {
            double diff = firstNumber - secondNumber;
            return diff;
        }
        static double Multiplication(double firstNumber, double secondNumber)
        {
            double prod = firstNumber * secondNumber;
            return prod;
        }
        static double Division(double firstNumber, double secondNumber)
        {
            double quotient = 0;
            if (secondNumber == 0)
            {
                Console.WriteLine("It's not allowed to divide by zero! Try again.\n");
            }
            else
            {
                quotient = firstNumber / secondNumber;
            }
            return quotient;
        }
    }
}
