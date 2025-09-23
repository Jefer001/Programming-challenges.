
namespace Word_a10n
{
    public class Methods
    {
        #region Public Methods
        public static string Abbreviate(string str)
        {
            if (string.IsNullOrEmpty(str))
                return str;
            var result = new System.Text.StringBuilder();
            var word = new System.Text.StringBuilder();
            foreach (char c in str)
            {
                if (char.IsLetter(c))
                {
                    word.Append(c);
                }
                else
                {
                    if (word.Length >= 4)
                    {
                        result.Append(word[0]);
                        result.Append(word.Length - 2);
                        result.Append(word[^1]);
                    }
                    else
                    {
                        result.Append(word);
                    }
                    result.Append(c);
                    word.Clear();
                }
            }
            // Handle the last word if there is one
            if (word.Length >= 4)
            {
                result.Append(word[0]);
                result.Append(word.Length - 2);
                result.Append(word[^1]);
            }
            else
            {
                result.Append(word);
            }
            return result.ToString();
        }
        #endregion
    }
}
