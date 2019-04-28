// -----------------------------------------------------------------------
// <cleanup>
// Last Cleanup Code: 28.04.2019 17:13
// </cleanup>
// -----------------------------------------------------------------------

namespace LeetCodeCSharp
{
    public static class ReverseIntegerSolution
    {
        #region Public Methods

        public static int Reverse(int x)
        {
            long result = 0;
            var negative = x < 0;

            if (negative) { x = x * -1; }

            while (x > 0)
            {
                var m = x % 10;
                x = x / 10;
                result = result * 10 + m;
            }

            if (negative) { result = result * -1; }

            return (int) (result < int.MinValue || result > int.MaxValue ? 0 : result);
        }

        #endregion
    }
}
