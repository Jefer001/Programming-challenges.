
namespace Palindromes
{
    public class Methods
    {
        #region Public Methods
        public static string ValidateIfItIsPalindrome(string str)
        {
            string result;
            if (string.IsNullOrEmpty(str)) result = "not possible.";
            else if (IsPalindrome(str)) result = "If it is a palindrome.";
            else if (SingleCharacterPalindromes(str)) result = "It's a palindrome without one letter.";
            else result = "It is not a palindrome.";
            return result;
        }
        #endregion

        #region Private Methods
        private static bool IsPalindrome(string str)
        {
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

        private static bool SingleCharacterPalindromes(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                string modifiedStr = str.Remove(i, 1);
                if (IsPalindrome(modifiedStr)) return true;
            }
            return false;
        }
        #endregion
    }
}
