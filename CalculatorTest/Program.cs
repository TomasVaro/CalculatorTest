using System;

namespace CalculatorTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            decimal[] twoNumbers = new decimal[2];
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
                        decimal[] multipleNumbers;
                        decimal sum;
                        decimal diff;
                        while (running)
                        {
                            try
                            {
                                switch (userInput)
                                {
                                    case 1:
                                        twoNumbers = GetTwoNumbers();
                                        sum = Addition(twoNumbers[0], twoNumbers[1]);                                        
                                        Console.WriteLine(twoNumbers[0] + " + " + twoNumbers[1] + " = " + sum + "\n");
                                        break;
                                    case 2:
                                        multipleNumbers = GetMultipleNumbers();
                                        sum = Addition(multipleNumbers);
                                        for(int i = 0; i < multipleNumbers.Length; i++)
                                        {
                                            Console.Write(multipleNumbers[i]);
                                            if (i < multipleNumbers.Length - 1)
                                            {
                                                Console.Write(" + ");
                                            }
                                        }
                                        Console.WriteLine(" = " + sum);
                                        break;
                                    case 3:
                                        twoNumbers = GetTwoNumbers();
                                        diff = Subtraction(twoNumbers[0], twoNumbers[1]);
                                        Console.WriteLine(twoNumbers[0] + " - " + twoNumbers[1] + " = " + diff + "\n");
                                        break;
                                    case 4:
                                        multipleNumbers = GetMultipleNumbers();
                                        diff = Subtraction(multipleNumbers);
                                        for (int i = 0; i < multipleNumbers.Length; i++)
                                        {
                                            Console.Write(multipleNumbers[i]);
                                            if (i < multipleNumbers.Length - 1)
                                            {
                                                Console.Write(" - ");
                                            }
                                        }
                                        Console.WriteLine(" = " + diff);
                                        break;
                                    case 5:
                                        twoNumbers = GetTwoNumbers();
                                        decimal prod = Multiplication(twoNumbers[0], twoNumbers[1]);
                                        Console.WriteLine(twoNumbers[0] + " * " + twoNumbers[1] + " = " + prod + "\n");
                                        break;
                                    case 6:
                                        twoNumbers = GetTwoNumbers();
                                        decimal quotient = Division(twoNumbers[0], twoNumbers[1]);
                                        if (quotient == 0)
                                        {
                                            running = true;
                                            break;
                                        }
                                        Console.WriteLine(twoNumbers[0] + " / " + twoNumbers[1] + " = " + quotient + "\n");
                                        break;
                                }
                                running = false;
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
        static decimal[] GetTwoNumbers()
        {
            bool running = true;
            decimal[] twoNumbers = new decimal[2];
            while (running)
            {
                try
                {
                    Console.WriteLine();
                    Console.WriteLine("Enter the first number:");
                    twoNumbers[0] = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Enter the second number:");
                    twoNumbers[1] = Convert.ToDecimal(Console.ReadLine());
                    running = false;
                }
                catch
                {
                    Console.WriteLine("You must enter a digit or decimal number! Try again.");
                }
            }
            return twoNumbers;
        }
        static decimal[] GetMultipleNumbers()
        {
            bool running = true;
            decimal[] multipleNumbers = new decimal[] { };
            while (running)
            {
                try
                {
                    Console.WriteLine();
                    Console.WriteLine("Enter the numbers you want to add or subtract, separated with a space:");
                    string input = Console.ReadLine().Trim();
                    multipleNumbers = Array.ConvertAll(input.Split(' '), Decimal.Parse);
                    running = false;
                }
                catch
                {
                    Console.WriteLine("You must enter digits or decimal numbers! Try again.");
                }
            }
            return multipleNumbers;
        }
        public static decimal Addition(decimal firstNumber, decimal secondNumber)
        {
            decimal sum = firstNumber + secondNumber;
            return sum;
        }
        public static decimal Addition(decimal[] multipleNumbers)
        {
            decimal sum = 0;
            foreach (decimal number in multipleNumbers)
            {
                sum = sum + number;
            }
            return sum;
        }
        public static decimal Subtraction(decimal firstNumber, decimal secondNumber)
        {
            decimal diff = firstNumber - secondNumber;
            return diff;
        }
        public static decimal Subtraction(decimal[] multipleNumbers)
        {
            decimal diff = multipleNumbers[0] * 2;
            foreach (decimal number in multipleNumbers)
            {
                diff = diff - number;
            }
            return diff;
        }
        public static decimal Multiplication(decimal firstNumber, decimal secondNumber)
        {
            decimal prod = firstNumber * secondNumber;
            return prod;
        }
        public static decimal Division(decimal firstNumber, decimal secondNumber)
        {
            decimal quotient = 0;
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
