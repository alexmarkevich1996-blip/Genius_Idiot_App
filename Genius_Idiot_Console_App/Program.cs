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
            int totalQuestionsNum = 0;
            TestErudition(ref finalScore, out totalQuestionsNum);
            string level;
            ShowResult(finalScore, totalQuestionsNum,userName, out level);
            SaveScoreInFile(finalScore, userName, level);
        } while (AskToContinueTest());
        
        string AskUserName()
        {
            while (true)
            {
                Console.Write("Пожалуйста, введите ваше имя: ");
                string userName = Console.ReadLine();
                if (userName != string.Empty)
                {
                    Console.WriteLine($"Добро пожаловать, {userName}!");
                    return userName;
                }
                else
                {
                    Console.WriteLine("Вы не ввели имя. Просим вас повторить попытку.");
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
        List<string> questionsDescription = new List<string>()
        {
            "Сколько будет два плюс два умноженное на два?",
            "Бревно нужно распилить на 10 частей, сколько надо сделать распилов?",
            "На двух руках 10 пальцев. Сколько пальцев на 5 руках?",
            "Укол делают каждые полчаса, сколько нужно минут для трех уколов?",
            "Пять свечей горело, две потухли. Сколько свечей осталось?"
        };
        var questionsWithAnswer = new Dictionary<string, int>()
        {
            {"Сколько будет два плюс два умноженное на два?", 6},
            {"Бревно нужно распилить на 10 частей, сколько надо сделать распилов?", 9},
            {"На двух руках 10 пальцев. Сколько пальцев на 5 руках?", 25},
            {"Укол делают каждые полчаса, сколько нужно минут для трех уколов?", 60},
            {"Пять свечей горело, две потухли. Сколько свечей осталось?", 5}
        };
        totalQuestionsNum = questionsWithAnswer.Count;

        ShuffleQuestions(questionsDescription);
        DisplayQuestions(questionsDescription, questionsWithAnswer, ref finalScore);
        
        
        void ShuffleQuestions(List<string> list)
        {
            Random random = new Random();

            for (int i = list.Count - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                (list[i], list[j]) = (list[j], list[i]);
            }
        }
        void DisplayQuestions(List<string> questionsDescription, Dictionary<string, int> questionsWithAnswer, ref int score)
        {
            score = 0;
            int currentQuestion = 1;
        
            foreach (var question in questionsDescription)
            {
                Console.WriteLine($"Вопрос №{currentQuestion}: {question}");
                Console.Write("Ваш ответ: ");

                int input = GetUserAnswer();
            
                if (input == questionsWithAnswer[question])
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
        StreamWriter writer = new StreamWriter(path, true, Encoding.UTF8);
        DateTime date = DateTime.Today;
        writer.WriteLine($"{userName} - {finalScore} - {level} - {date}");
        writer.Close();
    }
}
