
namespace Palindromes
{
    public class Methods
    {
        #region Private Methods
        public static bool IsPalindrome(string str)
        {
            if (string.IsNullOrEmpty(str)) return false;
            int left = 0;
            int right = str.Length - 1;
            while (left < right)
            {
                if (str[left] != str[right]) return false;
                left++;
                right--;
            }
            return true;
        }
        #endregion
    }
}
