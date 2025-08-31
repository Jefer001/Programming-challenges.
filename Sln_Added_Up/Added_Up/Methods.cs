using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Added_Up
{
    public class Methods
    {
        #region Attributes
        private int sum = 0;
        private int number;
        #endregion

        #region Private methods
        private static bool ValidateNumber(int num)
        {
            if (int.TryParse(num.ToString(), out _))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool ValidateIsPositive(int num)
        {
            if (num > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Summation(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                sum += i;
            }
        }
        #endregion

        #region Public methods
        public bool GetNumber(int num)
        {
            if (ValidateNumber(num) && ValidateIsPositive(num))
            {
                number = num;
                Summation(number);
                return true;
            }
            else
            {
                return false;
            }
        }

        public string PrintSummation()
        {
            return $"{number} -> {sum}";
        }
        #endregion
    }
}
