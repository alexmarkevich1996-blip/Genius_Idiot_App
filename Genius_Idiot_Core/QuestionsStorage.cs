namespace Genius_Idiot_Core;

public class QuestionsStorage
{
    public List<Question> Questions { get; set; }
    public FileService FileService { get; set; }
    public int Count { get; private set; }

    public QuestionsStorage()
    {
        FileService = new FileService();
        Questions = GetQuestions();
        Count = Questions.Count;
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

    public static List<Question> GetQuestions()
    {
        var fileService = new FileService();
        return fileService.ReadQuestionsFromFile();
    }
}