
namespace Calculate_Logarithmic_Functions
{
    public class Methods
    {
        #region Public Methods
        public static double[] CalculateLog(double[] values) 
        { 
            if (values == null || values.Length != 2) throw new ArgumentException("Input must be an array of two elements representing a complex number.");
            double realPart = values[0];
            double imaginaryPart = values[1];
            if (realPart == 0 && imaginaryPart == 0) throw new ArgumentException("Logarithm is undefined for the complex number 0 + 0i.");
            double modulus = Math.Sqrt(realPart * realPart + imaginaryPart * imaginaryPart);
            double argument = Math.Atan2(imaginaryPart, realPart);
            double logReal = Math.Log(modulus);
            double logImaginary = argument;
            return [logReal, logImaginary];
        }
        #endregion
    }
}
