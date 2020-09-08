// -----------------------------------------------------------------------
// <cleanup>
// Last Cleanup Code: 28.04.2019 20:08
// </cleanup>
// -----------------------------------------------------------------------

using System;

namespace LeetCodeCSharp
{
    public static class ZigZagConversionSolution
    {
        public static string Convert(string s, int numRows)
        {
            if (numRows == 0) return string.Empty;
            if (numRows == 1) return s;
            
            var width = 1000;
            var charArray = s.ToCharArray();
            var charArrayCounter = 0;
            var array = new string[numRows, width];

            for (var i = 0; i < array.GetLength(1); i++)
            {
                var mod = i % (numRows - 1);
                if (mod == 0)
                {
                    for (var j = 0; j < array.GetLength(0); j++)
                    {
                        array[j, i] = charArrayCounter < charArray.Length
                            ? charArray[charArrayCounter].ToString()
                            : null;
                        charArrayCounter++;
                    }
                }
                else
                {
                    array[numRows - 1 - mod, i] = charArrayCounter < charArray.Length
                        ? charArray[charArrayCounter].ToString()
                        : null;
                    charArrayCounter++;
                }
            }

            var returnString = string.Empty;
            foreach (var s1 in array)
                if (s1 != null)
                    returnString += s1;

            return returnString;
        }


        private static string GetCharacterAsStringOfCharArray(char[] charArray, int index)
        {
            return index < charArray.Length ? charArray[index].ToString() : null;
        }

        private static void PrintArrayAsTable(string[,] array)
        {
            var line = string.Empty;
            for (var i = 0; i < array.GetLength(0); i++)
            for (var j = 0; j < array.GetLength(1); j++)
            {
                var value = array[i, j] ?? "0";
                line += value;
                if (j != array.GetLength(1) - 1) continue;
                Console.WriteLine(line);
                line = string.Empty;
            }
        }
    }
}