using Genius_Idiot_Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genius_Idiot_Console_App
{
    internal class EruditionTestConsoleView
    {
        private User user { get; set; }
        private QuestionsStorage questionsStorage { get; set; }

        internal EruditionTestConsoleView()
        {
            user = new User(AskUserName());
            questionsStorage = new QuestionsStorage();
        }



        private static string AskUserName()
        {
            while (true)
            {
                Console.Write("Пожалуйста, введите ваше имя: ");
                string userName = Console.ReadLine();
                if (userName == string.Empty)
                {
                    Console.WriteLine("Вы не ввели имя. Просим вас повторить попытку.");
                }
                else if (userName.Contains('-'))
                {
                    Console.WriteLine($"Недопустимо писать имя со спец символом \"-\"");
                }
                else
                {
                    Console.WriteLine($"Добро пожаловать, {userName}!");
                    return userName;
                }
            }
        }
    }
}
