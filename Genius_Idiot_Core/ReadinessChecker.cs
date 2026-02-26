using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genius_Idiot_Core
{
    public class ReadinessChecker
    {
        private const string requiredKeyword = "ready";

        public bool IsUserReady(string userInput)
        {
            if (userInput == requiredKeyword && !string.IsNullOrEmpty(userInput)) 
            {
                return true;
            }
            return false;
        }
    }
}
