using System;
using Xunit;
using CalculatorTest;

namespace CalculatorTest.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void AdditionTwoNumbersTests()
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

        [Theory]        
        [InlineData(3.3, 4.4, 5.5, 6.6, 19.8) ]
        [InlineData(3.3, -4.4, 5.5, 6.6, 11) ]
        [InlineData(3.3, 0, 5.5, 6.6, 15.4) ]
        [InlineData(3.3, 4.4, 5.5, null, 13.2)]
        [InlineData(3.3, 4.4, 8888888888888888888, 6.6, 8888888888888888902)]
        public void AdditionMultipleNumbersTests(decimal n1, decimal n2, decimal n3, decimal n4, decimal expected)
        {
            //Arrange            

            //Act
            decimal[] testNumbers = { n1, n2, n3, n4 };
            decimal result = Program.Addition(testNumbers);
            // Assert
            Assert.Equal(result, expected, 0);
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

        [Theory]
        [InlineData(33.3, 4.4, 5.5, 6.6, 16.8)]
        [InlineData(33.3, -4.4, 5.5, 6.6, 25.6)]
        [InlineData(33.3, 0, 5.5, 6.6, 21.2)]
        [InlineData(33.3, 4.4, 5.5, null, 23.4)]
        [InlineData(8888888888888, 9.5, 20.88, 30.54, 8888888888827.08)]
        public void SubtractionMultipleNumbersTests(decimal n1, decimal n2, decimal n3, decimal n4, decimal expected)
        {
            //Arrange            

            //Act
            decimal[] testNumbers = { n1, n2, n3, n4 };
            decimal result = Program.Subtraction(testNumbers);
            // Assert
            Assert.Equal(result, expected, 2);
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
            decimal secondNumber = 0M;
            decimal expected = 0M;
            //Act
            decimal result = Program.Division(firstNumber, secondNumber);
            //Assert
            Assert.Equal(result, expected, 4);
        }
    }
}
