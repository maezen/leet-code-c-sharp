// -----------------------------------------------------------------------
// <cleanup>
// Last Cleanup Code: 14.04.2019 14:49
// </cleanup>
// -----------------------------------------------------------------------

using Xunit;

namespace LeetCodeCSharp.Test
{
    public class TwoSumTest
    {
        [Fact]
        public void TestTwoSum()
        {
            var testArray = new[] {2, 7, 11, 15};
            
            var result1 = TwoSumSolution.TwoSum(testArray, 9);
            Assert.Equal(result1[0], 0);
            Assert.Equal(result1[1], 1);
            
            var result2 = TwoSumSolution.TwoSum(testArray, 22);
            Assert.Equal(result2[0], 1);
            Assert.Equal(result2[1], 3);
            
            var result3 = TwoSumSolution.TwoSum(testArray, 14);
            Assert.Equal(result3.Length, 0);
        }
    }
}
