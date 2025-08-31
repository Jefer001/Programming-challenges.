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
        public int number;
        #endregion

        #region Private methods
        public static bool ValidateNumber(string num)
        {
            if (int.TryParse(num, out _)) { return true; } return false;
        }

        private static bool ValidateIsPositive(int num)
        {
            if (num > 0){ return true; } return false;
        }
        #endregion

        #region Public methods
        public bool GetNumber()
        {
            Console.WriteLine("Enter a positive number");
            string str = Console.ReadLine() ?? "0";

            if (ValidateNumber(str))
            {
                number = int.Parse(str);
                if (ValidateIsPositive(number)) { return true; } return false;
            }
            return false;
        }

        public void Summation(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                sum += i;
            }
        }

        public string PrintSummation()
        {
            return $"{number} -> {sum}";
        }
        #endregion
    }
}
