using System.Text;

namespace Genius_Idiot_Console_App;

public class FileService
{
    private readonly string userResultsFilePath;
    private readonly string questionsListFilePath;
    private StreamWriter resultsWriter;
    private StreamReader resultsReader;
    private StreamWriter questionsWriter;
    private StreamReader questionsReader;
    
    public FileService()
    {
        userResultsFilePath = "/Users/aleksandr/RiderProjects/Genius_Idiot_App/Genius_Idiot_Console_App/user_results.txt";
        questionsListFilePath = "/Users/aleksandr/RiderProjects/Genius_Idiot_App/Genius_Idiot_Console_App/questions.txt";
        

        var hasFileQuestions = File.Exists(questionsListFilePath) && new FileInfo(questionsListFilePath).Length > 0;
        if (!hasFileQuestions)
        {
            questionsWriter = new StreamWriter(questionsListFilePath, true, Encoding.UTF8);
            questionsWriter.WriteLine("Сколько будет два плюс два умноженное на два?|6\n"+
                                      "Бревно нужно распилить на 10 частей, сколько надо сделать распилов?|9\n"+
                                      "На двух руках 10 пальцев. Сколько пальцев на 5 руках?|25\n"+
                                      "Укол делают каждые полчаса, сколько нужно минут для трех уколов?|60\n"+
                                      "Пять свечей горело, две потухли. Сколько свечей осталось?|5");
            questionsWriter.Close();
        }
        
    }
    public void SaveResultsInFile(User user, UserResultsStorage results)
    {
        resultsWriter = new StreamWriter(userResultsFilePath, true, Encoding.UTF8);
        var lastResult = results.Results.Last();
        resultsWriter.WriteLine($"{user.Name}-{lastResult.Score}-{lastResult.Level}-{lastResult.Date}");
        resultsWriter.Close();
    }

    public void ReadQuestionsFromFile(List<Question> questions)
    {
        questionsReader = new StreamReader(questionsListFilePath, Encoding.UTF8);
        while (!questionsReader.EndOfStream)
        {
            string line = questionsReader.ReadLine();
            string[] values = line.Split('|');
            string question =  values[0];
            int answer = int.Parse(values[1]);
            questions.Add(new Question(question, answer));
        }
        questionsReader.Close();
    }
    public void ShowPreviousResults()
    {
        Console.WriteLine("Хотите просмотреть предыдущие результат? Введите \"ДА\" для продолжения: ");
        string answer = Console.ReadLine().ToLower();

        if (answer.ToLower() != "да")
            return; 
        
        Console.WriteLine("{0,-20}{1,18}{2,15}{3,15}", "Имя","Кол-во правильных ответов","Результат","Дата");
        
        resultsReader = new StreamReader(userResultsFilePath, Encoding.UTF8);
        while (!resultsReader.EndOfStream)
        {
            string line = resultsReader.ReadLine();
            string[] lineParts = line.Split('-');
            string userName = lineParts[0];
            string finalScore = lineParts[1];
            string level = lineParts[2];
            string date = lineParts[3];
            Console.WriteLine("{0,-20}{1,15}{2,23}{3,32}", userName, finalScore, level, date);
        }
        resultsReader.Close();
    }

    public void AddQuestionInFile()
    {
        Console.Write("Введите формулировку вопроса: ");
        string inputQuestion = Console.ReadLine();
        Console.Write("Введите правильный ответ на вопрос: ");
        int inputAnswer = int.Parse(Console.ReadLine());
        questionsWriter = new StreamWriter(questionsListFilePath, true, Encoding.UTF8);
        questionsWriter.WriteLine($"{inputQuestion}|{inputAnswer}");
        questionsWriter.Close();
    }

    public void RemoveQuestion(int index)
    {
        
    }
}