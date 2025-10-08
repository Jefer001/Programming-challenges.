
namespace Range_Extraction
{
    public class Methods
    {
        #region Public Methods
        public static string Rang_Extract(int[] arr)
        {
            if (arr.Length == 0) return string.Empty;
            var result = new System.Text.StringBuilder();
            int start = arr[0];
            int end = arr[0];
            for (int i = 1; i <= arr.Length; i++)
            {
                if (i < arr.Length && arr[i] == end + 1) end = arr[i];
                else
                {
                    if (start == end) result.Append(start);
                    else if (end == start + 1) result.Append($"{start},{end}");
                    else result.Append($"{start}-{end}");
                    if (i < arr.Length)
                    {
                        result.Append(',');
                        start = end = arr[i];
                    }
                }
            }
            return result.ToString();
        }
        #endregion
    }
}
