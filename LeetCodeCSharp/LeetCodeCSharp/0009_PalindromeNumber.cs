namespace LeetCodeCSharp
{
    public class PalindromeNumber
    {
        public bool IsPalindrome(int x)
        {
            var charArray = x.ToString().ToCharArray();
            var j = charArray.Length - 1;

            for (var i = 0; i <= j; i++)
            {
                if (charArray[i] != charArray[j]) return false;
                j--;
            }

            return true;
        }
    }
}