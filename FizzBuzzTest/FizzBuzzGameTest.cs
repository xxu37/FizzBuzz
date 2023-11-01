using FizzBuzz;
using Xunit;

namespace FizzBuzzTest
{
    public class FizzBuzzGameTest
    {
        [Fact]
        public void Should_return_the_number_given_when_countOff_given_a_normal_case_number()
        {
            // Given
            int givenNumber = 1;
            // When
            string result = FizzBuzzGame.CountOff(givenNumber);
            // Then
            Assert.Equal("1", result);
        }

        [Fact]
        public void Should_return_fizz_when_countOff_given_a_multiple_of_3()
        {
            // Given
            int givenNumber = 3;
            // When
            string result = FizzBuzzGame.CountOff(givenNumber);
            // Then
            Assert.Equal("Fizz", result);
        }
    }
}