using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genius_Idiot_Core
{
    public class InputValidator
    {

        public static bool TryParseToNumber(string input, out int number, out string errorMessage)
        {
            try
            {
                number = Convert.ToInt32(input);
                errorMessage = string.Empty;
                return true;
            }
            catch (FormatException)
            {
                number = 0;
                errorMessage = "Enter the number!";
                return false;
            }
            catch (OverflowException)
            {
                number = 0;
                errorMessage = "Enter the number from -2*10^9 to 2*10^9!";
                return false;
            }
        }
    }
}
