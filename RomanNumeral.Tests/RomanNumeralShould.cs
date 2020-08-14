using NUnit.Framework;

namespace RomanNumerals.Tests
{
    public class RomanNumeralShould
    {
        RomanNumeral _romanNumeral = new RomanNumeral();

        
        [TestCase(1, "I")]
        [TestCase(2, "II")]
        [TestCase(3, "III")]
        [TestCase(4, "IV")]
        [TestCase(5, "V")]
        [TestCase(6, "VI")]
        [TestCase(14, "XIV")]
        [TestCase(1994, "MCMXCIV")]
        public void return_roman_numeral_for_number(int input, string output)
        {
            Assert.AreEqual(output, _romanNumeral.Convert(input));
        }

        [TestCase("I", 1)]
        [TestCase("II", 2)]
        [TestCase("III", 3)]
        [TestCase("IV", 4)]
        [TestCase("V", 5)]
        [TestCase("VI", 6)]
        [TestCase("XIV", 14)]
        [TestCase("MCMXCIV", 1994)]
        public void return_decimal_for_roman_numeral(string input, int output)
        {
            Assert.AreEqual(output, _romanNumeral.Modernise(input));
        }
    }
}