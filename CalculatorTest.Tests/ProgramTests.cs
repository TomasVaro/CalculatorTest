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
    }
}
