using System.Text;

namespace Sum_Strings_as_Numbers
{
    public class Methods
    {
        #region Public Methods
        public static string SumStringsNum(string a, string b)
        {
            // Handle null or empty strings
            if (string.IsNullOrEmpty(a)) return b ?? "0";
            if (string.IsNullOrEmpty(b)) return a ?? "0";
            // Remove leading zeros
            a = a.TrimStart('0');
            b = b.TrimStart('0');
            // If both strings are empty after trimming, return "0"
            if (string.IsNullOrEmpty(a) && string.IsNullOrEmpty(b)) return "0";
            int maxLength = Math.Max(a.Length, b.Length);
            a = a.PadLeft(maxLength, '0');
            b = b.PadLeft(maxLength, '0');
            StringBuilder result = new();
            int carry = 0;
            for (int i = maxLength - 1; i >= 0; i--)
            {
                int digitA = a[i] - '0';
                int digitB = b[i] - '0';
                int sum = digitA + digitB + carry;
                carry = sum / 10;
                result.Append(sum % 10);
            }
            if (carry > 0) result.Append(carry);
            // Reverse the result and convert to string
            char[] resultArray = result.ToString().ToCharArray();
            Array.Reverse(resultArray);
            return new string(resultArray);
        }
        #endregion
    }
}
