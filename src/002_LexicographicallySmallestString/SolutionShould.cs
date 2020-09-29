
using Xunit;

namespace _002_LexicographicallySmallestString
{
    public class SolutionShould
    {
        Solution solution = null;
        public SolutionShould()
        {
            solution = new Solution();
        }

        [Theory]
        //          input   expected
        [InlineData("abcda", "abca")]
        [InlineData("hello", "ello")]
        [InlineData("abcde", "abcd")]
        [InlineData("adddd", "addd")]
        [InlineData(null, null)]
        [InlineData("", null)]
        [InlineData("d", "")]
        [InlineData("da", "a")]
        public void ReturnLexicographicallySmallest(string input, string expected)
        {
            string actual = solution.LexicographicallySmallest(input);

            Assert.Equal(expected, actual);
        }
    }
}
