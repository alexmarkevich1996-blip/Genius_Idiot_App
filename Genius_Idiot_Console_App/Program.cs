namespace Genius_Idiot_Console_App;

class Program
{
    static void Main(string[] args)
    {
        ShowTestingRules();
        PrepareBeforeTesting();
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
}
