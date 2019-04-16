// -----------------------------------------------------------------------
// <cleanup>
// Last Cleanup Code: 16.04.2019 17:33
// </cleanup>
// -----------------------------------------------------------------------

#region

using System;
using System.Collections.Generic;
using System.Diagnostics;

#endregion

namespace LeetCodeCSharp
{
    public class LengthOfLongestSubstringSolution
    {
        #region Public Methods

        public static int LengthOfLongestSubstring(string s)
        {
            var counter = 0;
            var subCounter = 0;
            var dict = new Dictionary<char,int>();

            for (var i = 0; i <= s.Length; i++)
            {
                if (i >= s.Length)
                {
                    break;
                }
                if (dict.ContainsKey(s[i]))
                {
                    if (subCounter > counter) { counter = subCounter; }
                    
                    dict.TryGetValue(s[i], out i);
                    dict.Clear();
                    subCounter = 0;
                }
                else
                {
                    dict.Add(s[i], i);
                    subCounter++;
                }
            }  
            
            if (subCounter > counter) { counter = subCounter; }
            return counter;
        }

        #endregion
    }
}
