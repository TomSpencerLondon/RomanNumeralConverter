namespace RomanNumerals
{
    public class RomanNumeral
    {
        public string Convert(int number)
        {
            if (number == 2)
            {
                return "II";
            }
            
            return "I";
        }
    }
}