using NUnit.Framework;

namespace RomanNumerals.Tests
{
    public class RomanNumeralShould
    {
        RomanNumeral romanNumeral = new RomanNumeral();

        
        [TestCase(1, "I")]
        public void return_roman_numeral_for_number(int input, string output)
        {
            Assert.AreEqual(output, romanNumeral.Convert(input));
        }
    }
}