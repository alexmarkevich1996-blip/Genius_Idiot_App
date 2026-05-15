using Genius_Idiot_Core;
using System.Text;

namespace Genius_Idiot_Console_App;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        do
        {
            IntroductionConsoleView.Run();
            string userName = AskUserData();
            var user = new User(userName);
            


            int finalScore = 0;
            TestErudition(questions, user, out finalScore);

            var level = LevelCalculator.Calculate(finalScore, questions.Count);
            userResults.Add(level, finalScore);
            var lastResult = userResults.GetLastResult();
            ShowResult(user, lastResult);

            fileService.SaveResultsInFile(user, userResults);
            Console.WriteLine("Введите один из возможных вариантов\n" +
                              "1. Показать все предыдущие результаты;\n" +
                              "2. Добавить новый вопрос в тест;\n" +
                              "3. Удалить существующий вопрос из теста;\n");
            int numChoice = int.Parse(Console.ReadLine());

            switch (numChoice)
            {
                case 1:
                    fileService.GetPreviousResults();
                    break;
                case 2:
                    fileService.AddQuestionInFile();
                    break;
                case 3:
                    fileService.RemoveQuestion();
                    break;
                default:
                    Console.WriteLine("Выбран неверный вариант");
                    break;
            }
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

    

    public static void TestErudition(QuestionsStorage questionsStorage, User user, out int score)
    {
        questionsStorage.Questions = QuestionsStorage.ShuffleQuestions(questionsStorage.Questions);
        
        score = 0;
        int currentQuestion = 1;

        foreach (var question in questionsStorage.Questions)
        {
            Console.WriteLine($"Вопрос №{currentQuestion}: {question.QuestionText}");
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
    public static void ShowResult(User user, UserResult lastResult)
    {
        
        Console.WriteLine($"Поздравляем {user.Name}, вы окончили тестирование \"Гений-Идиот\"! Суммарное количество правильных ответов - {lastResult.Score}. Ваш результат - {lastResult.Level}");
    }
}
