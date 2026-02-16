using System.Text;

namespace Genius_Idiot_Console_App;

class Program
{
    static void Main(string[] args)
    {
        string userName = AskUserName();

        do
        {
            ShowTestingRules();
            PrepareBeforeTesting();
            int finalScore = 0;
            int totalQuestionsNum;
            TestErudition(ref finalScore, out totalQuestionsNum);
            string level;
            ShowResult(finalScore, totalQuestionsNum,userName, out level);
            SaveScoreInFile(finalScore, userName, level);
            ShowPreviousResults();
        } while (AskToContinueTest());
        
        string AskUserName()
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
        bool AskToContinueTest()
        {
            Console.WriteLine("Хотите повторить тест? Введите \"ДА\" для продолжения: ");
            string answer = Console.ReadLine().ToLower();

            if (answer == "да")
                return true;

            return false;
        }
    }

    public static void ShowTestingRules()
    {
        Console.WriteLine();
        Console.WriteLine("Приветствуем вас на тестировании “Гений-Идиот”. На данном тестировании мы попросим вас ответить всего на 5 вопросов. \n" +
                          "Каждый из них представляет собой логическую задачу, где ответом должно быть какое-то число. \n" +
                          "По каждому из вопросов вы должно ввести ответ в течении 10 секунд. \n" +
                          "Если вы не успеете ввести ответ, то система не засчитает вам баллы за вопрос и вы перейдете к следующему. \n" +
                          "По окончанию всех вопросов программа оценит количество правильных ответов и по ним определит уровень вашей эрудиции. Удачи вам!");
        Console.WriteLine();
    }
    public static void PrepareBeforeTesting()
    {
        Console.WriteLine("Введите ключевое слово “Ready”, если поняли и приняли правила тестирования. \n" +
                          "Тестирование не начнется, покуда вы не введете ключевое слово. ");

        while (true)
        {
            string keyword = Console.ReadLine().ToLower();
            if (keyword == "ready")
                break;
            Console.WriteLine("Неверное ключевое слово. Повторите, пожалуйста, попытку.");
        }
    }
    public static void TestErudition(ref int finalScore, out int totalQuestionsNum)
    {
        List<Question> questions = new List<Question>()
        {
            new Question("Сколько будет два плюс два умноженное на два?", 6),
            new Question("Бревно нужно распилить на 10 частей, сколько надо сделать распилов?", 9),
            new Question("На двух руках 10 пальцев. Сколько пальцев на 5 руках?", 25),
            new Question("Укол делают каждые полчаса, сколько нужно минут для трех уколов?", 60),
            new Question("Пять свечей горело, две потухли. Сколько свечей осталось?", 5)
        };
        totalQuestionsNum = questions.Count;

        ShuffleQuestions(questions);
        DisplayQuestions(questions, ref finalScore);
        
        void ShuffleQuestions(List<Question> list)
        {
            Random random = new Random();

            for (int i = list.Count - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                (list[i], list[j]) = (list[j], list[i]);
            }
        }
        void DisplayQuestions(List<Question> questions, ref int score)
        {
            score = 0;
            int currentQuestion = 1;
        
            foreach (var question in questions)
            {
                Console.WriteLine($"Вопрос №{currentQuestion}: {question.Text}");
                Console.Write("Ваш ответ: ");

                int input = GetUserAnswer();
            
                if (input == question.Answer)
                {
                    score++;
                    Console.WriteLine($"Вы ответили на вопрос #{currentQuestion}. Переходим к следующему.");
                }
                else if (input == null)
                    Console.WriteLine($"Вы не успели ответить на вопрос #{currentQuestion}. Ответ не засчитан");
                else
                    Console.WriteLine($"Вы ответили на вопрос #{currentQuestion}. Переходим к следующему.");
                currentQuestion++;
                Console.WriteLine();
            }

            int GetUserAnswer()
            {
                while (true)
                {
                    try
                    {
                        return int.Parse(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Неправильный формат ответа. Введите целочисленное значение!");
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Неправильный формат ответа. Введите число от -2*10^9 до 2*10^9");
                    }
                }
            }
        }
        
    }
    public static void ShowResult(int finalScore, int totalQuestionsNum, string userName, out string level)
    {
        level = "";
        int percentScore = finalScore * 100 / totalQuestionsNum;
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
        Console.WriteLine($"Поздравляем {userName}, вы окончили тестирование \"Гений-Идиот\"! Суммарное количество правильных ответов - {finalScore}. Ваш результат - {level}");
    }
    public static void SaveScoreInFile(int finalScore, string userName, string level)
    {
        string path = "/Users/aleksandr/RiderProjects/Genius_Idiot_App/Genius_Idiot_Console_App/user_results.txt";
        var writer = new StreamWriter(path, true, Encoding.UTF8);
        var date = DateTime.Today;
        writer.WriteLine($"{userName}-{finalScore}-{level}-{date}");
        writer.Close();
    }
    private static void ShowPreviousResults()
    {
        Console.WriteLine("Хотите просмотреть предыдущие результат? Введите \"ДА\" для продолжения: ");
        string answer = Console.ReadLine().ToLower();

        if (answer.ToLower() != "да")
            return; 
        
        StreamReader reader = new StreamReader("/Users/aleksandr/RiderProjects/Genius_Idiot_App/Genius_Idiot_Console_App/user_results.txt", Encoding.UTF8);
        
        Console.WriteLine("{0,-20}{1,18}{2,15}{3,15}", "Имя","Кол-во правильных ответов","Результат","Дата");
        while (!reader.EndOfStream)
        {
            string line = reader.ReadLine();
            string[] lineParts = line.Split('-');
            string userName = lineParts[0];
            string finalScore = lineParts[1];
            string level = lineParts[2];
            string date = lineParts[3];
            Console.WriteLine("{0,-20}{1,15}{2,23}{3,32}", userName, finalScore, level, date);
        }
        reader.Close();
    }
}
