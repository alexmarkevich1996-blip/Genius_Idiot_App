using Genius_Idiot_Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genius_Idiot_Core
{
    public class LevelCalculator
    {
        public static string Calculate(int finalScore, int questionsCount)
        {
            string level = "";
            int percentScore = finalScore * 100 / questionsCount;
            switch (percentScore)
            {
                case 100:
                    level = "Гений";
                    break;
                case >= 80 and < 100:
                    level = "Талант";
                    break;
                case >= 60 and < 80:
                    level = "Нормальный";
                    break;
                case >= 40 and < 60:
                    level = "Дурак";
                    break;
                case >= 20 and < 40:
                    level = "Кретин";
                    break;
                case < 20:
                    level = "Идиот";
                    break;
            }

            return level;
        }
    }
}
