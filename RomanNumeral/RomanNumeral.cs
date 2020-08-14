using System.Text;

namespace RomanNumerals
{
    public class RomanNumeral
    {
        public string Convert(int number)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 1; i <= number; i++)
            {
                result.Append("I");
            }

            return result.ToString();
        }
    }
}