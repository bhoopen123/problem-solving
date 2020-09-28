
using Xunit;

namespace _001_SplitSentence
{
    public class SolutionShould
    {
        Solution sol = null;

        public SolutionShould()
        {
            sol = new Solution();
        }

        [Fact]
        public void HandleNullSentence()
        {
            string input = null;

            string[] expected = null;
            string[] actual = sol.SplitSentence(input);

            Assert.Equal(actual, expected);
        }

        [Fact]
        public void HandleEmptySentence()
        {
            string input = string.Empty;
            string[] expected = new string[1] { "" };
            string[] actual = sol.SplitSentence(input);

            Assert.Equal(actual, expected);
        }

        [Fact]
        public void SplitSentenceWithOneWord()
        {
            string input = "Hello";
            string[] expected = new string[1] { "Hello" };
            string[] actual = sol.SplitSentence(input);

            Assert.Equal(actual, expected);
        }

        [Fact]
        public void SplitSentenceHavingMultipleWords()
        {
            string input = "This is a sentence";
            string[] expected = new string[] { "This", "is", "a", "sentence" };
            string[] actual = sol.SplitSentence(input);

            Assert.Equal(actual, expected);
        }

        [Fact]
        public void SplitSentenceHavingOneDoubleQuotes()
        {
            string input = "This is a sentence \"with double quotes\"";
            string[] expected = new string[] { "This", "is", "a", "sentence", "with double quotes" };
            string[] actual = sol.SplitSentence(input);

            Assert.Equal(actual, expected);
        }

        [Fact]
        public void SplitSentenceHavingMultipleDoubleQuotes()
        {
            string input = "This is a sentence \"with one double quotes\" and \"another double quotes\"";
            string[] expected = new string[] { "This", "is", "a", "sentence", "with one double quotes", "and", "another double quotes" };
            string[] actual = sol.SplitSentence(input);

            Assert.Equal(actual, expected);
        }
    }
}
