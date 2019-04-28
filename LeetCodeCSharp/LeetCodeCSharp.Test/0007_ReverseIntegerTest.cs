// -----------------------------------------------------------------------
// <cleanup>
// Last Cleanup Code: 28.04.2019 16:50
// </cleanup>
// -----------------------------------------------------------------------

using Xunit;

namespace LeetCodeCSharp.Test
{
    public class ReverseIntegerTest
    {
        [Fact]
        public void TestReverseInteger()
        {
            var result1 = ReverseIntegerSolution.Reverse(123);
            var result2 = ReverseIntegerSolution.Reverse(-123);
            var result3 = ReverseIntegerSolution.Reverse(120);
            var result4 = ReverseIntegerSolution.Reverse(1534236469);

            Assert.Equal(result1, 321);
            Assert.Equal(result2, -321);
            Assert.Equal(result3, 21);
            Assert.Equal(result4, 0);
            
        }
    }
}
