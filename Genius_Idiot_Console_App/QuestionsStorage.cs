namespace Genius_Idiot_Console_App;

public class QuestionsStorage
{
    public List<Question> Questions { get; private set; }
    public int Count { get; private set; }

    public QuestionsStorage()
    {
        Questions = new List<Question>()
        {
            new Question("Сколько будет два плюс два умноженное на два?", 6),
            new Question("Бревно нужно распилить на 10 частей, сколько надо сделать распилов?", 9),
            new Question("На двух руках 10 пальцев. Сколько пальцев на 5 руках?", 25),
            new Question("Укол делают каждые полчаса, сколько нужно минут для трех уколов?", 60),
            new Question("Пять свечей горело, две потухли. Сколько свечей осталось?", 5)
        };
        Count = Questions.Count;
    }
    public void ShuffleQuestions()
    {
        Random random = new Random();

        for (int i = Questions.Count - 1; i > 0; i--)
        {
            int j = random.Next(i + 1);
            (Questions[i], Questions[j]) = (Questions[j], Questions[i]);
        }
    }

    public void AddQuestion()
    {
        Console.Write("Введите формулировку вопроса: ");
        string inputQuestion = Console.ReadLine();
        Console.Write("Введите правильный ответ на вопрос: ");
        int inputAnswer = int.Parse(Console.ReadLine());
        
        Questions.Add(new Question(inputQuestion, inputAnswer));
    }

    public void RemoveQuestion(int index)
    {
        if (index >= 0 && index < Count)
            Questions.RemoveAt(index);
        else
            Console.WriteLine("Неверный индекс вопроса");
    }
    
    
}