// -----------------------------------------------------------------------
// <cleanup>
// Last Cleanup Code: 28.04.2019 20:10
// </cleanup>
// -----------------------------------------------------------------------

using Xunit;

namespace LeetCodeCSharp.Test
{
    public class ZigZagConversionTest
    {
        #region Public Methods

        [Fact]
        public void TestConvert()
        {
            // var result1 = ZigZagConversionSolution.Convert("PAYPALISHIRING", 3);
            var result2 = ZigZagConversionSolution.Convert("PAYPALISHIRING", 4);
            
            // Assert.Equal("PAHNAPLSIIGYIR", result1);
            Assert.Equal("PINALSIGYAHRPI", result2);
        }

        #endregion
    }
}
