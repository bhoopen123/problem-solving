
using System.Text;
using System.Collections.Generic;

namespace _001_SplitSentence
{
    public class Solution
    {
        /// <summary>
        /// should split a given sentence into words, but words within double quotes will be considered a single word.
        /// </summary>
        /// <param name="sentence"></param>
        /// <returns></returns>
        public string[] SplitSentence(string sentence)
        {
            if (sentence == null)
                return null;

            if (sentence == string.Empty)
                return new string[1] { sentence };

            List<string> words = new List<string>();

            StringBuilder word = new StringBuilder();

            for (int i = 0; i < sentence.Length; i++)
            {
                char ch = sentence[i];
                if (ch == ' ')
                {
                    words.Add(word.ToString());
                    word = new StringBuilder();
                    continue;
                }
                else if (ch == '"')
                {
                    ch = sentence[++i];
                    while (ch != '"')
                    {
                        word.Append(ch);
                        ch = sentence[++i];
                    }
                    i++;

                    words.Add(word.ToString());
                    word = new StringBuilder();
                    continue;
                }

                word.Append(ch);
            }

            if (!string.IsNullOrEmpty(word.ToString()))
                words.Add(word.ToString());

            return words.ToArray();
        }
    }
}
