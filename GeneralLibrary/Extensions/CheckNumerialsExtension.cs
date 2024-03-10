using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralLibrary.Extensions
{
    public static class CheckNumerialsExtension
    {
        public static string CheckNumerials(this string input)
        {
            if (!string.IsNullOrEmpty(input) && input.All(char.IsDigit) && input.Length == 11)
            {
                return input;
            }
            else
            {
                throw new ArgumentException("PersonalId must contain only numbers or it length must be 11.");
            }
        }
    }
}
