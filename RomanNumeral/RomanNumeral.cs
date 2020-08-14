using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;

namespace RomanNumerals
{
    public class RomanNumeral
    {
        public static Dictionary<int, string> RomanValueKey()
        {
            Dictionary<int, string> values = new Dictionary<int, string>
            {
                {1000, "M"},
                {900, "CM"},
                {500, "D"},
                {400, "CD"},
                {100, "C"},
                {90, "XC"},
                {50, "L"},
                {40, "XL"},
                {10, "X"},
                {5, "V"},
                {4, "IV"},
                {1, "I"}
            };

            return values;
        }
        
        public static Dictionary<char, int> ArabicValueKey()
        {
            Dictionary<char, int> decimals = new Dictionary<char, int>
            {
                {'M', 1000},
                {'D', 500},
                {'C', 100},
                {'L', 50},
                {'X', 10},
                {'V', 5},
                {'I', 1}
            };

            return decimals;
        }
        public string Convert(int number){
            StringBuilder result = new StringBuilder();
            foreach (var item in RomanValueKey())
            {
                while (number >= item.Key)
                {
                    result.Append(item.Value);
                    number -= item.Key;    
                }
            }

            return result.ToString();
        }

        public int Modernise(string numeral)
        {
            var array = numeral.ToCharArray();
            var result = ArabicValueKey()[array.Last()];

            for (int i = numeral.Length - 2; i >= 0; i--)
            {
                if (ArabicValueKey()[array[i]] < ArabicValueKey()[array[i + 1]])
                {
                    result -= ArabicValueKey()[array[i]];
                }else {
                    result += ArabicValueKey()[array[i]];
                }

            }

            return result;

        }
    }
}