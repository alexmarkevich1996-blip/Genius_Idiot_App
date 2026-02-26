namespace Genius_Idiot_Core
{
    public static class TestRules
    {
        public static string GetGeneralRules()
        {
            return "Приветствуем вас на тестировании “Гений-Идиот”. На данном тестировании мы попросим вас ответить всего на 5 вопросов. \n" +
                          "Каждый из них представляет собой логическую задачу, где ответом должно быть какое-то число. \n" +
                          "По каждому из вопросов вы должно ввести ответ в течении 10 секунд. \n" +
                          "Если вы не успеете ввести ответ, то система не засчитает вам баллы за вопрос и вы перейдете к следующему. \n" +
                          "По окончанию всех вопросов программа оценит количество правильных ответов и по ним определит уровень вашей эрудиции. Удачи вам!";
        }

        public static string GetUserReadyRules()
        {
            return "Введите ключевое слово “Ready”, если поняли и приняли правила тестирования. \n" +
                          "Тестирование не начнется, покуда вы не введете ключевое слово. ";
        }

        public static bool IsUserReady(string userInput)
        {
            if (userInput == "ready" && !string.IsNullOrEmpty(userInput))
            {
                return true;
            }
            return false;
        }

        public static string GetWrongKeywordMessage()
        {
            return "Неверное ключевое слово. Повторите, пожалуйста, попытку.";
        }
    }
}
