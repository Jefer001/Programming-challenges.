using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reversed_Words
{
    public class Methods
    {
        #region
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
