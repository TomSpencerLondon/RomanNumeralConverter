using System.Collections.Generic;
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
                {1, "I"}
            };

            return values;
        }
            public string Convert(int number)
        {

            StringBuilder result = new StringBuilder();

            int num = number;

            foreach (var v in RomanValueKey())
            {
                while (num > 0)
                {
                    result.Append(v.Value);
                    num--;
                }
            }

            return result.ToString();
        }
    }
}