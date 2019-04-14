// -----------------------------------------------------------------------
// <cleanup>
// Last Cleanup Code: 14.04.2019 15:22
// </cleanup>
// -----------------------------------------------------------------------

#region

using System.Collections.Generic;

#endregion

namespace LeetCodeCSharp
{
    public class TwoSumSolution
    {
        #region Public Methods

        public static int[] TwoSum(int[] nums, int target)
        {
            var dict = new Dictionary<int, int>();

            for (var i = 0; i < nums.Length; i++)
            {
                var index = nums[i];
                var n = target - index;

                if (dict.ContainsKey(n)) { return new[] {dict[n], i}; }

                dict[index] = i;
            }

            return new int[0];
        }

        #endregion
    }
}
