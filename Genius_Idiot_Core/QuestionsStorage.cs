using Newtonsoft.Json;

namespace Genius_Idiot_Core;

public class QuestionsStorage
{
    private readonly string questionsPath;
    public List<Question> Questions { get; private set; }
    public int Count { get; private set; }

    public QuestionsStorage()
    {
        questionsPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "questions.txt");
        Questions = GetQuestions();
        Count = Questions.Count;
        ShuffleQuestions(Questions);
    }
    public static List<Question> ShuffleQuestions(List<Question> nonShuffledQuestions)
    {
        Random random = new Random();
        var questions = nonShuffledQuestions;

        for (int i = questions.Count - 1; i > 0; i--)
        {
            int j = random.Next(i + 1);
            (questions[i], questions[j]) = (questions[j], questions[i]);
        }
        return questions;
    }
    public List<Question> GetQuestions()
    {
        var hasFileQuestions = FileService.CheckFileContent(questionsPath);

        if (!hasFileQuestions)
        {
            var questionsList = new List<Question>()
            {
                new Question("Сколько будет два плюс два умноженное на два?", 6),
                new Question("Бревно нужно распилить на 10 частей, сколько надо сделать распилов?", 9),
                new Question("На двух руках 10 пальцев. Сколько пальцев на 5 руках?", 25),
                new Question("Укол делают каждые полчаса, сколько нужно минут для трех уколов?", 60),
                new Question("Пять свечей горело, две потухли. Сколько свечей осталось?",5)
            };
            SaveQuestions(questionsList);
            return questionsList;
        }
        else
        {
            var jsonQuestions = FileService.GetDataFromFile(questionsPath);
            var questions = JsonConvert.DeserializeObject<List<Question>>(jsonQuestions);
            return questions;
        }
    }
    public void SaveQuestions(List<Question> questions)
    {
        var jsonQuestions = JsonConvert.SerializeObject(questions, Formatting.Indented);
        FileService.SaveDataInFile(questionsPath, jsonQuestions);
    }

}