
namespace Reversed_Words
{
    public class Methods
    {
        #region Public Methods
        public static string ReverseWords(string str)
        {
            if (string.IsNullOrEmpty(str)) { return str; }
            string[] words = str.Split(' ');
            Array.Reverse(words);
            return string.Join(" ", words);
        }
        #endregion
    }
}
