using NUnit.Framework;

namespace RomanNumerals.Tests
{
    public class RomanNumeralShould
    {
        RomanNumeral romanNumeral = new RomanNumeral();

        
        [TestCase(1, "I")]
        [TestCase(2, "II")]
        [TestCase(3, "III")]
        [TestCase(4, "IV")]
        [TestCase(5, "V")]
        [TestCase(6, "VI")]
        public void return_roman_numeral_for_number(int input, string output)
        {
            Assert.AreEqual(output, romanNumeral.Convert(input));
        }
    }
}