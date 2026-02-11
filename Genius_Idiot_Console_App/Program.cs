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
            int finalScore = TestErudition();
            ShowResult(finalScore, userName);
        } while (AskToContinueTest());
    }

    static string AskUserName()
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
    static void ShowTestingRules()
    {
        Console.WriteLine();
        Console.WriteLine("Приветствуем вас на тестировании “Гений-Идиот”. На данном тестировании мы попросим вас ответить всего на 5 вопросов. \n" +
                          "Каждый из них представляет собой логическую задачу, где ответом должно быть какое-то число. \n" +
                          "По каждому из вопросов вы должно ввести ответ в течении 10 секунд. \n" +
                          "Если вы не успеете ввести ответ, то система не засчитает вам баллы за вопрос и вы перейдете к следующему. \n" +
                          "По окончанию всех вопросов программа оценит количество правильных ответов и по ним определит уровень вашей эрудиции. Удачи вам!");
        Console.WriteLine();
    }
    static void PrepareBeforeTesting()
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
    static int TestErudition()
    {
        int finalScore;
        List<string> questionsDescription = new List<string>()
        {
            "Сколько будет два плюс два умноженное на два?",
            "Бревно нужно распилить на 10 частей, сколько надо сделать распилов?",
            "На двух руках 10 пальцев. Сколько пальцев на 5 руках?",
            "Укол делают каждые полчаса, сколько нужно минут для трех уколов?",
            "Пять свечей горело, две потухли. Сколько свечей осталось?"
        };
        Dictionary<string, string> questionsWithAnswer = new Dictionary<string, string>()
        {
            {"Сколько будет два плюс два умноженное на два?", "6"},
            {"Бревно нужно распилить на 10 частей, сколько надо сделать распилов?", "9"},
            {"На двух руках 10 пальцев. Сколько пальцев на 5 руках?", "25"},
            {"Укол делают каждые полчаса, сколько нужно минут для трех уколов?", "60"},
            {"Пять свечей горело, две потухли. Сколько свечей осталось?", "5"}
        };

        ShuffleQuestions(questionsDescription);
        DisplayQuestions(questionsDescription, questionsWithAnswer, out finalScore);
       
        return finalScore;
    }
    static void ShowResult(int finalScore, string userName)
    {
        string level = string.Empty;
        switch (finalScore)
        {
            case 0:
                level = "Идиот";
                break;
            case 1:
                level = "Кретин";
                break;
            case 2:
                level = "Дурак";
                break;
            case 3:
                level = "Нормальный";
                break;
            case 4:
                level = "Талант";
                break;
            case 5:
                level = "Гений";
                break;
        }
        Console.WriteLine($"Поздравляем {userName}, вы окончили тестирование \"Гений-Идиот\"! Суммарное количество правильных ответов - {finalScore}. Ваш результат - {level}");
    }
    public static void ShuffleQuestions(List<string> list)
    {
        Random random = new Random();

        for (int i = list.Count - 1; i > 0; i--)
        {
            int j = random.Next(i + 1);
            (list[i], list[j]) = (list[j], list[i]);
        }
    }
    public static void DisplayQuestions(List<string> questionsDescription, Dictionary<string, string> questionsWithAnswer, out int score)
    {
        score = 0;
        int currentQuestion = 1;
        
        foreach (var question in questionsDescription)
        {
            Console.WriteLine($"Вопрос №{currentQuestion}: {question}");
            Console.Write("Ваш ответ: ");
            var input = Console.ReadLine();

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
    }

    public static bool AskToContinueTest()
    {
        Console.WriteLine("Хотите повторить тест? Введите \"ДА\" для продолжения: ");
        string answer = Console.ReadLine().ToLower();

        if (answer == "да")
            return true;

        return false;
    }
}
