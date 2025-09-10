
namespace NumberPrime
{
    public class Methods
    {
        #region Public Methods
        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;
            for (int j = 3; j < number; j++)
            {
                if (number % j == 0) return false;
            }
            return true;
        }
        #endregion
    }
}
