// -----------------------------------------------------------------------
// <cleanup>
// Last Cleanup Code: 28.04.2019 20:08
// </cleanup>
// -----------------------------------------------------------------------

using System.Collections.Generic;
using System.Diagnostics;

namespace LeetCodeCSharp
{
    public static class ZigZagConversionSolution
    {
        public static string Convert(string s, int numRows)
        {

            var dict = new Dictionary<int, int>();

            var numRowsCopy = numRows - 1;
            var diff = 1;
            
            while (numRowsCopy > 0)
            {
                dict.Add(numRowsCopy, diff);
                diff = diff + 2;
                numRowsCopy--;
            }

            dict.TryGetValue(1, out var valueFirstRow);
            dict.Add(numRows, valueFirstRow);

            var sArray = s.ToCharArray();
            var resultString = string.Empty;
            
            
            // iterate over rows
            for (var i = 1; i <= numRows; i++)
            {
                dict.TryGetValue(i, out diff); // get difference value for row

                var outOfRange = false;
                var nexValueIndex = i - 1;
                
                
                var round = 1;
                while (!outOfRange)
                {
                    if (i == 1 || i == numRows)
                    {if (nexValueIndex < sArray.Length)
                        {
                            resultString += sArray[nexValueIndex];
                            nexValueIndex += diff + 1;
                        }
                        else { outOfRange = true; }
                    }
                    else
                    {
                        if ( round == 1)
                        {
                            resultString += sArray[nexValueIndex];
                             round++;
                            continue;
                        }
                        
                        if ( round % 2 != 0)
                        {
                            dict.TryGetValue(1, out var maxDiff);
                            nexValueIndex =  round + ( round * maxssDiff) - 1;
                        }
                        else
                        {
                            nexValueIndex = nexValueIndex + diff + 1;
                        }

                        if (nexValueIndex < sArray.Length) { resultString += sArray[nexValueIndex]; }
                        else { outOfRange = true; }
                         round++;
    
                    }
                    
                    

                }

            }

            return resultString;

        }
    }
}
