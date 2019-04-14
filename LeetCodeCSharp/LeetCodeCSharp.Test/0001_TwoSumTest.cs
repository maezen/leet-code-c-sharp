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
            Assert.Equal(0, result1[0]);
            Assert.Equal(1, result1[1]);
            
            var result2 = TwoSumSolution.TwoSum(testArray, 22);
            Assert.Equal(1, result2[0]);
            Assert.Equal(3, result2[1]);
            
            var result3 = TwoSumSolution.TwoSum(testArray, 14);
            Assert.Empty(result3);
        }
    }
}
