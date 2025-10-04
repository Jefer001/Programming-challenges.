
namespace Parts_Sums
{
    public class Methods
    {
        #region Public Methods
        public static int[] PartsSums(int[] ls)
        {
            int[] result = new int[ls.Length + 1];
            int sum = 0;
            for (int i = ls.Length - 1; i >= 0; i--)
            {
                sum += ls[i];
                result[i] = sum;
            }
            return result;
        }
        #endregion
    }
}
