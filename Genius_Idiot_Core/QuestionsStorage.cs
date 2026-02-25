namespace Genius_Idiot_Core;

public class QuestionsStorage
{
    public List<Question> Questions { get; private set; }
    private FileService fileService { get; set; }
    public int Count { get; private set; }

    public QuestionsStorage(FileService fileService)
    {
        this.fileService = fileService;
        Questions = fileService.ReadQuestionsFromFile();
        Count = Questions.Count;
    }
    public List<Question> ShuffleQuestions(List<Question> nonShuffledQuestions)
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
}