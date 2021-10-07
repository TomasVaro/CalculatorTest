using System;

namespace Calculator
{
    class Program
    {
        bool running = true;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Calculator\n");
            while (true)
            {
                Console.WriteLine("Choose one of the alternatives:\n" +
                    "1 - Addition two numbers\n" +
                    "2 - Addition multiple numbers\n" +
                    "3 - Subtraction two numbers\n" +
                    "4 - Subtraction multiple numbers\n" +
                    "5 - Multiplication\n" +
                    "6 - Division\n" +
                    "7 - End application\n");
                try
                {
                    int userInput = int.Parse(Console.ReadKey().KeyChar.ToString());
                    Console.WriteLine();
                    if (userInput > 0 && userInput < 7)
                    {
                        bool running = true;
                        double[] twoNumbers = new double[2];
                        while (running)
                        {
                            double firstNumber;
                            double secondNumber;
                            try
                            {
                                //Console.WriteLine();
                                //Console.WriteLine("Enter the first number or numbers (separated with a space):");
                                //string input = Console.ReadLine();
                                //double[] inputArray = Array.ConvertAll(input.Split(' '), Double.Parse);
                                //double firstNumber = Convert.ToDouble(Console.ReadLine());
                                //Console.WriteLine("Enter the second or numbers (separated with a space):");
                                //double secondNumber = Convert.ToDouble(Console.ReadLine());
                                running = false;
                                switch (userInput)
                                {
                                    case 1:
                                        twoNumbers = (double[])GetTwoNumbers();
                                        firstNumber = twoNumbers[0];
                                        secondNumber = twoNumbers[1];
                                        double sum = Addition(firstNumber, secondNumber);
                                        
                                        Console.WriteLine(firstNumber + " + " + secondNumber + " = " + sum + "\n");
                                        break;
                                    case 2:
                                        //double sum = Addition(firstNumber, secondNumber);
                                        //Console.WriteLine(firstNumber + " + " + secondNumber + " = " + sum + "\n");
                                        break;
                                    case 3:
                                        twoNumbers = (double[])GetTwoNumbers();
                                        firstNumber = twoNumbers[0];
                                        secondNumber = twoNumbers[1];
                                        double diff = Subtraction(firstNumber, secondNumber);
                                        Console.WriteLine(firstNumber + " - " + secondNumber + " = " + diff + "\n");
                                        break;
                                    case 4:
                                        //double diff = Subtraction(firstNumber, secondNumber);
                                        //Console.WriteLine(firstNumber + " - " + secondNumber + " = " + diff + "\n");
                                        break;
                                    case 5:
                                        twoNumbers = (double[])GetTwoNumbers();
                                        firstNumber = twoNumbers[0];
                                        secondNumber = twoNumbers[1];
                                        double prod = Multiplication(firstNumber, secondNumber);
                                        Console.WriteLine(firstNumber + " * " + secondNumber + " = " + prod + "\n");
                                        break;
                                    case 6:
                                        twoNumbers = (double[])GetTwoNumbers();
                                        firstNumber = twoNumbers[0];
                                        secondNumber = twoNumbers[1];
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
                    else if (userInput == 7)
                    {
                        Console.WriteLine("\nThank you for using the application! Welcome back!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("You must enter a digit between 1-7! Try again.\n");
                    }
                }
                catch
                {
                    Console.WriteLine("\nYou must enter a digit! Try again.\n");
                }
            }
        }
        static Array GetTwoNumbers()
        {
            bool running = true;
            double[] twoNumbers = new double[2];
            while (running)
            {
                try
                {
                    Console.WriteLine();
                    Console.WriteLine("Enter the first number:");
                    twoNumbers[0] = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter the second number:");
                    twoNumbers[1] = Convert.ToDouble(Console.ReadLine());
                    running = false;
                }
                catch
                {
                    Console.WriteLine("You must enter a digit or decimal number! Try again.");
                }
            }
            return twoNumbers;
        }

        static double Addition(double firstNumber, double secondNumber)
        {
            double sum = firstNumber + secondNumber;
            return sum;
        }
        static double Addition(Array inputArray)
        {
            return 1.2;
        }
        static double Subtraction(double firstNumber, double secondNumber)
        {
            double diff = firstNumber - secondNumber;
            return diff;
        }
        static double Subtraction(Array inputArray)
        {
            return 1.2;
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
