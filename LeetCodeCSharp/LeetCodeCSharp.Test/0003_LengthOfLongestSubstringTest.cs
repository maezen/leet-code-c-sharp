// -----------------------------------------------------------------------
// <cleanup>
// Last Cleanup Code: 16.04.2019 17:14
// </cleanup>
// -----------------------------------------------------------------------

using Xunit;

namespace LeetCodeCSharp.Test
{
    public class LengthOfLongestSubstringTest
    {
        [Fact]
        public void LengthOfLongestSubstringTest1()
        {
            var result = LengthOfLongestSubstringSolution.LengthOfLongestSubstring("abcabcbb");
            Assert.Equal(3, result);
        }

        [Fact]
        public void LengthOfLongestSubstringTest2()
        {
            var result = LengthOfLongestSubstringSolution.LengthOfLongestSubstring("bbbbb");
            Assert.Equal(1, result);
        }

        [Fact]
        public void LengthOfLongestSubstringTest3()
        {
            var result = LengthOfLongestSubstringSolution.LengthOfLongestSubstring("pwwkew");
            Assert.Equal(3, result);
        }
        
        [Fact]
        public void LengthOfLongestSubstringTest4()
        {
            var result = LengthOfLongestSubstringSolution.LengthOfLongestSubstring("aab");
            Assert.Equal(2, result);
        }
        
        [Fact]
        public void LengthOfLongestSubstringTest5()
        {
            var result = LengthOfLongestSubstringSolution.LengthOfLongestSubstring("dvdf");
            Assert.Equal(3, result);
        }
    }
}
