using System.Text;

namespace Genius_Idiot_Console_App;

class Program
{
    static void Main(string[] args)
    {
        do
        {
            var fileService = new FileService();
            var user = new User();
            var questions = new QuestionsStorage(fileService);
            var userResults = new UserResultsStorage();
            ShowTestingRules();
            PrepareBeforeTesting();
            int finalScore = 0;
            TestErudition(questions, user, out finalScore);
            ShowResult(user, questions, finalScore, userResults);
            fileService.SaveResultsInFile(user, userResults);
            fileService.ShowPreviousResults();
            //fileService.AddQuestionInFile();
            fileService.RemoveQuestion();
        } while (AskToContinueTest());
        
        
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
    public static void TestErudition(QuestionsStorage questionsStorage, User user, out int score)
    {
        questionsStorage.ShuffleQuestions();
        
        score = 0;
        int currentQuestion = 1;

        foreach (var question in questionsStorage.Questions)
        {
            Console.WriteLine($"Вопрос №{currentQuestion}: {question.Text}");
            Console.Write("Ваш ответ: ");

            GetUserAnswer(question);

            if (question.UserAnswer == question.Answer)
            {
                score++;
                Console.WriteLine($"Вы ответили на вопрос #{currentQuestion}. Переходим к следующему.");
            }
            else if (question.UserAnswer == null)
                Console.WriteLine($"Вы не успели ответить на вопрос #{currentQuestion}. Ответ не засчитан");
            else
                Console.WriteLine($"Вы ответили на вопрос #{currentQuestion}. Переходим к следующему.");

            currentQuestion++;
            Console.WriteLine();
        }
        
        void GetUserAnswer(Question question)
        {
            while (true)
            {
                try
                {
                    question.UserAnswer = int.Parse(Console.ReadLine());
                    break;
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
    public static void ShowResult(User user, QuestionsStorage questions, int finalScore, UserResultsStorage userResults)
    {
        string level = "";
        int percentScore = finalScore * 100 / questions.Count;
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

        var result = new UserResult(level, finalScore);
        userResults.Add(result);
        
        Console.WriteLine($"Поздравляем {user.Name}, вы окончили тестирование \"Гений-Идиот\"! Суммарное количество правильных ответов - {finalScore}. Ваш результат - {level}");
    }
}
