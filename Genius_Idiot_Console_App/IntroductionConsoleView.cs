using Genius_Idiot_Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genius_Idiot_Console_App
{
    internal static class IntroductionConsoleView
    {

        internal static void Run()
        {
            LoadIntroductionRules();
            CheckForReadinessToStart();
        }

        private static void LoadIntroductionRules()
        {
            Console.WriteLine();
            Console.WriteLine(TestRules.GetGeneralRules());
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine(TestRules.GetUserReadyRules());
            Console.WriteLine();
        }

        private static void CheckForReadinessToStart()
        {
            while (true)
            {
                string userInput = Console.ReadLine()!;

                if (TestRules.IsReadyToStart(userInput))
                {
                    Console.WriteLine();
                    return;
                }
                Console.WriteLine(TestRules.GetWrongKeywordMessage());
            }
        }

    }
}
