using System;
using Xunit;
using CalculatorTest;

namespace CalculatorTest.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void AdditionTests()
        {
            //Arrange
            decimal firstNumber = 10.4M;
            decimal secondNumber = -7.3M;
            decimal expected = 3.1M;
            //Act
            decimal result = Program.Addition(firstNumber, secondNumber);
            //Assert
            Assert.Equal(result, expected);
        }

        [Fact]
        public void SubstractionTests()
        {
            //Arrange
            decimal firstNumber = 10.4M;
            decimal secondNumber = -7.3M;
            decimal expected = 17.7M;
            //Act
            decimal result = Program.Subtraction(firstNumber, secondNumber);
            //Assert
            Assert.Equal(result, expected);
        }

        [Fact]
        public void MultiplicationTests()
        {
            //Arrange
            decimal firstNumber = 10.4M;
            decimal secondNumber = -7.3M;
            decimal expected = -75.92M;
            //Act
            decimal result = Program.Multiplication(firstNumber, secondNumber);
            //Assert
            Assert.Equal(result, expected);
        }

        [Fact]
        public void DivisionTests()
        {
            //Arrange
            decimal firstNumber = 10.4M;
            decimal secondNumber = -7.3M;
            decimal expected = -1.424657M;
            //Act
            decimal result = Program.Division(firstNumber, secondNumber);
            //Assert
            Assert.Equal(result, expected, 4);
        }
    }
}
