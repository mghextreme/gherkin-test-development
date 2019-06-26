using Xunit;
using TechTalk.SpecFlow;

namespace Tests
{
    [Binding]
    public class Calculator
    {
        int firstNumber = 1;
        int secondNumber = 1;
        int sum = 0;
        int multiplication = 0;

        [Given(@"First number is (-?\d+)")]
        public void GivenFirstNumber(int number)
        {
            firstNumber = number;
        }

        [Given(@"Second number is (-?\d+)")]
        public void GivenSecondNumber(int number)
        {
            secondNumber = number;
        }

        [When(@"They are summed")]
        public void WhenTheyAreSummed()
        {
            sum = firstNumber + secondNumber;
        }

        [When(@"They are multiplied")]
        public void WhenTheyAreMultiplied()
        {
            multiplication = firstNumber * secondNumber;
        }

        [Then(@"Sum should be (-?\d+)")]
        public void ThenSumShouldBe(int expectedNumber)
        {
            Assert.Equal(expectedNumber, sum);
        }

        [Then(@"Multiplication should be (-?\d+)")]
        public void ThenMultiplicationShouldBe(int expectedNumber)
        {
            Assert.Equal(expectedNumber, multiplication);
        }
    }
}
