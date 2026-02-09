namespace Genius_Idiot_Console_App;

class Program
{
    static void Main(string[] args)
    {
        ShowTestingRules();
        PrepareBeforeTesting();
        int finalScore = TestErudition();
    }
    
    
    static void ShowTestingRules()
    {
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
        int score = 0;
        Dictionary<string, string> questions = new Dictionary<string, string>()
        {
            {"Сколько будет два плюс два умноженное на два?", "6"},
            {"Бревно нужно распилить на 10 частей, сколько надо сделать распилов", "9"},
            {"“На двух руках 10 пальцев. Сколько пальцев на 5 руках”", "25"},
            {"Укол делают каждые полчаса, сколько нужно минут для трех уколов?", "60"},
            {"Пять свечей горело, две потухли. Сколько свечей осталось", "5"},
        };

        int currentQuestion = 1;
        foreach (var (question, answer) in questions)
        {
            Console.WriteLine(question);
            Console.Write("Ваш ответ: ");
            var input = Console.ReadLine();

            if (input == answer)
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

        return score;
    }
}
