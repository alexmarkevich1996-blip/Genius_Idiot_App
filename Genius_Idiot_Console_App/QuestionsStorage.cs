namespace Genius_Idiot_Console_App;

public class QuestionsStorage
{
    public List<Question> Questions { get; private set; }
    public int Count { get; private set; }

    public QuestionsStorage(FileService fileService)
    {
        Questions = new List<Question>();
        fileService.ReadQuestionsFromFile(Questions);
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
}