namespace Digits_Powers_Numbers
{
    public class Methods
    {
        #region Public Methods
        public static long PowerSumDig(int n) {
            List<long> results = [];
            for (int baseNum = 2; baseNum < 100; baseNum++)
            {
                for (int power = 2; power < 25; power++)
                {
                    long poweredValue = (long)Math.Pow(baseNum, power);
                    int sumOfDigits = SumOfDigits(poweredValue);
                    if (sumOfDigits == baseNum)
                    {
                        results.Add(poweredValue);
                    }
                }
            }
            results.Sort();
            return results[n - 1];
        }
        #endregion

        #region Private Methods
        private static int SumOfDigits(long number)
        {
            int sum = 0;
            while (number != 0)
            {
                sum += (int)(number % 10);
                number /= 10;
            }
            return sum;
        }
        #endregion
    }
}
