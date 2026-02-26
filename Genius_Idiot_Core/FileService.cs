using System.Text;

namespace Genius_Idiot_Core;

public class FileService
{
    private readonly string resultsPath;
    private readonly string questionsPath;
    private StreamWriter resultsWriter;
    private StreamReader resultsReader;
    private StreamWriter questionsWriter;
    private StreamReader questionsReader;
    
    public FileService()
    {
        var baseDir = AppDomain.CurrentDomain.BaseDirectory;
        var dataDir = Path.Combine(baseDir, "Data");
        Directory.CreateDirectory(dataDir);
        questionsPath = Path.Combine(dataDir, "questions.txt");

        var appDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),"GeniusIdiot");
        Directory.CreateDirectory(appDir);

        resultsPath = Path.Combine(appDir, "results.txt");



        var hasFileQuestions = File.Exists(questionsPath) && new FileInfo(questionsPath).Length > 0;
        if (!hasFileQuestions)
        {
            File.WriteAllLines(questionsPath, new[]
            {
                "Сколько будет два плюс два умноженное на два?|6",
                "Бревно нужно распилить на 10 частей, сколько надо сделать распилов?|9",
                "На двух руках 10 пальцев. Сколько пальцев на 5 руках?|25",
                "Укол делают каждые полчаса, сколько нужно минут для трех уколов?|60",
                "Пять свечей горело, две потухли. Сколько свечей осталось?|5"
            }, Encoding.UTF8);
        }

    }
    public void SaveResultsInFile(User user, UserResultsStorage results)
    {
        using var resultsWriter = new StreamWriter(resultsPath, true, Encoding.UTF8);
        var lastResult = results.Results.Last();
        resultsWriter.WriteLine($"{user.Name}-{lastResult.Score}-{lastResult.Level}-{lastResult.Date}");
        resultsWriter.Close();
    }

    public List<Question> GetQuestionsFromFile()
    {
        var questions = new List<Question>();
        questionsReader = new StreamReader(questionsPath, Encoding.UTF8);
        while (!questionsReader.EndOfStream)
        {
            string line = questionsReader.ReadLine();
            string[] values = line.Split('|');
            string question =  values[0];
            int answer = int.Parse(values[1]);
            questions.Add(new Question(question, answer));
        }
        questionsReader.Close();

        return questions;
    }
    public List<UserResult> GetPreviousResults()
    {
        var userResults = new List<UserResult>();
        //Console.WriteLine("{0,-20}{1,18}{2,15}{3,15}", "Имя","Кол-во правильных ответов","Результат","Дата");
        
        resultsReader = new StreamReader(resultsPath, Encoding.UTF8);
        while (!resultsReader.EndOfStream)
        {
            string line = resultsReader.ReadLine();
            string[] lineParts = line.Split('-');
            string userName = lineParts[0];
            int finalScore = int.Parse(lineParts[1]);
            string level = lineParts[2];
            DateTime date = DateTime.Parse(lineParts[3]);
            userResults.Add(new UserResult(level, finalScore, date));
        }
        resultsReader.Close();

        return userResults;
    }

    public void AddQuestionInFile(string question, int answer)
    {
        questionsWriter = new StreamWriter(questionsPath, true, Encoding.UTF8);
        questionsWriter.WriteLine($"{question}|{answer}");
        questionsWriter.Close();
    }

    public void RemoveQuestionFromFile(int numQuestion)
    {
        int index = numQuestion - 1;
        var lines = File.ReadAllLines(questionsPath, Encoding.UTF8).ToList();

        if (index >= 0 && index < lines.Count)
        {
            lines.RemoveAt(index);
            File.WriteAllLines(questionsPath, lines, Encoding.UTF8);
        }
    }
}