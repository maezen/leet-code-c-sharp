using Xunit;

namespace LeetCodeCSharp.Test
{
    public class PalindromeNumberTest
    {
        [Fact]
        public void TestIsPalindrome()
        {
            var palindrome = new PalindromeNumber();
            var value = 123454321;
            var result = palindrome.IsPalindrome(value);
            Assert.True(result);

            value = 1;
            result = palindrome.IsPalindrome(value);
            Assert.True(result);

            value = 1234554321;
            result = palindrome.IsPalindrome(value);
            Assert.True(result);

            value = -1234321;
            result = palindrome.IsPalindrome(value);
            Assert.False(result);
        }
    }
}