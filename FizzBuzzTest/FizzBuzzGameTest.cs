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
    }
}