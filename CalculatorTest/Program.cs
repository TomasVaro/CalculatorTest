﻿using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] twoNumbers = new double[2];
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
                        double[] multipleNumbers;
                        double sum;
                        double diff;
                        while (running)
                        {
                            try
                            {
                                switch (userInput)
                                {
                                    case 1:
                                        twoNumbers = (double[])GetTwoNumbers();
                                        sum = Addition(twoNumbers[0], twoNumbers[1]);                                        
                                        Console.WriteLine(twoNumbers[0] + " + " + twoNumbers[1] + " = " + sum + "\n");
                                        break;
                                    case 2:
                                        multipleNumbers = (double[])GetMultipleNumbers();
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
                                        twoNumbers = (double[])GetTwoNumbers();
                                        diff = Subtraction(twoNumbers[0], twoNumbers[1]);
                                        Console.WriteLine(twoNumbers[0] + " - " + twoNumbers[1] + " = " + diff + "\n");
                                        break;
                                    case 4:
                                        multipleNumbers = (double[])GetMultipleNumbers();
                                        Subtraction(multipleNumbers);
                                        diff = Subtraction(multipleNumbers);
                                        //Console.WriteLine(firstNumber + " - " + secondNumber + " = " + diff + "\n");
                                        break;
                                    case 5:
                                        twoNumbers = (double[])GetTwoNumbers();
                                        double prod = Multiplication(twoNumbers[0], twoNumbers[1]);
                                        Console.WriteLine(twoNumbers[0] + " * " + twoNumbers[1] + " = " + prod + "\n");
                                        break;
                                    case 6:
                                        twoNumbers = (double[])GetTwoNumbers();
                                        double quotient = Division(twoNumbers[0], twoNumbers[1]);
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
        static Array GetMultipleNumbers()
        {
            bool running = true;
            double[] multipleNumbers = new double[] { };
            while (running)
            {
                try
                {
                    Console.WriteLine();
                    Console.WriteLine("Enter the numbers you want to add, separated with a space:");
                    string input = Console.ReadLine();
                    multipleNumbers = Array.ConvertAll(input.Split(' '), Double.Parse);
                    running = false;
                }
                catch
                {
                    Console.WriteLine("You must enter digits or decimal numbers! Try again.");
                }
            }
            return multipleNumbers;
        }
        static double Addition(double firstNumber, double secondNumber)
        {
            double sum = firstNumber + secondNumber;
            return sum;
        }
        static double Addition(Array multipleNumbers)
        {
            double sum = 0;
            foreach (double number in multipleNumbers)
            {
                sum = sum + number;
            }
            return sum;
        }
        static double Subtraction(double firstNumber, double secondNumber)
        {
            double diff = firstNumber - secondNumber;
            return diff;
        }
        static double Subtraction(Array multipleNumbers)
        {
            double diff = 0;
            foreach (double number in multipleNumbers)
            {
                diff = diff - number;
            }
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
