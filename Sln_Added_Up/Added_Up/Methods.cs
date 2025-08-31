using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Added_Up
{
    public class Methods
    {

        #region Private methods
        private bool ValidateNumber(int num)
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
        #endregion
    }
}
