
using System.Text;

namespace _002_LexicographicallySmallestString
{
    public class Solution
    {
        public string LexicographicallySmallest(string input)
        {
            if (string.IsNullOrEmpty(input))
                return null;

            if (input.Length == 1)
                return string.Empty;

            StringBuilder output = new StringBuilder();

            char preCh = input[0];
            for (int i = 1; i < input.Length; i++)
            {
                if (preCh <= input[i])
                {
                    output.Append(preCh);
                    preCh = input[i]; continue;
                }

                output.Append(input.Substring(i, input.Length - i));
                break;
            }

            return output.ToString();
        }
    }
}
