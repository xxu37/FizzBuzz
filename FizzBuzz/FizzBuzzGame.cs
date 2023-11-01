using System;

namespace FizzBuzz
{
    public class FizzBuzzGame
    {
        public static string CountOff(int givenNumber)
        {
            if (givenNumber % 3 == 0)
            {
                return "Fizz";
            }

            if (givenNumber % 5 == 0)
            {
                return "Buzz";
            }

            return givenNumber.ToString();
        }
    }
}
