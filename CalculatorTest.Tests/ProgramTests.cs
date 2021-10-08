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
            double firstNumber = 10.4;
            double secondNumber = -7.3;
            double expected = 3.1;
            //Act
            double result = Program.Addition(firstNumber, secondNumber);
            //Assert
            Assert.Equal(result, expected);
        }

        [Theory]        
        [InlineData(3.3, 4.4, 5.5, 6.6, 19.8) ]
        [InlineData(3.3, -4.4, 5.5, 6.6, 11) ]
        [InlineData(3.3, 0, 5.5, 6.6, 15.4) ]
        [InlineData(3.3, 4.4, 5.5, null, 13.2)]
        [InlineData(3.3, 4.4, 8888888888888888888, 6.6, 8888888888888888902)]
        public void AdditionMultipleNumbersTests(double n1, double n2, double n3, double n4, double expected)
        {
            //Arrange            

            //Act
            double[] testNumbers = { n1, n2, n3, n4 };
            double result = Program.Addition(testNumbers);
            // Assert
            Assert.Equal(result, expected, 0);
        }

        //[Theory]
        //[InlineData(new double[] { 8, 7.5, 6, 3 })]
        //public void AdditionMultipleNumbersTest(double[] testNumbers)
        //{
        //    //Arrange            

        //    //Act
        //    double[] testNumbers = { n1, n2, n3, n4 };
        //    double result = Program.Addition(testNumbers);
        //    // Assert
        //    Assert.Equal(result, expected, 0);
        //}


        [Fact]
        public void SubstractionTests()
        {
            //Arrange
            double firstNumber = 10.4;
            double secondNumber = -7.3;
            double expected = 17.7;
            //Act
            double result = Program.Subtraction(firstNumber, secondNumber);
            //Assert
            Assert.Equal(result, expected);
        }

        [Theory]
        [InlineData(33.3, 4.4, 5.5, 6.6, 16.8)]
        [InlineData(33.3, -4.4, 5.5, 6.6, 25.6)]
        [InlineData(33.3, 0, 5.5, 6.6, 21.2)]
        [InlineData(33.3, 4.4, 5.5, null, 23.4)]
        [InlineData(8888888888888, 9.5, 20.88, 30.54, 8888888888827.08)]
        public void SubtractionMultipleNumbersTests(double n1, double n2, double n3, double n4, double expected)
        {
            //Arrange            

            //Act
            double[] testNumbers = { n1, n2, n3, n4 };
            double result = Program.Subtraction(testNumbers);
            // Assert
            Assert.Equal(result, expected, 2);
        }

        [Fact]
        public void MultiplicationTests()
        {
            //Arrange
            double firstNumber = 10.4;
            double secondNumber = -7.3;
            double expected = -75.92;
            //Act
            double result = Program.Multiplication(firstNumber, secondNumber);
            //Assert
            Assert.Equal(result, expected);
        }

        [Fact]
        public void DivisionTests()
        {
            //Arrange
            double firstNumber = 10.4;
            double secondNumber = 7.9;
            double expected = 1.31646;
            //Act
            double result = Program.Division(firstNumber, secondNumber);
            //Assert
            Assert.Equal(result, expected, 4);

            //Arrange
            firstNumber = 10.4;
            secondNumber = 0;
            expected = 0;
            //Act
            result = Program.Division(firstNumber, secondNumber);
            //Assert
            Assert.Equal(result, expected);
        }
    }
}
